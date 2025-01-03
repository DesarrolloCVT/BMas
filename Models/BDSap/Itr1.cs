using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Itr1
{
    public int ReconNum { get; set; }

    public int LineSeq { get; set; }

    public string? ShortName { get; set; }

    public int? TransId { get; set; }

    public int? TransRowId { get; set; }

    public string? SrcObjTyp { get; set; }

    public int? SrcObjAbs { get; set; }

    public decimal? ReconSum { get; set; }

    public decimal? ReconSumFc { get; set; }

    public decimal? ReconSumSc { get; set; }

    public string? FrgnCurr { get; set; }

    public decimal? SumMthCurr { get; set; }

    public string? IsCredit { get; set; }

    public string? Account { get; set; }

    public decimal? CashDisSum { get; set; }

    public decimal? Wtsum { get; set; }

    public decimal? WtsumFc { get; set; }

    public decimal? WtsumSc { get; set; }

    public decimal? ExpSum { get; set; }

    public decimal? ExpSumFc { get; set; }

    public decimal? ExpSumSc { get; set; }

    public decimal? NetBefDisc { get; set; }

    public int? Mientry { get; set; }

    public string? Mitype { get; set; }

    public int? InstId { get; set; }
}
