using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trs2
{
    public int AbsEntry { get; set; }

    public string? ObjType { get; set; }

    public int LineId { get; set; }

    public string ParamCode { get; set; } = null!;

    public decimal? PrmValAmt { get; set; }

    public int? PrmValNum { get; set; }

    public string? PrmValStr { get; set; }

    public string? PrmValTxt { get; set; }
}
