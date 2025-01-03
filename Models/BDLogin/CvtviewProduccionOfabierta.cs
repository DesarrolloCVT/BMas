using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtviewProduccionOfabierta
{
    public int NumOf { get; set; }

    public string? CodProducto { get; set; }

    public string? DescProducto { get; set; }

    public string? CreaciónOf { get; set; }

    public string? CantPlanificada { get; set; }

    public int DocNum { get; set; }

    public string? FechaReciboPt { get; set; }

    public string? CantidadRecibo { get; set; }

    public decimal? KilosRecibidos { get; set; }

    public string? BatchNum { get; set; }

    public int RecepciónWms { get; set; }

    public string? Pallet { get; set; }

    public string? CantPallet { get; set; }

    public string EstadoPallet { get; set; } = null!;

    public string? Ubicación { get; set; }
}
