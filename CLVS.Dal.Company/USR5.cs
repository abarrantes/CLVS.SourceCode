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
    
    public partial class USR5
    {
        public string UserCode { get; set; }
        public string Action { get; set; }
        public string ActionBy { get; set; }
        public string ClientIP { get; set; }
        public System.DateTime Date { get; set; }
        public int Time { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> ProcessID { get; set; }
        public Nullable<int> SessionID { get; set; }
        public Nullable<int> ReasonID { get; set; }
        public string ReasonDesc { get; set; }
        public Nullable<int> WinSessnID { get; set; }
        public string WinUsrName { get; set; }
        public string ProcName { get; set; }
    }
}
