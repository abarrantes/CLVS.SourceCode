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
    
    public partial class AWMG
    {
        public int ID { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public string TmplateKey { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public Nullable<int> MAXIns { get; set; }
        public string Status { get; set; }
        public byte[] XMLFile { get; set; }
        public string Desc { get; set; }
        public int LogIns { get; set; }
        public string StartType { get; set; }
    }
}
