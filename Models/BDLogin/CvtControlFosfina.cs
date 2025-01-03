using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlFosfina
{
    public int IdControlFosfina { get; set; }

    public DateTime FechaReg { get; set; }

    public string Hora { get; set; } = null!;

    public DateTime? FechaFumigacion { get; set; }

    public string? Bodega { get; set; }

    public decimal? MayorPpm { get; set; }

    public string? A1A2 { get; set; }

    public string? DistanciaFumigacion { get; set; }
}
