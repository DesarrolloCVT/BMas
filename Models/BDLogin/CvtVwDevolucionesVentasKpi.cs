using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDevolucionesVentasKpi
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string? GrupoArticulo { get; set; }

    public decimal? Ventas { get; set; }

    public decimal? Devolucion { get; set; }

    public decimal? Porc { get; set; }
}
