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
    
    public partial class DLN19
    {
        public int DocEntry { get; set; }
        public int BinAllocSe { get; set; }
        public Nullable<int> LineNum { get; set; }
        public Nullable<int> SubLineNum { get; set; }
        public Nullable<int> SnBType { get; set; }
        public Nullable<int> SnBMDAbs { get; set; }
        public Nullable<int> BinAbs { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string ItemCode { get; set; }
        public string WhsCode { get; set; }
        public string ObjType { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string AllowNeg { get; set; }
        public Nullable<short> BinActTyp { get; set; }
    }
}
