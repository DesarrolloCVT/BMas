using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTotalDetencionesOf
{
    public int OfId { get; set; }

    public int? TotalDetenciones { get; set; }

    public string Tipo { get; set; } = null!;

    public int TipoId { get; set; }
}
