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
    
    public partial class BNK2
    {
        public int IdNumber { get; set; }
        public int BSLine { get; set; }
        public short ListLineID { get; set; }
        public string DocID { get; set; }
        public Nullable<short> DocType { get; set; }
        public Nullable<decimal> AmntLC { get; set; }
        public Nullable<decimal> AmntFC { get; set; }
        public string IsDebit { get; set; }
        public string GLAct { get; set; }
        public string PrftCenter { get; set; }
        public string Project { get; set; }
        public string VatCode { get; set; }
        public string Selected { get; set; }
        public Nullable<decimal> VatLC { get; set; }
        public Nullable<decimal> VatFC { get; set; }
        public Nullable<int> Installmnt { get; set; }
        public string InterimAct { get; set; }
        public Nullable<int> JdtLine { get; set; }
        public Nullable<int> DocNum { get; set; }
        public string PrftCent2 { get; set; }
        public string PrftCent3 { get; set; }
        public string PrftCent4 { get; set; }
        public string PrftCent5 { get; set; }
        public string MatchLog { get; set; }
        public Nullable<decimal> DueBal { get; set; }
        public Nullable<decimal> DueBalFC { get; set; }
        public Nullable<decimal> AmntSC { get; set; }
    }
}
