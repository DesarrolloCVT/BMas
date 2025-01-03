using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oedt
{
    public int AbsEntry { get; set; }

    public string TypeCode { get; set; } = null!;

    public string? TypeName { get; set; }
}
