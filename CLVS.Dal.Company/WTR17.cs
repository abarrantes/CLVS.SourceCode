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
    
    public partial class WTR17
    {
        public int DocEntry { get; set; }
        public int LineNum { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string ObjectType { get; set; }
        public string ImpDocType { get; set; }
        public string ImpDocNum { get; set; }
        public Nullable<System.DateTime> DateOfReg { get; set; }
        public Nullable<System.DateTime> CustClrDat { get; set; }
        public string ConcActNum { get; set; }
        public string AdditNum { get; set; }
        public Nullable<decimal> AddItmDV { get; set; }
    }
}
