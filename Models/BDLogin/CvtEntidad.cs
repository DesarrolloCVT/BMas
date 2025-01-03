using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEntidad
{
    public int EntidadId { get; set; }

    public string EntidadNombre { get; set; } = null!;

    public int? Estado { get; set; }
}
