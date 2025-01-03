using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Atro
{
    public int AbsEntry { get; set; }

    public int NextNum { get; set; }

    public DateTime? PostDate { get; set; }

    public string? EdocGenTyp { get; set; }

    public int? EdocExpFrm { get; set; }

    public string? TranspNum { get; set; }

    public DateTime? Expiration { get; set; }

    public string? Vehicle { get; set; }

    public string? TrailerId { get; set; }

    public string? Carrier { get; set; }

    public int IssueGate { get; set; }

    public int? AtcEntry { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UpdateTs { get; set; }

    public string? Canceled { get; set; }

    public decimal? Weight { get; set; }

    public short? WghtUnit { get; set; }

    public decimal? TotalLc { get; set; }

    public string WhsCode { get; set; } = null!;

    public string? Cotcode { get; set; }
}
