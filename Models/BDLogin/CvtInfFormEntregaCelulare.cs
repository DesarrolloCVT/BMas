using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfFormEntregaCelulare
{
    public int IdFormEntregaCelulares { get; set; }

    public string? IdUsuarioAsignado { get; set; }

    public string? TipoDispo { get; set; }

    public int? Nlinea { get; set; }

    public int? Equipo { get; set; }

    public bool? CajaOriginal { get; set; }

    public bool? TarjetaSim { get; set; }

    public bool? CargadorBateria { get; set; }

    public bool? TarjetaMicroSd { get; set; }

    public bool? Auriculares { get; set; }

    public bool? Carcasa { get; set; }

    public bool? CableDatosUsb { get; set; }

    public bool? LaminaVidrio { get; set; }

    public string? Otro { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaHasta { get; set; }

    public bool? Vb { get; set; }

    public string? IdUsuarioRecibe { get; set; }

    public string? Codigo { get; set; }
}
