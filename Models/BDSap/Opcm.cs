using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opcm
{
    public int AbsEntry { get; set; }

    public string IdCode { get; set; } = null!;

    public string PosCode { get; set; } = null!;

    public string? PosDesc { get; set; }

    public string CrCode { get; set; } = null!;

    public string? CrDesc { get; set; }

    public string? Remarks { get; set; }
}
