using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtOcabiertasEerr
{
    public string Empresa { get; set; } = null!;

    public string? CardName { get; set; }

    public int DocNum { get; set; }

    public string SlpName { get; set; } = null!;
}
