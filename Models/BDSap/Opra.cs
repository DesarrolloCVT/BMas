using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opra
{
    public int AbsEntry { get; set; }

    public string CateType { get; set; } = null!;

    public string CateCode { get; set; } = null!;

    public string? Category { get; set; }

    public string? Account { get; set; }
}
