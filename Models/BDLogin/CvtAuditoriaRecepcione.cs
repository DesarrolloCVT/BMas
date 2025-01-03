using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAuditoriaRecepcione
{
    public int IdAuditoria { get; set; }

    public int ReceptionId { get; set; }

    public int PackageId { get; set; }

    public int LayoutId { get; set; }

    public string PackageSscc { get; set; } = null!;

    public string? GrueroAsignado1 { get; set; }

    public string? GrueroAsignado2 { get; set; }

    public int? Recepcionista { get; set; }

    public DateTime Fecha { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaAuditoria { get; set; }

    public int Posicionamiento { get; set; }

    public int Rotulado { get; set; }

    public string? Comentario { get; set; }
}
