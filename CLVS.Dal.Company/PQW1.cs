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
    
    public partial class PQW1
    {
        public int AbsEntry { get; set; }
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public Nullable<System.DateTime> PQTReqDate { get; set; }
        public Nullable<decimal> PQTReqQty { get; set; }
        public string BuyUnitMsr { get; set; }
        public string FreeTxt { get; set; }
        public Nullable<int> PQTGrpNum { get; set; }
        public Nullable<short> PQTGrpSer { get; set; }
        public string PQTGrpHW { get; set; }
        public Nullable<System.DateTime> ValidUntil { get; set; }
        public string WhsCode { get; set; }
        public Nullable<int> PRAbsEntry { get; set; }
        public string ReqName { get; set; }
        public Nullable<int> PRLineNum { get; set; }
        public string PRLineStat { get; set; }
        public string DistriRule { get; set; }
        public string Project { get; set; }
        public string VendMfrNum { get; set; }
        public Nullable<short> ShipType { get; set; }
        public Nullable<decimal> ItmPerUnit { get; set; }
    }
}
