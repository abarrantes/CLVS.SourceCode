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
    
    public partial class OWTJ
    {
        public int Id { get; set; }
        public string IsASync { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> StartTime { get; set; }
        public Nullable<int> TimerEtyId { get; set; }
        public string JobHanConf { get; set; }
        public string JobHanType { get; set; }
        public string LastUpdate { get; set; }
    }
}
