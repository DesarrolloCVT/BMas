using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEstadisticaGasto
{
    public int Id { get; set; }

    public int? Año { get; set; }

    public string? CodCuenta { get; set; }

    public string? Cuenta { get; set; }

    public string? Area { get; set; }

    public string? Ccosto { get; set; }

    public string? Item { get; set; }

    public string? CentroCosto { get; set; }

    public string? GastoItem { get; set; }

    public string? Clasificacion { get; set; }

    public int? Mes { get; set; }

    public decimal? Valor { get; set; }
}
