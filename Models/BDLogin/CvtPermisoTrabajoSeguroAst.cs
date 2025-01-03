using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPermisoTrabajoSeguroAst
{
    public int IdAst { get; set; }

    public int? IdPts { get; set; }

    public string? UrlAst { get; set; }

    public string? NombreArchivo { get; set; }

    public DateTime? FechaCarga { get; set; }

    public int? Astorder { get; set; }
}
