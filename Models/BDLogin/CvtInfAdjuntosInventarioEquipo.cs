using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfAdjuntosInventarioEquipo
{
    public int IdAdjunto { get; set; }

    public string? CodInventario { get; set; }

    public string? RutaArchivo { get; set; }

    public string? NombreArchivo { get; set; }

    public string? ExtencionArchivo { get; set; }

    public string? TipoArchivo { get; set; }
}
