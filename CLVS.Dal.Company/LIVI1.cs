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
    
    public partial class LIVI1
    {
        public int LogEntry { get; set; }
        public int CalcNum { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UserToDate { get; set; }
        public Nullable<System.DateTime> ActuToDate { get; set; }
        public Nullable<int> LastMsgID { get; set; }
        public string Result { get; set; }
        public string ResultStr { get; set; }
        public Nullable<short> UserSign { get; set; }
        public string IgnFail { get; set; }
        public Nullable<System.DateTime> ReorderFrm { get; set; }
        public Nullable<System.DateTime> ReorderTo { get; set; }
        public Nullable<System.DateTime> StopDate { get; set; }
        public Nullable<short> StopTime { get; set; }
    }
}