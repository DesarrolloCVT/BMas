using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPermisoTrabajoSeguroPt
{
    public int IdArchivo { get; set; }

    public int? IdPts { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Extencion { get; set; }

    public string? Ruta { get; set; }
}
