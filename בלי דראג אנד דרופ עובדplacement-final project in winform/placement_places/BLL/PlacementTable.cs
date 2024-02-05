using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PlacementTable
    {
        public students_tbl StudentA { get; set; }
        public students_tbl StudentB { get; set; }
        public PlaceAdjustment CheckChattingDegree(students_tbl student1, students_tbl student2)
        {
            if (student1.chatter_degree+student2.chatter_degree <5)
            {
                return PlaceAdjustment.excellent;
            }
            if (student1.chatter_degree + student2.chatter_degree < 7)
            {
                return PlaceAdjustment.possible;
            }
            return PlaceAdjustment.impossible;
        }
    }
}
