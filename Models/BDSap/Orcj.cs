using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcj
{
    public int Id { get; set; }

    public string? ResCode { get; set; }

    public string? WhsCode { get; set; }

    public DateTime? CapDate { get; set; }

    public string? CapType { get; set; }

    public decimal? Capacity { get; set; }

    public int? SrcObjType { get; set; }

    public int? SrcAbsEnt { get; set; }

    public int? SrcLine { get; set; }

    public int? BaseObjTyp { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseLine { get; set; }

    public short? ActionType { get; set; }

    public int? OwnObjTyp { get; set; }

    public int? OwnAbsEnt { get; set; }

    public int? OwnLine { get; set; }

    public int? RevdObjTyp { get; set; }

    public int? RevdAbsEnt { get; set; }

    public int? RevdLine { get; set; }

    public string? MemoSrc { get; set; }

    public string? Memo { get; set; }

    public decimal? SngRunCap { get; set; }

    public string? MemoSrcSng { get; set; }

    public string? MemoSng { get; set; }
}
