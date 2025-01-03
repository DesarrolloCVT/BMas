using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opr5
{
    public int OpportId { get; set; }

    public short Line { get; set; }

    public int? ReasondId { get; set; }

    public string? EncryptIv { get; set; }
}
