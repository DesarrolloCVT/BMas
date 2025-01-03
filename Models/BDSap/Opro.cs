using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opro
{
    public int AbsEntry { get; set; }

    public int MapId { get; set; }

    public int Code { get; set; }

    public string? Type { get; set; }

    public string Name { get; set; } = null!;

    public string? IsBlob { get; set; }

    public string? Tvalue { get; set; }

    public byte[]? Bvalue { get; set; }

    public string? Encoding { get; set; }
}
