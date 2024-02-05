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
    public partial class DeskUserControl : UserControl
    {
        Nechami_placementEntities DB = new Nechami_placementEntities();
        
        PlacementTable pt = new PlacementTable();
        public int Coulmn { get; set; }
        public int Line { get; set; }
        public List <propPlace_tbl> TableConstraints { get; set; }
        public students_tbl StudentA { get; set; }
        public students_tbl StudentB { get; set; }
        //delegate
        public delegate void EventHandler(students_tbl s);
        public event EventHandler Drop;
        public DeskUserControl(List<propPlace_tbl> tableConstraints,class_tbl classToPLacement)
        {
            InitializeComponent();
            lblSuitable.Visible = false;
            //var listStudents = DB.students_tbl.Where(x => x.class_tbl.id_class == classToPLacement.id_class).ToArray();
            var listStudents = DB.students_tbl.Where(x =>x.class_tbl.class_name == classToPLacement.class_name).ToArray();
            cmbStudentA.Items.AddRange(listStudents.Where(x=>x.class_tbl.num_class_in_grade== classToPLacement.num_class_in_grade).ToArray());
            cmbStudentB.Items.AddRange(listStudents.Where(x => x.class_tbl.num_class_in_grade == classToPLacement.num_class_in_grade).ToArray());
            this.TableConstraints = tableConstraints;
            toolTip1.SetToolTip(this, this.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string str = "";
            this.StudentA = (students_tbl)(cmbStudentA.SelectedItem);
            PlacementStudent psStudentA = new PlacementStudent(StudentA);
            bool tableColitionStudentA = psStudentA.CheckConstraints(this.TableConstraints);
            PlaceAdjustment checkPlaceStudentA = psStudentA.CheckPlace(this.Line);
            if (!tableColitionStudentA)
            {
                str += "אילוצי השולחן והתלמידה מתנגשים." + "\n";
            }
            if (checkPlaceStudentA == PlaceAdjustment.impossible)
            {
                str += "מספר השורה אינו מתאים כלל למספר השורה שהומלץ לתלמידה." + "\n";
            }
            if (checkPlaceStudentA == PlaceAdjustment.impossible)
            {
                str += "מספר השורה אינו כל כך מתאים למספר השורה שהומלץ לתלמידה." + "\n";
            }
            errorProvider1.SetError(this, str);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            string str = "";
            this.StudentB = (students_tbl)(cmbStudentB.SelectedItem);
            PlacementStudent psStudentB = new PlacementStudent(StudentB);
            bool tableColitionStudentB = psStudentB.CheckConstraints(this.TableConstraints);
            PlaceAdjustment checkPlaceStudentB = psStudentB.CheckPlace(this.Line+1);
            if (!tableColitionStudentB)
            {
                str += ".אילוצי השולחן והתלמידה מתנגשים" + "\n";
            }
            if (checkPlaceStudentB==PlaceAdjustment.impossible)
            {
                str += ".מספר השורה אינו מתאים כלל למספר השורה שהומלץ לתלמידה" + "\n";
            }
            else
            { 
            if (checkPlaceStudentB == PlaceAdjustment.possible)
            {
                str += ".מספר השורה אינו כל כך מתאים למספר השורה שהומלץ לתלמידה" + "\n";
            }
            }
            errorProvider2.SetError(this, str);
        }

        private void btnCheckAdjustment_Click(object sender, EventArgs e)
        {
            PlaceAdjustment checkChatting = pt.CheckChattingDegree(this.StudentA, this.StudentB);
            if (checkChatting == PlaceAdjustment.excellent)
                this.BackColor = Color.Green;
            else
            {
                if (checkChatting == PlaceAdjustment.impossible)
                    this.BackColor = Color.Red;
                else
                    this.BackColor = Color.Orange;
            }

        }

        private void DeskUserControl_Load(object sender, EventArgs e)
        {
        }
        public override string ToString()
        {
            string str = "";
            if(this.TableConstraints!=null)
            { 
            foreach (var item in this.TableConstraints)
            {
                str += item.ToString() + "\n";
            }
            }
            return str;
        }
        public void SuitablePlaceToStudent()
        {
            lblSuitable.Visible = true;
        }
        public void ClearSuitablePlaceToStudent()
        {
            lblSuitable.Visible = false;
        }

        private void DeskUserControl_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string str = "\n";
            var students = cmbStudentA.Items;
            foreach (var item in students)
            {
                PlacementStudent psStudent = new PlacementStudent((students_tbl)item);
                bool tableColitionStudent = psStudent.CheckConstraints(this.TableConstraints);
                PlaceAdjustment checkPlaceStudent = psStudent.CheckPlace(this.Line);
                if (tableColitionStudent && (checkPlaceStudent == PlaceAdjustment.possible || checkPlaceStudent == PlaceAdjustment.excellent))
                {
                    str += item.ToString() + "\n";
                }
            }
            MessageBox.Show("התלמידות היכולות לשבת בשולחן זה הן:" + str);
        }

        private void cmbStudentA_DragDrop(object sender, DragEventArgs e)
        {
            students_tbl student = e.Data.GetData(typeof(students_tbl)) as students_tbl;
            (sender as ComboBox).SelectedItem = student;
            (sender as ComboBox).Text = student.ToString();
            Drop?.Invoke(student);
        }

        private void cmbStudentA_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void DeskUserControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void cmbStudentB_DragDrop(object sender, DragEventArgs e)
        {
            students_tbl student = e.Data.GetData(typeof(students_tbl)) as students_tbl;
            (sender as ComboBox).SelectedItem = student;
            (sender as ComboBox).Text = student.ToString();
            Drop?.Invoke(student);
        }

        private void cmbStudentB_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
