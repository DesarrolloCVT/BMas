using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDevolucionesKpi
{
    public string Grupo { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public decimal? Kilos { get; set; }

    public int? MesDevolucion { get; set; }

    public int? AñoDevolucion { get; set; }
}
