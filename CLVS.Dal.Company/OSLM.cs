//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLVS.Dal.Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class OSLM
    {
        public int DocID { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<int> Ref1 { get; set; }
        public Nullable<int> Ref2 { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<decimal> TotDebit { get; set; }
        public Nullable<decimal> TotCredit { get; set; }
        public string RateType { get; set; }
        public string Comment { get; set; }
        public Nullable<short> UserSign { get; set; }
        public string Canceled { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<short> CancelUser { get; set; }
    }
}
