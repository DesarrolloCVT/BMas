using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otbp
{
    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? CntctPrsn { get; set; }

    public string? Title { get; set; }

    public string? Position { get; set; }

    public string? EMail { get; set; }

    public string? Telephone { get; set; }

    public string? Cellolar { get; set; }

    public string? Fax { get; set; }

    public string? Address { get; set; }

    public string? Street { get; set; }

    public string? Block { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? County { get; set; }

    public string? Building { get; set; }
}
