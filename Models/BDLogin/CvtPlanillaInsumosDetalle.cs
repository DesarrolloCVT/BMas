using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanillaInsumosDetalle
{
    public int PiDetalleId { get; set; }

    public int? PinsumosId { get; set; }

    public string? CodArticulo { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public string? Proveedor { get; set; }

    public string? CodProveedor { get; set; }
}
