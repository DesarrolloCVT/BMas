using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obnk
{
    public int? IdNumber { get; set; }

    public string AcctCode { get; set; } = null!;

    public int Sequence { get; set; }

    public string? AcctName { get; set; }

    public string? Ref { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Memo { get; set; }

    public decimal? DebAmount { get; set; }

    public string? DebAmntCur { get; set; }

    public decimal? CredAmnt { get; set; }

    public string? CredAmntCu { get; set; }

    public decimal? Balance { get; set; }

    public int? BankMatch { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? ExternCode { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public int? StatemNo { get; set; }

    public string? DocNum { get; set; }

    public string? PaymCreat { get; set; }

    public string? LineStatus { get; set; }

    public int? VisOrder { get; set; }

    public string? DocNumType { get; set; }

    public string? Memo2 { get; set; }

    public string? PaymentRef { get; set; }

    public string? AutoCreate { get; set; }

    public DateTime? BslineDate { get; set; }

    public DateTime? BsvaluDate { get; set; }

    public int? InOpCode { get; set; }

    public string? Cleared { get; set; }

    public string? OposAct { get; set; }

    public decimal? DebAmntLc { get; set; }

    public decimal? CredAmntLc { get; set; }

    public decimal? ExchngRate { get; set; }

    public string? Bpiban { get; set; }

    public decimal? Fee { get; set; }

    public DateTime? PmnPstDate { get; set; }

    public DateTime? PmnValDate { get; set; }

    public DateTime? LnDocDate { get; set; }

    public decimal? VatAmntLc { get; set; }

    public decimal? VatAmntFc { get; set; }

    public int? Jdtid { get; set; }

    public int? PmntId { get; set; }

    public short? ObjCrtType { get; set; }

    public string? PstMethod { get; set; }

    public string? FeeAct { get; set; }

    public string? FeeProfitC { get; set; }

    public string? FeeProj { get; set; }

    public string? BpBankCode { get; set; }

    public string? FeeProfit2 { get; set; }

    public string? FeeProfit3 { get; set; }

    public string? FeeProfit4 { get; set; }

    public string? FeeProfit5 { get; set; }

    public decimal? ApplWtsum { get; set; }

    public string? InfoLog { get; set; }

    public string? LineOrigin { get; set; }

    public string? Bpswift { get; set; }

    public string? Source { get; set; }

    public int? PayOrderNo { get; set; }

    public string? TaxIdnum { get; set; }

    public int? Ponumber { get; set; }

    public string? FormatName { get; set; }

    public string? FileCrc { get; set; }

    public string? FolioPref { get; set; }

    public int? FolioNum { get; set; }

    public int? BplidPmn { get; set; }

    public string? BpacctName { get; set; }

    public string? EnOposAct { get; set; }

    public string? EnBpiban { get; set; }

    public string? EncryptIv { get; set; }

    public string? Dppstatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CtrlAcct { get; set; }
}
