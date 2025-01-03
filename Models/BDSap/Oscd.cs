using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oscd
{
    public int AbsEntry { get; set; }

    public int County { get; set; }

    public string ServiceCd { get; set; } = null!;

    public string? Descrip { get; set; }

    public string? Incomimg { get; set; }
}
