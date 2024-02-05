using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public interface IDal
    {
        void BuildClassInXml(XElement classElement, int numClass, int numCoulmns, int numLines, List<propPlace_tbl>[,] matConstraints);
    }
}
