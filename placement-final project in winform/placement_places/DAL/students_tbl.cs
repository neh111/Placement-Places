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
    
    public partial class students_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students_tbl()
        {
            this.studentConstraints_tbl = new HashSet<studentConstraints_tbl>();
        }
    
        public int id_student { get; set; }
        public string family_name { get; set; }
        public string first_name { get; set; }
        public int id_class { get; set; }
        public decimal chatter_degree { get; set; }
        public Nullable<int> recommended_row { get; set; }
        public Nullable<int> coulmn { get; set; }
        public Nullable<int> row { get; set; }
    
        public virtual class_tbl class_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentConstraints_tbl> studentConstraints_tbl { get; set; }
        public override string ToString()
        {
            return this.first_name+" "+this.family_name;
        }

        //public override bool Equals(object obj)
        //{
        //    if(obj is students_tbl)
        //        return this.id_student == (obj as students_tbl).id_student;
        //    return false;
        //}
    }
}
