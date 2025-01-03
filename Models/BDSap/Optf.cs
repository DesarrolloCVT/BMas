using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Optf
{
    public int AbsEntry { get; set; }

    public string PtfId { get; set; } = null!;

    public string? PtfCode { get; set; }

    public string? PtfNum { get; set; }

    public string? PtfDespt { get; set; }
}
