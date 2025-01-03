using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Znul1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UTipo { get; set; }

    public int? UDocum { get; set; }

    public int? UNumero { get; set; }

    public DateTime? UFecha { get; set; }

    public string? URut { get; set; }

    public string? UDescrip { get; set; }

    public string? UFolio { get; set; }

    public string? UIndic { get; set; }

    public string UOrigDoc { get; set; } = null!;

    public int UBplid { get; set; }
}
