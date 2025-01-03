using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetalleCostosImportacion
{
    public int DetalleCostoImportacionId { get; set; }

    public int Oc { get; set; }

    public string CodigoPrecioEntrega { get; set; } = null!;

    public string Imputacion { get; set; } = null!;

    public decimal Valor { get; set; }

    public string? Proveedor { get; set; }

    public string? Obs { get; set; }
}
