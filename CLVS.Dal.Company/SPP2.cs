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
    
    public partial class SPP2
    {
        public string ItemCode { get; set; }
        public string CardCode { get; set; }
        public short SPP1LNum { get; set; }
        public short SPP2LNum { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<short> UomEntry { get; set; }
        public Nullable<int> LogInstanc { get; set; }
    }
}
