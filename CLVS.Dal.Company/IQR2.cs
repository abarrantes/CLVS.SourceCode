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
    
    public partial class IQR2
    {
        public int DocEntry { get; set; }
        public int LineNum { get; set; }
        public int ChildNum { get; set; }
        public string BarCode { get; set; }
        public string UomCode { get; set; }
        public Nullable<decimal> UomQty { get; set; }
        public Nullable<decimal> CountQty { get; set; }
        public Nullable<decimal> Tk1UomQty { get; set; }
        public Nullable<decimal> Tk2UomQty { get; set; }
        public Nullable<decimal> Tk1CntQty { get; set; }
        public Nullable<decimal> Tk2CntQty { get; set; }
        public Nullable<decimal> ItmsPerUnt { get; set; }
        public Nullable<int> LogIns { get; set; }
        public Nullable<int> UgpEntry { get; set; }
    }
}
