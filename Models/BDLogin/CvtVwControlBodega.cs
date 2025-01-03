using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwControlBodega
{
    public int ControlId { get; set; }

    public string? Tipo { get; set; }

    public short TipoControl { get; set; }

    public DateTime Fecha { get; set; }

    public string? Usuario { get; set; }

    public string? Sscc { get; set; }

    public string? SsccDestino { get; set; }

    public string? LoteOrigen { get; set; }

    public string? LoteDestino { get; set; }

    public string? LayoutShortDescription { get; set; }

    public int? LayoutId { get; set; }

    public bool? Justificado { get; set; }

    public string? UsuarioJustificacion { get; set; }

    public DateTime? FechaJustificacion { get; set; }

    public string? Justificacion { get; set; }
}
