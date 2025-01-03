using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRondaRegistro
{
    public int RegistroRondaId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public string UrlUbicacion { get; set; } = null!;

    public int Punto { get; set; }
}
