using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ari1
{
    public string UserCode { get; set; } = null!;

    public int AddOnId { get; set; }

    public string? AddOnType { get; set; }

    public string? EnableFlag { get; set; }
}
