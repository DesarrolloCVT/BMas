using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovet
{
    public short TypeId { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? Locked { get; set; }
}
