using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awtd
{
    public int? AbsEntry { get; set; }

    public string Wtcode { get; set; } = null!;

    public string? Wtname { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? EffecDate { get; set; }

    public string? Inactive { get; set; }

    public string? OffclCode { get; set; }

    public string? Category { get; set; }

    public string? BaseType { get; set; }

    public int? WttypeId { get; set; }

    public decimal? BaseMin { get; set; }

    public decimal? PrctBsAmnt { get; set; }

    public int? FmlId { get; set; }

    public string? Account { get; set; }

    public string? SlScProgr { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? CalcWhtcrM { get; set; }
}
