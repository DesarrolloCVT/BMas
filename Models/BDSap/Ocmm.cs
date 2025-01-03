using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocmm
{
    public int AbsEntry { get; set; }

    public string CommCode { get; set; } = null!;

    public string? CommDesc { get; set; }
}
