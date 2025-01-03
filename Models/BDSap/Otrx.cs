using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otrx
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? Type { get; set; }

    public byte[]? Data { get; set; }
}
