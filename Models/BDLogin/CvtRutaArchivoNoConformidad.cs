using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRutaArchivoNoConformidad
{
    public int IdRutaArchivoNoConformidad { get; set; }

    public int IdNoConformidad { get; set; }

    public string Ruta { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Extencion { get; set; }

    public string? Observacion { get; set; }
}
