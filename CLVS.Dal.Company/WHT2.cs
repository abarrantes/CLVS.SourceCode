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
    
    public partial class WHT2
    {
        public Nullable<int> AbsEntry { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> EffectDate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> MinAmount { get; set; }
        public Nullable<decimal> MaxAmount { get; set; }
        public string WTCUR { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public int LineNum { get; set; }
        public int SeqNum { get; set; }
    }
}
