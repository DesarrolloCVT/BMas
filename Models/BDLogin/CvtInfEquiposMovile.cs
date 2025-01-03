using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEquiposMovile
{
    public int IdEquiposMoviles { get; set; }

    public string? Imei { get; set; }

    public int? IdMarca { get; set; }

    public string? Modelo { get; set; }

    public string? CodAf { get; set; }

    public string? Ram { get; set; }

    public string? Procesador { get; set; }

    public string? So { get; set; }

    public int? Estado { get; set; }
}
