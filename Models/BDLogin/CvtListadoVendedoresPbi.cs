using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtListadoVendedoresPbi
{
    public int SlpCode { get; set; }

    public string SlpName { get; set; } = null!;

    public string? Ncorto { get; set; }

    public string? Responsable { get; set; }
}
