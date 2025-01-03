using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPorcentajePalletVendidosPorGrupo
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? GrupoProducto { get; set; }

    public string? NombreGrupoProducto { get; set; }

    public decimal? Porcentaje { get; set; }

    public decimal? TotalPallets { get; set; }

    public string? CtaCosto { get; set; }
}
