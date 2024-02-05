using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL; 

namespace placement_places.Gui
{
    public partial class FrmPlacement : Form
    {
        public static FrmPlacement FrmPlacementInstance { get; } = new FrmPlacement();
        Nechami_placementEntities DB = new Nechami_placementEntities();
        public ClassXmlBll ClassToPlacementBLL { get; set; }
        public class_tbl ClassToPlacement { get; set; }
        List<students_tbl> students;
        protected FrmPlacement()
        {
            InitializeComponent();
            cmbClasses.Items.AddRange(DB.class_tbl.ToArray());
            ClassToPlacementBLL = new ClassXmlBll();
            ClassToPlacement = new class_tbl();
            groupBox1.Visible = false;
            cmbStudents.Visible = false;
            students = new List<students_tbl>();
        }
        public void DrawTables()
        {
            if(ClassToPlacementBLL.NumCoulmns==1 && ClassToPlacementBLL.NumLines==1)
            {
                MessageBox.Show("כתה זו לא הוגדרה");
                return;
            }    
            for (int i = 0; i < ClassToPlacementBLL.NumCoulmns; i++)
            {
                for (int j = 0; j < ClassToPlacementBLL.NumLines; j++)
                {
                    DeskUserControl table = new DeskUserControl(ClassToPlacementBLL.MatConstraints[j, i],this.ClassToPlacement);
                    table.Coulmn = i;
                    table.Line = j;
                    table.Location = new Point(600 - i * 188, j * 65);
                    table.Drop += DeleteFromListBox;
                    panel1.Controls.Add(table);
                }
            }
        }

        private void FrmPlacement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.ClassToPlacement = (class_tbl)(cmbClasses.SelectedItem);
            ClassToPlacementBLL.GradeName = this.ClassToPlacement.class_name;
            ClassToPlacementBLL.NumClass = Convert.ToInt32(this.ClassToPlacement.num_class_in_grade);
            this.ClassToPlacementBLL.GetClassFromXml();
            DrawTables();
            groupBox1.Visible = true;
            var students = DB.students_tbl.Where(x => x.class_tbl.id_class == this.ClassToPlacement.id_class).ToList();
            lstStudentsToPLace.DataSource = students;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is DeskUserControl)
                {
                    ((DeskUserControl)item).ClearSuitablePlaceToStudent();
                }
            }
                    students_tbl student = (students_tbl)(cmbStudents.SelectedItem);
            PlacementStudent psStudent = new PlacementStudent(student);
            List<propPlace_tbl> propPlace = new List<propPlace_tbl>();
            var tables = panel1.Controls;
            foreach (var item in tables)
            {
                if (item is DeskUserControl)
                {
                    propPlace = ((DeskUserControl)item).TableConstraints;
                    bool tableColitionStudent = psStudent.CheckConstraints(propPlace);
                    PlaceAdjustment checkPlaceStudent = psStudent.CheckPlace((((DeskUserControl)item).Line)+1);
                    if (tableColitionStudent && (checkPlaceStudent==PlaceAdjustment.possible|| checkPlaceStudent == PlaceAdjustment.excellent))
                    {
                        ((DeskUserControl)item).SuitablePlaceToStudent();
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            cmbStudents.Visible = true;
            var listStudents = DB.students_tbl.Where(x => x.class_tbl.class_name == this.ClassToPlacement.class_name).ToArray();
            cmbStudents.Items.AddRange(listStudents.Where(x => x.class_tbl.num_class_in_grade == this.ClassToPlacement.num_class_in_grade).ToArray());
        }

        private void btnSavePlacement_Click(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is DeskUserControl)
                {
                    DeskUserControl d = ((DeskUserControl)item);
                    this.ClassToPlacementBLL.SaveStudentPlacementInXmlBLL(this.ClassToPlacement.class_name,Convert.ToInt32(this.ClassToPlacement.num_class_in_grade),d.StudentA,d.Line,d.Coulmn);
                    this.ClassToPlacementBLL.SaveStudentPlacementInXmlBLL(this.ClassToPlacement.class_name, Convert.ToInt32(this.ClassToPlacement.num_class_in_grade), d.StudentB, d.Line, d.Coulmn);
                    d.StudentA.coulmn = d.Coulmn + 1;
                    d.StudentB.coulmn = d.Coulmn + 1;
                    d.StudentA.row = d.Line + 1;
                    d.StudentB.row = d.Line + 1;
                    DB.SaveChanges();
                }
            }
            MessageBox.Show("השבוץ נשמר בהצלחה!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmEnterance frmEnterance =FrmEnterance.FrmEnteranceInstance;
            frmEnterance.Show();
            this.Hide();
        }

        private void lstStudentsToPLace_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject obj = new DataObject(typeof(students_tbl).FullName, (sender as ListBox).SelectedItem);
            lstStudentsToPLace.DoDragDrop(obj, DragDropEffects.Copy);
        }

        private void lstStudentsToPLace_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void FrmPlacement_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        public void DeleteFromListBox(students_tbl s)
        {
            students.Remove(s);
            lstStudentsToPLace.DataSource = null;
            lstStudentsToPLace.DataSource = students;
        }
    }
}
