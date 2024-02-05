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
using placement_places.Gui;


namespace placement_places
{
    public partial class Settings : Form
    {
        Nechami_placementEntities DB = new Nechami_placementEntities();
        List<propPlace_tbl>[,] matConstraints;
        ClassXmlBll c_xml = new ClassXmlBll();
        //private FrmAddClass fclass;

        public Settings()
        {
            InitializeComponent();
            cmbGrades.Items.AddRange(DB.class_tbl.ToArray());
            btnToPlacement.Visible = false;
        }

        private void lbl_tatel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNoClass_Click(object sender, EventArgs e)
        {
            FrmAddClass fclass = new FrmAddClass();
            fclass.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            btnToPlacement.Visible = true;
            panel1.Visible = true;
            int numLines = Convert.ToInt32(numericNumLines.Value);
            int numCoulmns = Convert.ToInt32(numericNumCoulmns.Text);
            matConstraints = new List<propPlace_tbl>[numLines, numCoulmns];
            for (int i = 0; i < numCoulmns; i++)
            {
                for (int j = 0; j < numLines; j++)
                {
                    TablesToConstraints tableConstraints = new TablesToConstraints();
                    matConstraints[j,i] = tableConstraints.ListConstraints;
                    tableConstraints.Location = new Point(700-i*110, j*65);
                    panel1.Controls.Add(tableConstraints);
                }
            }
            numericNumCoulmns.Visible = false;
            numericNumLines.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnToPlacement_Click(object sender, EventArgs e)
        {
            ClassXmlBll c = new ClassXmlBll();
            c_xml.SavePlacementsConstraintsInXml_BLL(((class_tbl)cmbGrades.SelectedItem).class_name, Convert.ToInt32(((class_tbl)cmbGrades.SelectedItem).num_class_in_grade), Convert.ToInt32(numericNumCoulmns.Text), Convert.ToInt32(numericNumLines.Text), matConstraints);
            MessageBox.Show("ההגדרות נשמרו בהצלחה!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEnterance frmEnterance = new FrmEnterance();
            frmEnterance.Show();
            this.Hide();
        }

        private void numericNumCoulmns_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
