using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwDiasVidaUtil
{
    public string CodProducto { get; set; } = null!;

    public int Dias { get; set; }

    public int PorcAceptacion { get; set; }

    public decimal? DiasAcep { get; set; }
}
