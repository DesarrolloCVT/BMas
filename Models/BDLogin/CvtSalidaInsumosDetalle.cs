using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSalidaInsumosDetalle
{
    public int SalidaInsumosId { get; set; }

    public int SalidaInsumosDetalleId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Division { get; set; }

    public string? Uadm { get; set; }

    public string Ccosto { get; set; } = null!;

    public string? Item { get; set; }

    public decimal Cantidad { get; set; }
}
