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
    
    public partial class AJD1
    {
        public int TransId { get; set; }
        public int Line_ID { get; set; }
        public string Account { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> SYSCred { get; set; }
        public Nullable<decimal> SYSDeb { get; set; }
        public Nullable<decimal> FCDebit { get; set; }
        public Nullable<decimal> FCCredit { get; set; }
        public string FCCurrency { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> SourceID { get; set; }
        public Nullable<short> SourceLine { get; set; }
        public string ShortName { get; set; }
        public Nullable<int> IntrnMatch { get; set; }
        public Nullable<int> ExtrMatch { get; set; }
        public string ContraAct { get; set; }
        public string LineMemo { get; set; }
        public string Ref3Line { get; set; }
        public string TransType { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public Nullable<System.DateTime> Ref2Date { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string BaseRef { get; set; }
        public string Project { get; set; }
        public string TransCode { get; set; }
        public string ProfitCode { get; set; }
        public Nullable<System.DateTime> TaxDate { get; set; }
        public Nullable<decimal> SystemRate { get; set; }
        public Nullable<System.DateTime> MthDate { get; set; }
        public Nullable<decimal> ToMthSum { get; set; }
        public Nullable<short> UserSign { get; set; }
        public Nullable<int> BatchNum { get; set; }
        public Nullable<int> FinncPriod { get; set; }
        public Nullable<int> RelTransId { get; set; }
        public Nullable<int> RelLineID { get; set; }
        public string RelType { get; set; }
        public int LogInstanc { get; set; }
        public string VatGroup { get; set; }
        public Nullable<decimal> BaseSum { get; set; }
        public Nullable<decimal> VatRate { get; set; }
        public string Indicator { get; set; }
        public string AdjTran { get; set; }
        public string RevSource { get; set; }
        public string ObjType { get; set; }
        public Nullable<System.DateTime> VatDate { get; set; }
        public string PaymentRef { get; set; }
        public Nullable<decimal> SYSBaseSum { get; set; }
        public Nullable<int> MultMatch { get; set; }
        public string VatLine { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<decimal> SYSVatSum { get; set; }
        public string Closed { get; set; }
        public Nullable<decimal> GrossValue { get; set; }
        public Nullable<int> CheckAbs { get; set; }
        public Nullable<int> LineType { get; set; }
        public string DebCred { get; set; }
        public Nullable<int> SequenceNr { get; set; }
        public string StornoAcc { get; set; }
        public Nullable<decimal> BalDueDeb { get; set; }
        public Nullable<decimal> BalDueCred { get; set; }
        public Nullable<decimal> BalFcDeb { get; set; }
        public Nullable<decimal> BalFcCred { get; set; }
        public Nullable<decimal> BalScDeb { get; set; }
        public Nullable<decimal> BalScCred { get; set; }
        public string IsNet { get; set; }
        public string DunWizBlck { get; set; }
        public Nullable<int> DunnLevel { get; set; }
        public Nullable<System.DateTime> DunDate { get; set; }
        public Nullable<short> TaxType { get; set; }
        public string TaxPostAcc { get; set; }
        public string StaCode { get; set; }
        public Nullable<int> StaType { get; set; }
        public string TaxCode { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<decimal> GrossValFc { get; set; }
        public Nullable<System.DateTime> LvlUpdDate { get; set; }
        public string OcrCode2 { get; set; }
        public string OcrCode3 { get; set; }
        public string OcrCode4 { get; set; }
        public string OcrCode5 { get; set; }
        public Nullable<int> MIEntry { get; set; }
        public Nullable<int> MIVEntry { get; set; }
        public Nullable<int> ClsInTP { get; set; }
        public Nullable<int> CenVatCom { get; set; }
        public Nullable<int> MatType { get; set; }
        public Nullable<int> PstngType { get; set; }
        public Nullable<System.DateTime> ValidFrom2 { get; set; }
        public Nullable<System.DateTime> ValidFrom3 { get; set; }
        public Nullable<System.DateTime> ValidFrom4 { get; set; }
        public Nullable<System.DateTime> ValidFrom5 { get; set; }
        public Nullable<int> Location { get; set; }
        public string WTaxCode { get; set; }
        public Nullable<decimal> EquVatRate { get; set; }
        public Nullable<decimal> EquVatSum { get; set; }
        public Nullable<decimal> SYSEquSum { get; set; }
        public Nullable<decimal> TotalVat { get; set; }
        public Nullable<decimal> SYSTVat { get; set; }
        public string WTLiable { get; set; }
        public string WTLine { get; set; }
        public Nullable<decimal> WTApplied { get; set; }
        public Nullable<decimal> WTAppliedS { get; set; }
        public Nullable<decimal> WTAppliedF { get; set; }
        public Nullable<decimal> WTSum { get; set; }
        public Nullable<decimal> WTSumFC { get; set; }
        public Nullable<decimal> WTSumSC { get; set; }
        public string PayBlock { get; set; }
        public Nullable<int> PayBlckRef { get; set; }
        public string LicTradNum { get; set; }
        public Nullable<int> InterimTyp { get; set; }
        public Nullable<int> DprId { get; set; }
        public string MatchRef { get; set; }
        public string Ordered { get; set; }
        public Nullable<int> CUP { get; set; }
        public Nullable<int> CIG { get; set; }
        public Nullable<int> BPLId { get; set; }
        public string BPLName { get; set; }
        public string VatRegNum { get; set; }
        public string SLEDGERF { get; set; }
    }
}
