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
    
    public partial class OrgChiefAdmin
    {
        public int ChiefId { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> OrgRole { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<int> IndvDetailId { get; set; }
    
        public virtual IndvidualTbl IndvidualTbl { get; set; }
        public virtual OrgTbl OrgTbl { get; set; }
    }
}
