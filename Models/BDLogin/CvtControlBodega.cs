using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlBodega
{
    public int ControlId { get; set; }

    public short TipoControl { get; set; }

    public int PackageId { get; set; }

    public int? LayoutId { get; set; }

    public int StaffId { get; set; }

    public DateTime Fecha { get; set; }

    public int? PackageIdDestino { get; set; }

    public string? LoteOrigen { get; set; }

    public string? LoteDestino { get; set; }

    public bool? Justificado { get; set; }

    public int? StaffIdJustificacion { get; set; }

    public string? Justificacion { get; set; }

    public DateTime? FechaJustificacion { get; set; }
}
