using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class CvtRechazounilever
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UDescripcion { get; set; }

    public string? UResponsable { get; set; }
}
