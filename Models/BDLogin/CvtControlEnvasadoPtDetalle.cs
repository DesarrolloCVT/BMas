using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtDetalle
{
    public int IdDetalleControlEnvPt { get; set; }

    public int? IdControlEnvPt { get; set; }

    public string? Tipo { get; set; }

    public string? Proveedor { get; set; }

    public string? Lote { get; set; }

    public decimal? Cantidad { get; set; }

    public int? TipoRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuario { get; set; }

    public int? Nbobina { get; set; }

    public int? MotivoMerma { get; set; }

    public string? OrigenMerma { get; set; }
}
