//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class studentConstraints_tbl
    {
        public int id_studentConstraints { get; set; }
        public int id_student { get; set; }
        public int id_propPlace { get; set; }
        public bool status { get; set; }
    
        public virtual propPlace_tbl propPlace_tbl { get; set; }
        public virtual students_tbl students_tbl { get; set; }
    }
}
