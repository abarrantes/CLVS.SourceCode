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
    
    public partial class RDR20
    {
        public int DocEntry { get; set; }
        public Nullable<int> ExpnsCode { get; set; }
        public Nullable<decimal> TotalLC { get; set; }
        public Nullable<decimal> TotalFC { get; set; }
        public Nullable<decimal> TotalSC { get; set; }
        public string DistribM { get; set; }
        public Nullable<decimal> DrawnLC { get; set; }
        public Nullable<decimal> DrawnFC { get; set; }
        public Nullable<decimal> DrawnSC { get; set; }
        public int LineNum { get; set; }
        public Nullable<int> BaseAbsEnt { get; set; }
        public Nullable<int> BaseType { get; set; }
        public Nullable<int> BaseRef { get; set; }
        public Nullable<int> BaseLnNum { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string ObjectType { get; set; }
        public string FixCurr { get; set; }
    }
}
