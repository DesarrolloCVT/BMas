using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtAzucar
{
    public int IdInspeccionPtAzucar { get; set; }

    public string ItemCode { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public int IdUsuario { get; set; }

    public string? AccionCorrectiva { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public int? IdVerificador { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaVerificacion { get; set; }
}
