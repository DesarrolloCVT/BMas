using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1WtaxView
{
    public string? WtaxAbsId { get; set; }

    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public DateTime? DocDate { get; set; }

    public int Factor { get; set; }

    public string? CardCode { get; set; }

    public string? FullCopied { get; set; }

    public string? BaseObjTyp { get; set; }

    public string? BaseType { get; set; }

    public decimal? BaseNetSum { get; set; }

    public decimal? BaseNetSc { get; set; }

    public decimal? BaseNetFc { get; set; }

    public decimal? BaseVatSum { get; set; }

    public decimal? BaseVatSc { get; set; }

    public decimal? BaseVatFc { get; set; }

    public decimal? BaseGrossSumLc { get; set; }

    public decimal? BaseGrossSumSc { get; set; }

    public decimal? BaseGrossSumFc { get; set; }

    public decimal? BaseGrossVatsumLc { get; set; }

    public decimal? BaseGrossVatsumSc { get; set; }

    public decimal? BaseGrossVatsumFc { get; set; }

    public decimal? TxblSum { get; set; }

    public decimal? TxblSumSc { get; set; }

    public decimal? TxblSumFc { get; set; }

    public decimal? WtaxSum { get; set; }

    public decimal? WtaxSumSc { get; set; }

    public decimal? WtaxSumFc { get; set; }

    public int AbsEntry { get; set; }

    public int LineSeq { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? SysRate { get; set; }
}
