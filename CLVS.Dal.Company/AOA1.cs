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
    
    public partial class AOA1
    {
        public int AgrNo { get; set; }
        public int AgrLineNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Nullable<short> ItemGroup { get; set; }
        public Nullable<decimal> PlanQty { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> CumQty { get; set; }
        public Nullable<decimal> CumAmntFC { get; set; }
        public Nullable<decimal> CumAmntLC { get; set; }
        public string FreeTxt { get; set; }
        public string InvntryUom { get; set; }
        public int LogInstanc { get; set; }
        public Nullable<int> VisOrder { get; set; }
        public Nullable<decimal> RetPortion { get; set; }
        public Nullable<System.DateTime> WrrtyEnd { get; set; }
        public string LineStatus { get; set; }
        public Nullable<decimal> PlanAmtLC { get; set; }
        public Nullable<decimal> PlanAmtFC { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> UomEntry { get; set; }
        public string UomCode { get; set; }
        public Nullable<decimal> NumPerMsr { get; set; }
    }
}
