using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ClassXmlBll
    {
        // ClassXmlDal c_DAL = new ClassXmlDal();
        //ClassXmlDal c_DAL;
        public string GradeName { get; set; }
        public int NumClass { get; set; }
        public int NumCoulmns { get; set; }
        public int NumLines { get; set; }
        public List<propPlace_tbl>[,] MatConstraints { get; set; }
        ClassXmlDal c_DAL = new ClassXmlDal();
        public void SavePlacementsConstraintsInXml_BLL(/*ClassXmlBll c,*/ string grade, int numClass, int numCoulmns, int numLines, List<propPlace_tbl> [,] matConstraints)
        {
            c_DAL.SavePlacementsConstraintsInXml_DAL(grade, numClass, numCoulmns, numLines, matConstraints);
            //c.GradeName = grade;
            //c.numClass = numClass;
            //c.numCoulmns = numCoulmns;
            //c.numLines = numLines;
            //c.MatConstraints = matConstraints;
        }
        public void GetClassFromXml()
        { 
            this.MatConstraints = c_DAL.GetMatConstraintsFromDal(this.GradeName, this.NumClass);
            this.NumCoulmns = MatConstraints.GetLength(1);
            this.NumLines = MatConstraints.GetLength(0);
        }
        public void SaveStudentPlacementInXmlBLL(string gradeName,int numClass,students_tbl student, int numLine, int numCoulmn)
        {
            c_DAL.SaveStudentPlacementInXmlDal(gradeName,numClass, student, numLine, numCoulmn);
        }
        public void SaveStudentPlacementInSqlBLL(students_tbl student, int numLine, int numCoulmn)
        {
            c_DAL.SaveStudentPlacementInSqlDal(student, numLine, numCoulmn);
        }
    }
}
