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
    
    public partial class OPPA
    {
        public int AbsEntry { get; set; }
        public string SecLevel { get; set; }
        public Nullable<int> PwdExp { get; set; }
        public Nullable<int> PwdMinLen { get; set; }
        public Nullable<int> MinUppers { get; set; }
        public Nullable<int> MinLowCase { get; set; }
        public Nullable<int> MinDigits { get; set; }
        public Nullable<int> MinNonAlph { get; set; }
        public Nullable<int> NumPrevPwd { get; set; }
        public Nullable<int> NumAuthLoc { get; set; }
        public string PwdExample { get; set; }
    }
}
