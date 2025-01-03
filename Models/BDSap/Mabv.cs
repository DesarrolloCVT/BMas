using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mabv
{
    public int AbsEntry { get; set; }

    public string PkgName { get; set; } = null!;

    public string? FileName { get; set; }

    public DateTime? ImprtDate { get; set; }

    public string? PkgPath { get; set; }
}
