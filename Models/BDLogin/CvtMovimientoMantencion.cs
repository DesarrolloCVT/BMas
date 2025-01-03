using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMovimientoMantencion
{
    public int MovimientoId { get; set; }

    public int TipoMovimiento { get; set; }

    public string? Documento { get; set; }

    public int? NumeroDocumento { get; set; }

    public string Responsable { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Observacion { get; set; }

    public int? AreaId { get; set; }

    public int? ObjetoId { get; set; }

    public string? LugarUtilizacion { get; set; }
}
