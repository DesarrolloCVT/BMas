using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opac
{
    public string Paccode { get; set; } = null!;

    public string? Pacname { get; set; }

    public string? PublicKey { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public int? Edfcode { get; set; }
}
