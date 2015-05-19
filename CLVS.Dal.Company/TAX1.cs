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
    
    public partial class TAX1
    {
        public int AbsEntry { get; set; }
        public int LineSeq { get; set; }
        public Nullable<int> SrcArrType { get; set; }
        public Nullable<int> SrcLineNum { get; set; }
        public Nullable<int> SrcGrpNum { get; set; }
        public string TaxCode { get; set; }
        public string StaCode { get; set; }
        public Nullable<int> StaType { get; set; }
        public Nullable<int> StaIndex { get; set; }
        public string IsLiable { get; set; }
        public string TaxType { get; set; }
        public string IsAcq { get; set; }
        public string Isdeferred { get; set; }
        public Nullable<System.DateTime> ValueDate { get; set; }
        public Nullable<decimal> VatPercent { get; set; }
        public Nullable<decimal> NdPercent { get; set; }
        public Nullable<decimal> EqPercent { get; set; }
        public string BaseObjTyp { get; set; }
        public Nullable<int> BaseAbs { get; set; }
        public Nullable<int> BaseArrTyp { get; set; }
        public Nullable<int> BaseLinNum { get; set; }
        public Nullable<int> BaseGrpNum { get; set; }
        public Nullable<decimal> BaseSum { get; set; }
        public Nullable<decimal> BaseSumSc { get; set; }
        public Nullable<decimal> BaseSumFc { get; set; }
        public Nullable<decimal> VatSum { get; set; }
        public Nullable<decimal> VatSumSc { get; set; }
        public Nullable<decimal> VatSumFc { get; set; }
        public Nullable<decimal> DeductSum { get; set; }
        public Nullable<decimal> DedctSumSC { get; set; }
        public Nullable<decimal> DedctSumFC { get; set; }
        public Nullable<decimal> EqSum { get; set; }
        public Nullable<decimal> EqSumSC { get; set; }
        public Nullable<decimal> EqSumFC { get; set; }
        public string TaxAcct { get; set; }
        public string DefAcct { get; set; }
        public string NdAcct { get; set; }
        public string AcqAcct { get; set; }
        public string ExpAcct { get; set; }
        public string CrditDebit { get; set; }
        public string PostingTyp { get; set; }
        public Nullable<decimal> BasePaid { get; set; }
        public Nullable<decimal> BasePaidSC { get; set; }
        public Nullable<decimal> BasePaidFC { get; set; }
        public Nullable<decimal> VatPaid { get; set; }
        public Nullable<decimal> VatPaidSC { get; set; }
        public Nullable<decimal> VatPaidFC { get; set; }
        public Nullable<decimal> DeductPaid { get; set; }
        public Nullable<decimal> DdctPaidSC { get; set; }
        public Nullable<decimal> DdctPaidFC { get; set; }
        public Nullable<decimal> EqPaid { get; set; }
        public Nullable<decimal> EqPaidSC { get; set; }
        public Nullable<decimal> EqPaidFC { get; set; }
        public string TransAcct { get; set; }
        public Nullable<int> LnDataNum { get; set; }
        public string InPrice { get; set; }
        public string Exempt { get; set; }
        public string InGrossRev { get; set; }
        public string PostStatus { get; set; }
        public string IsItmLevel { get; set; }
        public Nullable<decimal> MinTAmt { get; set; }
        public Nullable<decimal> MinTAmtSC { get; set; }
        public Nullable<decimal> MinTAmtFC { get; set; }
        public Nullable<decimal> MaxTAmt { get; set; }
        public Nullable<decimal> MaxTAmtSC { get; set; }
        public Nullable<decimal> MaxTAmtFC { get; set; }
        public Nullable<decimal> FlatTAmt { get; set; }
        public Nullable<decimal> FlatTAmtSC { get; set; }
        public Nullable<decimal> FlatTAmtFC { get; set; }
        public string EqTaxAcct { get; set; }
    }
}