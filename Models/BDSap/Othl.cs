using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Othl
{
    public int AbsEntry { get; set; }

    public string? RecType { get; set; }

    public DateTime? EffecFrom { get; set; }

    public string? Company { get; set; }

    public string? PrivInv { get; set; }

    public string? PrivJe { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Tourism { get; set; }
}
