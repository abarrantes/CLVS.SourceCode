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
    
    public partial class OAT2
    {
        public int AgrNo { get; set; }
        public int AgrLnNum { get; set; }
        public int AgrEfctNum { get; set; }
        public string DatePeriod { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string CallUp { get; set; }
        public string WhsCode { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string ConsumeFCT { get; set; }
        public string FreeTxt { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public Nullable<decimal> AmountLC { get; set; }
        public Nullable<decimal> AmountFC { get; set; }
    }
}