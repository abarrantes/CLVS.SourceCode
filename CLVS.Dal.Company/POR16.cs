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
    
    public partial class POR16
    {
        public int AbsEntry { get; set; }
        public int LineNum { get; set; }
        public int SnBIndex { get; set; }
        public string ItemCode { get; set; }
        public string WhsCode { get; set; }
        public Nullable<int> ObjId { get; set; }
        public Nullable<int> ObjAbs { get; set; }
        public Nullable<int> DrfWObjAbs { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> SubLineNum { get; set; }
        public string ObjType { get; set; }
        public Nullable<int> LogInstanc { get; set; }
    }
}
