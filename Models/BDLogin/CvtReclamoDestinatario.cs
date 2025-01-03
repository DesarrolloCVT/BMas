using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReclamoDestinatario
{
    public int IdDestinaReclamo { get; set; }

    public int? IdReclamo { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public int? Region { get; set; }

    public string? Ciudad { get; set; }

    public string? Comuna { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? MedioEnvio { get; set; }

    public string? Seguimiento { get; set; }

    public string? Comentarios { get; set; }
}
