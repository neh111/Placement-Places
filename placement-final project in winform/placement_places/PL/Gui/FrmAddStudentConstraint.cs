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

namespace placement_places.Gui
{
    public partial class FrmAddStudentConstraint : Form
    {
        Nechami_placementEntities DB = new Nechami_placementEntities();
        public FrmAddStudentConstraint()
        {
            InitializeComponent();
            cmbStudents.Items.AddRange(DB.students_tbl.ToArray());
            cmbConstraint.Items.AddRange(DB.propPlace_tbl.ToArray());
            cmbConstraint.Visible = false;
            lblChooseConstraint.Visible = false;
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChooseConstraint.Visible = true;
            cmbConstraint.Visible = true;
        }

        private void FrmAddStudentConstraint_Load(object sender, EventArgs e)
        {

        }

        private void lblChooseConstraint_Click(object sender, EventArgs e)
        {

        }

        private void cmbConstraint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbStudents.Visible = false;
            //Label nameStudent = new Label();
            //nameStudent.Text = ((students_tbl)(cmbStudents.SelectedItem)).ToString();
            //nameStudent.Location = new Point(1109, 158);
            studentConstraints_tbl sc = new studentConstraints_tbl();
            sc.id_student= ((students_tbl)(cmbStudents.SelectedItem)).id_student;
            sc.id_propPlace = ((propPlace_tbl)(cmbConstraint.SelectedItem)).id_propPlace;
            sc.status = true;
            DB.studentConstraints_tbl.Add(sc);
            DB.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEnterance frmEnterance = new FrmEnterance();
            frmEnterance.Show();
            this.Hide();
        }
    }
}
