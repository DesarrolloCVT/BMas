using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwAuditoriaRecepcion
{
    public int IdAuditoria { get; set; }

    public int ReceptionId { get; set; }

    public int PackageId { get; set; }

    public int LayoutId { get; set; }

    public string? LayoutDescription { get; set; }

    public string PackageSscc { get; set; } = null!;

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? GrueroAsignado1 { get; set; }

    public string? GrueroAsig1 { get; set; }

    public string? GrueroAsignado2 { get; set; }

    public int? Recepcionista { get; set; }

    public string? StaffName { get; set; }

    public DateTime Fecha { get; set; }

    public int Posicionamiento { get; set; }

    public int Rotulado { get; set; }

    public string? Comentario { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaAuditoria { get; set; }
}
