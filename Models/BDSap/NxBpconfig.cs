using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class NxBpconfig
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? UNxAcctCode { get; set; }

    public string? UNxDim1 { get; set; }

    public string? UNxDim2 { get; set; }

    public string? UNxDim3 { get; set; }

    public string? UNxDim4 { get; set; }

    public string? UNxDim5 { get; set; }

    public string? UNxProy { get; set; }

    public string UNxDefault { get; set; } = null!;
}
