using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAgendamientoAcesso
{
    public int AgendamientoAccesoId { get; set; }

    public string TipoAgendamiento { get; set; } = null!;

    public int? NdocumentoOrigen { get; set; }

    public string? TipoDocumentoOrigen { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public int? Norden { get; set; }

    public DateTime Fecha { get; set; }

    public string? Proveedor { get; set; }

    public string? Asunto { get; set; }

    public string? Notas { get; set; }

    public bool Estado { get; set; }
}
