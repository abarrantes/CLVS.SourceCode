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
    
    public partial class OMTC
    {
        public int DocEntry { get; set; }
        public short MatchID { get; set; }
        public short Round { get; set; }
        public Nullable<short> MtcRule { get; set; }
        public string MtcAlias { get; set; }
        public Nullable<int> Differnce { get; set; }
        public Nullable<decimal> DiffAmnt { get; set; }
        public short RuleIndex { get; set; }
    }
}
