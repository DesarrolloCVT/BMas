using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oswa
{
    public string PymntRsnCd { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public decimal? FllTxInAdv { get; set; }

    public decimal? AmntsOnhld { get; set; }

    public decimal? RtasWth { get; set; }

    public decimal? RtasAdv { get; set; }

    public decimal? SspndRegTx { get; set; }

    public decimal? MtasWth { get; set; }

    public decimal? MtasAdv { get; set; }

    public decimal? SspndMttx { get; set; }

    public decimal? TxblPrYr { get; set; }

    public decimal? WthprYr { get; set; }

    public decimal? ScrtyCntrP { get; set; }

    public decimal? ScrtyCntrS { get; set; }

    public decimal? ExpsRmbrsd { get; set; }

    public decimal? Wthrmbrsd { get; set; }

    public string? DlvryIdNo { get; set; }

    public string? SnglCrtfNo { get; set; }

    public short? ErnYr { get; set; }

    public string? Advanced { get; set; }

    public string? WthtypCd { get; set; }

    public decimal? GrssAmount { get; set; }

    public decimal? NtSbjctFrg { get; set; }

    public decimal? TxblAmnt { get; set; }

    public decimal? Wthamnt { get; set; }

    public string? SsfiscalCd { get; set; }

    public string? Ssiname { get; set; }

    public string? Ssicode { get; set; }

    public string? CompanyCd { get; set; }

    public string? Category { get; set; }

    public decimal? EmpeSscntr { get; set; }

    public decimal? EmprSscntr { get; set; }

    public string? OthCntrbts { get; set; }

    public decimal? VothCntrbt { get; set; }

    public decimal? OthAmntDue { get; set; }

    public decimal? OthAmntPd { get; set; }

    public decimal? AmntPdBfBr { get; set; }

    public decimal? AmntPdByTr { get; set; }

    public string? FiscalCode { get; set; }

    public decimal? TxblAmntE { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TxAmntInAd { get; set; }

    public decimal? SspndWthtx { get; set; }

    public decimal? AdRgTxIrph { get; set; }

    public decimal? AdRgTxIrpa { get; set; }

    public decimal? SspdRgnlTx { get; set; }

    public decimal? AdCtTxIrwt { get; set; }

    public decimal? AdCtTxIwta { get; set; }

    public decimal? SspndCtTx { get; set; }

    public string? FsCdTrdPty { get; set; }

    public string? FcdTrdPtyS { get; set; }

    public string? FscCdExpr { get; set; }

    public string? FsCdMnDbS { get; set; }

    public decimal? AmntPdS { get; set; }

    public decimal? WhtapdS { get; set; }

    public string? WhtnapdS { get; set; }

    public string? FsCdMnDbR { get; set; }

    public decimal? AmntPdR { get; set; }

    public decimal? WhtapdR { get; set; }

    public string? WhtnapdR { get; set; }

    public decimal? AmntPdA { get; set; }

    public decimal? TxAppldA { get; set; }

    public decimal? AmntPdB { get; set; }

    public decimal? TxAppldB { get; set; }

    public decimal? AmntPdC { get; set; }

    public decimal? TxAppldC { get; set; }

    public decimal? AmntPdD { get; set; }

    public decimal? TxAppldD { get; set; }

    public decimal? AmtPvdNtxS { get; set; }

    public decimal? AmtPvdNtxR { get; set; }

    public string Cusplit { get; set; } = null!;

    public decimal? SmRnNtWtx { get; set; }
}
