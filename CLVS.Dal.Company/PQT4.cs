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
    
    public partial class PQT4
    {
        public int DocEntry { get; set; }
        public Nullable<int> LineNum { get; set; }
        public Nullable<int> GroupNum { get; set; }
        public Nullable<int> ExpnsCode { get; set; }
        public Nullable<int> RelateType { get; set; }
        public string StcCode { get; set; }
        public string StaCode { get; set; }
        public Nullable<int> staType { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public string TaxAcct { get; set; }
        public Nullable<decimal> TaxSum { get; set; }
        public Nullable<decimal> TaxSumFrgn { get; set; }
        public Nullable<decimal> TaxSumSys { get; set; }
        public Nullable<decimal> BaseSum { get; set; }
        public Nullable<decimal> BaseSumFrg { get; set; }
        public Nullable<decimal> BaseSumSys { get; set; }
        public string ObjectType { get; set; }
        public Nullable<int> LogInstanc { get; set; }
        public string TaxStatus { get; set; }
        public Nullable<decimal> VatApplied { get; set; }
        public Nullable<decimal> VatAppldFC { get; set; }
        public Nullable<decimal> VatAppldSC { get; set; }
        public int LineSeq { get; set; }
        public string DeferrAcct { get; set; }
        public Nullable<int> BaseType { get; set; }
        public Nullable<int> BaseAbs { get; set; }
        public Nullable<int> BaseSeq { get; set; }
        public Nullable<decimal> DeductTax { get; set; }
        public Nullable<decimal> DdctTaxFrg { get; set; }
        public Nullable<decimal> DdctTaxSys { get; set; }
        public Nullable<decimal> BaseAppld { get; set; }
        public Nullable<decimal> BaseApldFC { get; set; }
        public Nullable<decimal> BaseApldSC { get; set; }
        public Nullable<decimal> NonDdctPrc { get; set; }
        public string NonDdctAct { get; set; }
        public string TaxInPrice { get; set; }
        public string Exempt { get; set; }
        public string TaxExpAct { get; set; }
        public Nullable<decimal> OnHoldTax { get; set; }
        public Nullable<decimal> OnHoldTaxF { get; set; }
        public Nullable<decimal> OnHoldTaxS { get; set; }
        public string InGrossRev { get; set; }
        public Nullable<decimal> TaxSumOrg { get; set; }
        public Nullable<decimal> TaxSumOrgF { get; set; }
        public Nullable<decimal> TaxSumOrgS { get; set; }
        public Nullable<decimal> OpenTax { get; set; }
        public Nullable<decimal> OpenTaxFC { get; set; }
        public Nullable<decimal> OpenTaxSC { get; set; }
    }
}
