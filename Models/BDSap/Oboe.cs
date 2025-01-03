using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oboe
{
    public int BoeKey { get; set; }

    public int BoeNum { get; set; }

    public string? BoeStatus { get; set; }

    public string BoeType { get; set; } = null!;

    public string? DpsBankCod { get; set; }

    public string? DpsCntrCod { get; set; }

    public DateTime? DueDate { get; set; }

    public string? DpstAcct { get; set; }

    public string? DpstBranch { get; set; }

    public string? Details { get; set; }

    public string? TransRef { get; set; }

    public DateTime? PmntDate { get; set; }

    public int? PmntNum { get; set; }

    public decimal? BoeSum { get; set; }

    public decimal? BoeSumSc { get; set; }

    public decimal? BoeSumFc { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? BoeAcct { get; set; }

    public string? Currency { get; set; }

    public string? Printed { get; set; }

    public string? TotalWords { get; set; }

    public string? Signature { get; set; }

    public int? TransNum { get; set; }

    public decimal? LinesSum { get; set; }

    public decimal? DdctPrcnt { get; set; }

    public string? Address { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? VatTotal { get; set; }

    public decimal? VatTotalSc { get; set; }

    public decimal? VatTotalFc { get; set; }

    public string? VatCalcult { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? DataSource { get; set; }

    public decimal? SumRfndCln { get; set; }

    public short? UserSign { get; set; }

    public short? PrintedBy { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int? LogInstanc { get; set; }

    public string? BpbankCod { get; set; }

    public string? BpbankNam { get; set; }

    public string? BpbankAct { get; set; }

    public string? BpbankBrnc { get; set; }

    public string? BpbankCtr { get; set; }

    public string? RefNum { get; set; }

    public string? IsReconcld { get; set; }

    public string? Comments { get; set; }

    public string? PayMethCod { get; set; }

    public int? DepositNum { get; set; }

    public string? PymMethNam { get; set; }

    public decimal? DeductSum { get; set; }

    public string? ControlKey { get; set; }

    public string? AgentCode { get; set; }

    public int? ReconcilNu { get; set; }

    public string? DepositTyp { get; set; }

    public string? CreatStatu { get; set; }

    public string? Ref2 { get; set; }

    public string? PayEngSt1 { get; set; }

    public string? PayEngSt2 { get; set; }

    public string? PayEngSt3 { get; set; }

    public string? StampTax { get; set; }

    public decimal? StmpTxAmnt { get; set; }

    public int? DpsActKey { get; set; }

    public int? OutBnkKey { get; set; }

    public string? Portfolio { get; set; }

    public string? VndCodeCee { get; set; }

    public string? VndNameCee { get; set; }

    public int? OurNum { get; set; }

    public string? BarcodeNum { get; set; }

    public string? BarcodeRep { get; set; }

    public string? OurNumChk { get; set; }

    public string? FolioPref { get; set; }

    public int? FolioNum { get; set; }

    public int? LpgFolioN { get; set; }

    public short? UserSign2 { get; set; }

    public decimal? IntrstAmnt { get; set; }

    public decimal? DiscAmnt { get; set; }

    public decimal? FineAmnt { get; set; }

    public DateTime? IntrstDate { get; set; }

    public DateTime? DiscDate { get; set; }

    public DateTime? FineDate { get; set; }

    public string? PostType { get; set; }

    public decimal? Iofamnt { get; set; }

    public decimal? ServFeeAm { get; set; }

    public decimal? OtherExAm { get; set; }

    public decimal? OtherInAm { get; set; }

    public int? Bplid { get; set; }

    public string? EnBpbnkAct { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }

    public string? UExcluir { get; set; }

    public DateTime? UNewduedate { get; set; }

    public string? UComment { get; set; }

    public string? UFactoring { get; set; }

    public string? UCodFact { get; set; }
}
