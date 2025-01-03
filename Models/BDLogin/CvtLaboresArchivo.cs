using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLaboresArchivo
{
    public int IdRutaArchivoLabores { get; set; }

    public int IdLaborTurno { get; set; }

    public string? RutaArchivo { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Extension { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
