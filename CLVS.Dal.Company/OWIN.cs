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
    
    public partial class OWIN
    {
        public int Id { get; set; }
        public Nullable<int> WFInstId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public string ProcDefId { get; set; }
        public string FlowElemId { get; set; }
        public string InfoType { get; set; }
        public string InfoCode { get; set; }
        public string Desc { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateTime { get; set; }
        public string IsRead { get; set; }
    }
}
