using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCompromisoKit
{
    public int CkitId { get; set; }

    public string ClienteNombre { get; set; } = null!;

    public int CantidadProducir { get; set; }

    public short Estado { get; set; }
}
