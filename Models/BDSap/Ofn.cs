using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofn
{
    public int Series { get; set; }

    public string Name { get; set; } = null!;

    public string? Pticode { get; set; }

    public int? FirstNum { get; set; }

    public int? NextNum { get; set; }

    public int? LastNum { get; set; }

    public string? Letter { get; set; }

    public string? Cai { get; set; }

    public DateTime? CaidueDate { get; set; }

    public string? Remarks { get; set; }

    public string? Locked { get; set; }
}
