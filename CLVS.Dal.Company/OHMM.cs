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
    
    public partial class OHMM
    {
        public int DocEntry { get; set; }
        public string ModelAuth { get; set; }
        public string ModelName { get; set; }
        public string ModelVer { get; set; }
        public string Desc { get; set; }
        public string Status { get; set; }
        public byte[] InfoFile { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public string ChangeBy { get; set; }
        public string CreateDate { get; set; }
        public Nullable<int> CreateTime { get; set; }
        public string ChangeDate { get; set; }
        public Nullable<int> ChangeTime { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<System.DateTime> DeployDate { get; set; }
        public Nullable<int> DeployTime { get; set; }
    }
}
