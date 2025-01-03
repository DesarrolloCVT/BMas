using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRepMonitDetecmetale
{
    public DateOnly? Fecha { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public TimeOnly Hora { get; set; }

    public string? Producto { get; set; }

    public string Detector { get; set; } = null!;

    public string Ferrozo { get; set; } = null!;

    public string NoFerrozo { get; set; } = null!;

    public string AceroInoxidable { get; set; } = null!;

    public string BrazoRechazo { get; set; } = null!;

    public int? PorcCumpli { get; set; }
}
