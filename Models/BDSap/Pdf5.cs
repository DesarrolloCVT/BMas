using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pdf5
{
    public int DocNum { get; set; }

    public int InvEntry { get; set; }

    public int LineNum { get; set; }

    public string ObjType { get; set; } = null!;

    public int LogInstanc { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? NoDedSum { get; set; }

    public decimal? BaseSumFc { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? NoDedSumFc { get; set; }

    public decimal? BaseSumSc { get; set; }

    public decimal? NoDedSumSc { get; set; }

    public decimal? VatSumSc { get; set; }

    public string? CashDiscAc { get; set; }

    public short? BaseObjArr { get; set; }

    public int? BaseObj { get; set; }

    public short? InstlmntId { get; set; }

    public int? GroupNum { get; set; }

    public int? LineSeq { get; set; }

    public decimal? EquVatPer { get; set; }

    public decimal? EquVatSum { get; set; }

    public decimal? EquVatSumF { get; set; }

    public decimal? EquVatSumS { get; set; }
}
