using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SaldosXcompañium
{
    public string Articulo { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public decimal Saldo { get; set; }

    public decimal Price { get; set; }

    public string Origin { get; set; } = null!;

    public string? Currency { get; set; }

    public int Bplid { get; set; }
}
