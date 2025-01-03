using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwFormularioEntregaEquipo
{
    public int FolioEntrega { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Rut { get; set; }

    public string? Cargo { get; set; }

    public string? TipoDispo { get; set; }

    public int? Idequipo { get; set; }

    public int? Nlinea { get; set; }

    public string? CodAf { get; set; }

    public string? Equipo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Sim { get; set; }

    public string CajaOriginal { get; set; } = null!;

    public string TarjetaSim { get; set; } = null!;

    public string CargadorBateria { get; set; } = null!;

    public string TarjetaMicroSd { get; set; } = null!;

    public string Auriculares { get; set; } = null!;

    public string Carcasa { get; set; } = null!;

    public string CableDatosUsb { get; set; } = null!;

    public string LaminaVidrio { get; set; } = null!;

    public string? Otro { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaHasta { get; set; }

    public string? NombreUsuarioRecibe { get; set; }

    public string? Rutrecibe { get; set; }

    public string? CargoRecibe { get; set; }

    public string? EstadoRecibo { get; set; }
}
