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
    
    public partial class OMIV
    {
        public int Entry { get; set; }
        public int Number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string BPCode { get; set; }
        public string BPName { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> LastBilled { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<decimal> CarryForw { get; set; }
        public Nullable<decimal> CurAmount { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public Nullable<decimal> OBPaid { get; set; }
        public Nullable<int> OBLstJENum { get; set; }
        public Nullable<int> Predeces { get; set; }
        public Nullable<int> Successor { get; set; }
        public Nullable<short> Series { get; set; }
        public string Cancelled { get; set; }
    }
}