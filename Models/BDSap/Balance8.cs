using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Balance8
{
    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public short? Tipo { get; set; }

    public string? Cuenta { get; set; }

    public string? Nombre { get; set; }

    public decimal? Debitos { get; set; }

    public decimal? Creditos { get; set; }

    public decimal? Deudor { get; set; }

    public decimal? Acreedor { get; set; }

    public string Libro { get; set; } = null!;

    public int? Bplid { get; set; }
}
