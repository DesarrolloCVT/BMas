using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aocr
{
    public string OcrCode { get; set; } = null!;

    public string? OcrName { get; set; }

    public decimal? OcrTotal { get; set; }

    public string? Direct { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? DimCode { get; set; }

    public int? AbsEntry { get; set; }

    public string? Active { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? IsFixedAmt { get; set; }
}
