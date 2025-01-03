using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEntradaInsumo
{
    public int EntradaInsumosId { get; set; }

    public int Oc { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }
}
