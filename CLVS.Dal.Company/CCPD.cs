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
    
    public partial class CCPD
    {
        public int PerAbs { get; set; }
        public int Line_ID { get; set; }
        public string ProfitAct { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public Nullable<System.DateTime> TaxDate { get; set; }
        public string Memo { get; set; }
        public string MarkLine { get; set; }
        public string ActKeyLine { get; set; }
        public Nullable<decimal> LocBalLine { get; set; }
        public Nullable<decimal> FcBalLine { get; set; }
        public Nullable<decimal> SysBalLine { get; set; }
        public Nullable<int> ToPerAbs { get; set; }
        public string CtrlAct { get; set; }
        public string PL_ACCOUNT { get; set; }
    }
}
