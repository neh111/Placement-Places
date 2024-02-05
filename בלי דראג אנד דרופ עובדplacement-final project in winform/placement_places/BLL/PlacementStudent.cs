using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public enum PlaceAdjustment { excellent, possible, impossible }
    public class PlacementStudent
    {
        Nechami_placementEntities DB = new Nechami_placementEntities();
        public students_tbl Student { get; set; }
        public PlacementStudent(students_tbl student)
        {
            this.Student = student;
        }
        public bool CheckConstraints(List<propPlace_tbl> propPlace)
        {
            //הכנסת אילוצי התלמידה לרשימה זו
            var studentConstraint = DB.studentConstraints_tbl.Where(x => x.id_student == Student.id_student).ToList();
            if (studentConstraint.Count == 0)
                return true;
            var generalConstraints = DB.propPlace_tbl.ToList();
            foreach (var item in studentConstraint)
            {
                var p = generalConstraints.FirstOrDefault(x => x.id_propPlace == item.id_propPlace);
                if (p!=null)
                {
                    var c = propPlace.Where(x => x.propPlace_name == p.propPlace_name).FirstOrDefault();
                    if (c == null && item.status == true)
                        return false;
                    if (c != null && item.status == false)
                        return false;
                }
            }
            return true;
        }
        public PlaceAdjustment CheckPlace(int numLine)
        {
            if (numLine==this.Student.recommended_row)
            {
                return PlaceAdjustment.excellent; 
            }
            if (numLine == (this.Student.recommended_row+1)|| numLine == (this.Student.recommended_row-1))
            {
                return PlaceAdjustment.possible;
            }
            return PlaceAdjustment.impossible;
        }
    }
    
}
