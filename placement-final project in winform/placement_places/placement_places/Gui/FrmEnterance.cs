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
        public static FrmEnterance FrmEnteranceInstance { get; } = new FrmEnterance();
        protected FrmEnterance()
        {
            InitializeComponent();
        }

        private void הוספתכתהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddClass f =FrmAddClass.FrmAddClassInstance;
            f.Show();
            this.Hide();
        }

        private void תלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוספתתלמידותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudents f =FrmAddStudents.FrmAddStudentsInstance;
            f.Show();
            this.Hide();
        }

        private void עדכוןאילוציתלמידהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudentConstraint f =FrmAddStudentConstraint.FrmAddStudentConstraintInstance;
            f.Show();
            this.Hide();
        }

        private void שיבוץמקומותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlacement s = FrmPlacement.FrmPlacementInstance;
            s.Show();
            this.Hide();
        }

        private void הגדרותכתהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }

        private void FrmEnterance_Load(object sender, EventArgs e)
        {

        }
    }
}
