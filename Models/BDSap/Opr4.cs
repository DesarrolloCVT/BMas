using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opr4
{
    public int OprId { get; set; }

    public short Line { get; set; }

    public int? IntId { get; set; }

    public string? Prmry { get; set; }

    public string? EncryptIv { get; set; }
}
