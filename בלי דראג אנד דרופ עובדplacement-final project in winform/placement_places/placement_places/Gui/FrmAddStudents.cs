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
using placement_places.Validate;

namespace placement_places.Gui
{
    public partial class FrmAddStudents : Form
    {
        private bool flagAdd;
        private bool flagUpdate;
        private students_tbl tbl_student;
        //private class_tbl tbl_class;
        Nechami_placementEntities DB = new Nechami_placementEntities();
        private FrmAddStudents f;

        public FrmAddStudents()
        {
            InitializeComponent();
            NotPossible();
           //cmb_className.DataSource = DB.class_tbl.ToList();
            cmb_className.Items.AddRange(DB.class_tbl.ToArray());
            ShowOnDataGridView();
            //btnDelete.Visible = false;
        }
        void NotPossible()
        {
            btn_save.Visible = false;
            txt_idStudent.ReadOnly = true;
            txt_firstName.ReadOnly = true;
            txt_lastName.ReadOnly = true;
            txt_placementCoulmn.ReadOnly = true;
            txt_placementRow.ReadOnly = true;
            cmb_className.Enabled = false;
            numeric_recommendedRow.Enabled = false;
            numeric_talkingDegree.Enabled = false;
        }
        void Possible()
        {
            btn_save.Visible = true;
            txt_idStudent.ReadOnly = true;
            txt_firstName.ReadOnly = false;
            txt_lastName.ReadOnly = false;
            txt_placementCoulmn.ReadOnly = false;
            txt_placementRow.ReadOnly = false;
            cmb_className.Enabled = true;
            numeric_recommendedRow.Enabled = true;
            numeric_talkingDegree.Enabled = true;
        }
       void ClearControls()
        {
            txt_idStudent.Text = "";
            txt_firstName.Text="";
            txt_lastName.Text = "";
            cmb_className.Text = "";
            numeric_talkingDegree.Value = 1;
            numeric_recommendedRow.Value = 0;
            txt_placementCoulmn.Text = "";
            txt_placementRow.Text = "";
        }

        private void FrmAddStudents_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            Possible();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string st = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                students_tbl s = DB.students_tbl.Find(Convert.ToInt32(st));
                Fill(s);
                tbl_student = s;
            }
        }
        public void Fill(students_tbl s)
        {
            txt_idStudent.Text = s.id_student.ToString();
            txt_firstName.Text = s.first_name;
            txt_lastName.Text = s.family_name;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_placementCoulmn.Visible = false;
            txt_placementRow.Visible = false;
            lbl_coulmnPlacement.Visible = false;
            lbl_rowPlacement.Visible = false;
            ClearControls();
            Possible();
            flagAdd = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagAdd)
            {
                tbl_student = new students_tbl();
                if (CreateFields(tbl_student))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף תלמידה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        DB.students_tbl.Add(tbl_student);
                        DB.SaveChanges();
                        NotPossible();
                        ClearControls();
                        ShowOnDataGridView();
                    }
                }
                //if (flagUpdate)
                //{
                //    if (CreateFields(packages))
                //    {
                //        DialogResult r = MessageBox.Show("האם לעדכן חבילה זו?", "עדכון אישור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                //        if (r == DialogResult.Yes)
                //        {
                //            tblPackages.UpDateRow(packages);
                //            NotPossible();
                //        }
                //    }

                //}
            }
        }
        private bool CreateFields(students_tbl s)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                s.first_name = txt_firstName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_firstName, ex.Message);
                ok = false;
            }
            try
            {
                s.family_name = txt_lastName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_lastName, ex.Message);
                ok = false;
            }
            try
            {
                if (cmb_className.SelectedItem != null)
                    //לבדוק אם ככה עושים
                    s.id_class = ((class_tbl)cmb_className.SelectedItem).id_class;
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_className, ex.Message);
                ok = false;
            }
            try
            {
                s.chatter_degree = numeric_talkingDegree.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(numeric_talkingDegree, ex.Message);
                ok = false;
            }
            try
            {
                s.recommended_row = (int?)numeric_recommendedRow.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(numeric_recommendedRow, ex.Message);
                ok = false;
            }
            return ok;
        }
        public void ShowOnDataGridView()
        {
            dataGridView1.DataSource = DB.students_tbl.ToList().Select(x => new
            {
                קוד_תלמידה = x.id_student,
                שם_פרטי = x.first_name,
                שם_משפחה = x.family_name,
                כיתה = x.class_tbl.class_name.TrimEnd()+x.class_tbl.num_class_in_grade,
                דרגת_פטפוט = x.chatter_degree,
                שורה_מומלצת = x.recommended_row,
                טור_השיבוץ = x.coulmn,
                שורת_השבוץ = x.row
            }).ToList();
        }

        private void btn_showAllStudents_Click(object sender, EventArgs e)
        {
            ShowOnDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_idStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_className_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmEnterance frmEnterance = new FrmEnterance();
            frmEnterance.Show();
            this.Hide();
        }
    }
}
