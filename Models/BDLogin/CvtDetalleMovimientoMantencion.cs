using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetalleMovimientoMantencion
{
    public int MovimientoId { get; set; }

    public int MovimientoDetalleId { get; set; }

    public int ArticuloId { get; set; }

    public int Cantidad { get; set; }

    public int? Precio { get; set; }

    public string? Observacion { get; set; }
}
