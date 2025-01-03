using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rCalprom
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UItemCode { get; set; }

    public decimal? UQuantity { get; set; }

    public decimal? UPrice { get; set; }

    public short? UUserid { get; set; }

    public string? UTransNumber { get; set; }

    public int? ULineNumber { get; set; }
}
