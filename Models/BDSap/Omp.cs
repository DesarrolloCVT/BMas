using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omp
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public string? QueryUrl { get; set; }
}
