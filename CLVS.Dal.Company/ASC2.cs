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
    
    public partial class ASC2
    {
        public int SrcvCallID { get; set; }
        public short Line { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> TransToTec { get; set; }
        public Nullable<decimal> Delivered { get; set; }
        public Nullable<decimal> RetFromTec { get; set; }
        public Nullable<decimal> Returned { get; set; }
        public string Bill { get; set; }
        public Nullable<decimal> QtyToBill { get; set; }
        public Nullable<decimal> QtyToInv { get; set; }
        public string ObjectType { get; set; }
        public int LogInstanc { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<short> UserSign2 { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> VisOrder { get; set; }
    }
}
