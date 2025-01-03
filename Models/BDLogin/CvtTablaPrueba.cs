using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTablaPrueba
{
    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public decimal Run { get; set; }

    public string? Direccion { get; set; }

    public decimal? Telefono { get; set; }
}
