using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace placement_places.Gui
{
    public partial class FrmEnterance : Form
    {
        public FrmEnterance()
        {
            InitializeComponent();
        }

        private void הוספתכתהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddClass f = new FrmAddClass();
            f.Show();
            this.Hide();
        }

        private void תלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוספתתלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudents f = new FrmAddStudents();
            f.Show();
            this.Hide();
        }

        private void עדכוןאילוציתלמידהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudentConstraint f = new FrmAddStudentConstraint();
            f.Show();
            this.Hide();
        }

        private void שיבוץמקומותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlacement s = new FrmPlacement();
            s.Show();
            this.Hide();
        }

        private void הגדרותכתהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }
    }
}
