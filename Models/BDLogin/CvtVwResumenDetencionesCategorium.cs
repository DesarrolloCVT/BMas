using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenDetencionesCategorium
{
    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? Minutos { get; set; }

    public string CategoriaNombre { get; set; } = null!;

    public string Tipo { get; set; } = null!;
}
