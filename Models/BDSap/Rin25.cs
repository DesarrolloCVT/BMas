using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rin25
{
    public int DocEntry { get; set; }

    public string VatGroup { get; set; } = null!;

    public decimal? VatPrcnt { get; set; }

    public decimal? BaseAmnt { get; set; }

    public decimal? BaseAmntFc { get; set; }

    public decimal? BaseAmntSc { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFrgn { get; set; }

    public decimal? VatSumSy { get; set; }

    public int Type { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
