using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Okrt
{
    public int AbsEntry { get; set; }

    public string TaxRepType { get; set; } = null!;

    public string? Descrip { get; set; }

    public int? SumRepType { get; set; }

    public string? NameDesc { get; set; }
}
