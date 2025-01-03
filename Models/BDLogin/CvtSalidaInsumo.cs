using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSalidaInsumo
{
    public int SalidaInsumosId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string Bodega { get; set; } = null!;

    public string Responsable { get; set; } = null!;
}
