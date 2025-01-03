using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Qwz2
{
    public string Code { get; set; } = null!;

    public int Numerator { get; set; }

    public string? FileCode { get; set; }

    public string? FieldAlias { get; set; }

    public string? Title { get; set; }

    public int? SortOrder { get; set; }

    public string? SortType { get; set; }

    public string? GroupBy { get; set; }

    public int? AgregType { get; set; }

    public string? CalcField { get; set; }

    public string? IsCalc { get; set; }

    public string? TmpAlias { get; set; }

    public string? TmpDescr { get; set; }

    public string? Fld2Alias { get; set; }

    public string? FileCode2 { get; set; }

    public int? Agreg2Type { get; set; }

    public int? FldOp { get; set; }

    public string? FldCnstVal { get; set; }

    public string? Fld2CnsVal { get; set; }
}
