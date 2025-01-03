using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mdr1
{
    public string OcrCode { get; set; } = null!;

    public string PrcCode { get; set; } = null!;

    public decimal? PrcAmount { get; set; }

    public decimal? OcrTotal { get; set; }

    public string? Direct { get; set; }

    public short? UserSign { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
