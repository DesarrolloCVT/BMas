using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfBajadaEquipo
{
    public string CodActivo { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Marca { get; set; }

    public string? Nserie { get; set; }

    public string? ResponsableTi { get; set; }

    public string? MotivoBaja { get; set; }

    public string? Dpto { get; set; }

    public DateTime? FechaBajada { get; set; }

    public string? Observaciones { get; set; }

    public string? Modelo { get; set; }

    public string? Usuario { get; set; }

    public string? Licencia { get; set; }
}
