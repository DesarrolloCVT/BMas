using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReclamoArchivo
{
    public int IdRutaArchivoReclamo { get; set; }

    public int? IdReclamo { get; set; }

    public string? RutaArchivo { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Extencion { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
