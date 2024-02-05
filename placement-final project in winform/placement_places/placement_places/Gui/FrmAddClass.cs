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
    public partial class FrmAddClass : Form
    {
        public static FrmAddClass FrmAddClassInstance { get; } = new FrmAddClass();
        private bool flagAdd;
        private class_tbl t_class;
        Nechami_placementEntities DB = new Nechami_placementEntities();
        protected FrmAddClass()
        {
            InitializeComponent();
            NotPossible();
            ShowOnDataGridView();
        }
        void NotPossible()
        {
            btnSave.Visible = false;
            btnRefresh.Visible = false;
            txtCodeClass.ReadOnly = true;
            txtNameGrade.ReadOnly = true;
        }
        public void ShowOnDataGridView()
        {
            dataGridView1.DataSource = DB.class_tbl.ToList().Select(x => new
            {
                קוד_כתה = x.id_class,
                שם_שנתון = x.class_name.TrimEnd(),
                מספר_כתה_בשנתון= x.num_class_in_grade
            }).ToList();
        }
        void ClearControls()
        {
            txtNameGrade.Text = "";
            txtNumClass.Text = "";
        }
        void Possible()
        {
            txtNameGrade.ReadOnly = false;
            btnSave.Visible = true;
        }
        private bool CreateFields(class_tbl c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                foreach (var item in DB.class_tbl)
                {
                    if (item.class_name.TrimEnd() == txtNameGrade.Text && item.num_class_in_grade == Convert.ToInt32(txtNumClass.Text))
                    {
                        ok = false;
                    }
                }
                c.class_name = txtNameGrade.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNameGrade, ex.Message);
                ok = false;
            }
            try
            {
                c.num_class_in_grade = Convert.ToInt32(txtNumClass.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumClass, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnRefresh.Visible = true;
            if (flagAdd)
            {
                t_class = new class_tbl();
                if (CreateFields(t_class))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף כתה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        DB.class_tbl.Add(t_class);
                        DB.SaveChanges();
                        NotPossible();
                        ClearControls();
                        ShowOnDataGridView();
                    }
                }
                else
                    MessageBox.Show("הכתה קיימת כבר");
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClearControls();
            Possible();
            flagAdd = true;
        }

        private void lblNameClass_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowOnDataGridView();
        }

        private void btnToSettings_Click(object sender, EventArgs e)
        {
            FrmEnterance frmEnterance = FrmEnterance.FrmEnteranceInstance;
            frmEnterance.Show();
            this.Hide();
        }

        private void txtNameGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddClass_Load(object sender, EventArgs e)
        {

        }
    }
}
