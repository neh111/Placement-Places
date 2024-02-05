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
    public delegate void EventHandler(object sender, EventArgs e);
    //public delegate void WorngAnswerSelected(WorngAnswerSelector correctAnswer);
    public partial class TablesToConstraints : UserControl
    {
        Nechami_placementEntities DB = new Nechami_placementEntities();
        public List<propPlace_tbl> ListConstraints { get; set; }
        public TablesToConstraints()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(DB.propPlace_tbl.ToArray());
            ListConstraints = new List<propPlace_tbl>();
        }

        private void TablesToConstraints_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListConstraints.Add((propPlace_tbl)comboBox1.SelectedItem);
        }
    }
}
