using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class ClassXmlDal
    {
        XElement myRoot;
        XDocument myClassMap;
        Nechami_placementEntities DB = new Nechami_placementEntities();
        //public string GradeName { get; set; }
        //public int numClass { get; set; }
        //public int numCoulmns { get; set; }
        //public int numLines { get; set; }
        //public  List<propPlace_tbl>[,] MatConstraints { get; set; }
        public ClassXmlDal()
        {
            //var files = Directory.GetFiles("xml/classMap.xml").ToList();
            myClassMap = XDocument.Load("xml/classMap.xml");//סוג המחלקה היא מחלקה שטוענת קובץ xml
            myRoot = myClassMap.Root;
        }
        public void SavePlacementsConstraintsInXml_DAL(string grade, int numClass, int numCoulmns, int numLines, List<propPlace_tbl>[,] matConstraints)
        {
            XElement newGrade = myRoot.Descendants("grade").Where(x => x.Attribute("name").Value == grade).FirstOrDefault();
            if (newGrade == null)
            {
                BuildGradeInXml(grade, numClass, numCoulmns, numLines, matConstraints);
            }
            else
            {
                XElement newClassCheck = myRoot.Descendants("numClassInGrade").Where(x => Convert.ToInt32(x.Attribute("numClass").Value) == numClass).FirstOrDefault();
                if (newClassCheck == null)
                {
                    XElement newClass = new XElement("numClassInGrade", new XAttribute("numClass", numClass));
                    newGrade.Add(newClass);
                    BuildClassInXml(newClass, numClass, numCoulmns, numLines, matConstraints);
                }
                else
                {
                    newClassCheck.Descendants("row").Remove();
                    BuildClassInXml(newClassCheck, numClass, numCoulmns, numLines, matConstraints);
                }
            }
            myClassMap.Save(@"xml/classMap.xml");

        }
        public void BuildGradeInXml(string grade, int numClass, int numCoulmns, int numLines, List<propPlace_tbl>[,] matConstraints)
        {
            XElement newGrade = new XElement("grade"
                   , new XAttribute("name", grade));
            XElement newClass = new XElement("numClassInGrade", new XAttribute("numClass", numClass));
            newGrade.Add(newClass);
            BuildClassInXml(newClass, numClass, numCoulmns, numLines, matConstraints);
            myRoot.Add(newGrade);
        }

        public void BuildClassInXml(XElement classElement, int numClass, int numCoulmns, int numLines, List<propPlace_tbl>[,] matConstraints)
        {
            //classElement.Add(new XAttribute("numClass", numClass));
            for (int i = 0; i < numCoulmns; i++)
            {
                XElement newRow = new XElement("row", new XAttribute("numRow", i + 1));
                for (int j = 0; j < numLines; j++)
                {
                    XElement newTable = new XElement("table", new XAttribute("numLine", j + 1));
                    for (int z = 0; z < matConstraints[j, i].Count; z++)
                    {
                        List<propPlace_tbl> list = matConstraints[j, i];
                        XElement constraint = new XElement("constraint", list[z].propPlace_name);
                        newTable.Add(constraint);
                    }
                    newRow.Add(newTable);
                }
                classElement.Add(newRow);
            }
            
        }
        public List<propPlace_tbl>[,] GetMatConstraintsFromDal(string gradeName, int numClass)
        {
            XElement grade = myRoot.Descendants("grade").Where(x => x.Attribute("name").Value == gradeName).FirstOrDefault();
            List<propPlace_tbl>[,] matConstraints=new List<propPlace_tbl>[1,1];
            if (grade!=null)
            {
                XElement classToReturn = myRoot.Descendants("numClassInGrade").Where(x => Convert.ToInt32(x.Attribute("numClass").Value) == numClass).FirstOrDefault();
                if(classToReturn!=null)
                {
                   int numRows=classToReturn.Descendants("row").Count();
                    XElement singleRow = classToReturn.Descendants("row").FirstOrDefault();
                    int numLines = singleRow.Descendants("table").Count();
                    matConstraints = new List<propPlace_tbl>[numRows, numLines];
                    List<propPlace_tbl> constraintsFromXml;
                    for (int i = 0; i < numRows; i++)
                    {
                        for (int j = 0; j < numLines; j++)
                        {
                            XElement thisRow = classToReturn.Descendants("row").Single(x =>Convert.ToInt32(x.Attribute("numRow").Value) == i + 1);
                            XElement thisTable = thisRow.Descendants("table").Single(x => Convert.ToInt32(x.Attribute("numLine").Value) == j + 1);
                            propPlace_tbl p = new propPlace_tbl();
                            constraintsFromXml= new List<propPlace_tbl>();
                            foreach (var item in thisTable.Descendants("constraint").ToList())
                            {
                                p.propPlace_name = item.Value;
                                p.id_propPlace = GetIdPropPlace(p.propPlace_name);
                                constraintsFromXml.Add(p);
                            }
                            matConstraints[j, i] = constraintsFromXml;
                        }
                    }
                }
            }
            return matConstraints;
        }
        public int GetIdPropPlace(string nameProp)
        {
            return DB.propPlace_tbl.Single(x => x.propPlace_name == nameProp).id_propPlace; 
        }
        public void SaveStudentPlacementInXmlDal(string gradeName, int numClass, students_tbl student, int numLine, int numCoulmn)
        {
            XElement grade = myRoot.Descendants("grade").Where(x => x.Attribute("name").Value == gradeName).FirstOrDefault();
            XElement thisClass = grade.Descendants("numClassInGrade").Where(x => Convert.ToInt32(x.Attribute("numClass").Value) == numClass).FirstOrDefault();
            var coulmns = thisClass.Descendants("row").Where(x => Convert.ToInt32(x.Attribute("numRow").Value) == numCoulmn+1).ToList();
            XElement tableToPLacement = coulmns.Descendants("table").Single(x => Convert.ToInt32(x.Attribute("numLine").Value) == numLine+1);
            XElement stu = new XElement("student",new XAttribute("name",student.ToString()));
            tableToPLacement.Add(stu);
            myClassMap.Save(@"xml/classMap.xml");
        }
        public void SaveStudentPlacementInSqlDal(students_tbl student, int numLine, int numCoulmn)
        {
            student.coulmn = numCoulmn+1;
            student.row = numLine+1;
            DB.students_tbl.Find(student).row = numLine;
            DB.students_tbl.Find(student).coulmn = numCoulmn;
            DB.SaveChanges();
        }
    }
}
