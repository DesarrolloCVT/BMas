using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlAccesoChofer
{
    public int IdChofer { get; set; }

    public string? Run { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public int? LicConducir { get; set; }

    public string? Observaciones { get; set; }

    public int? Nacionalidad { get; set; }
}
