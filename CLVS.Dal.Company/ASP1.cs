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
    
    public partial class ASP1
    {
        public string ItemCode { get; set; }
        public string CardCode { get; set; }
        public short LINENUM { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<short> ListNum { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string AutoUpdt { get; set; }
        public string Expand { get; set; }
        public int LogInstanc { get; set; }
    }
}
