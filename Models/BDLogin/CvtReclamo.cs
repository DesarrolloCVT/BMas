using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReclamo
{
    public int IdReclamo { get; set; }

    public DateTime? FechaRegReclamo { get; set; }

    public int? EncargadoReclamo { get; set; }

    public int? EnviaReclamo { get; set; }

    public string? Producto { get; set; }

    public DateTime? FechaEnvasado { get; set; }

    public string? Lote { get; set; }

    public string? Comentarios { get; set; }

    public int? EstadoReclamo { get; set; }

    public string? ObservacionEstado { get; set; }

    public int? MotivoReclamo { get; set; }

    public DateTime? FechaTermino { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int? IdUserRegReclamo { get; set; }
}
