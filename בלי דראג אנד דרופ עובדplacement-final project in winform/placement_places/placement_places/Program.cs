using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using placement_places.Gui;
//using System.Data.OleDb;
using System.Windows.Forms;

namespace placement_places
{
    static class Program
    {
        //[STAThread]
        static void Main(string[] args)
        {
            //מה השורות האלו עושות
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEnterance());
        }
    }
}
