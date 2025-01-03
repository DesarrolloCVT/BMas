using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obg
{
    public int AbsId { get; set; }

    public string Name { get; set; } = null!;

    public int? BaseId { get; set; }

    public decimal? InitRate { get; set; }

    public string? Locked { get; set; }

    public DateTime FinancYear { get; set; }

    public string? IsMain { get; set; }

    public string? DataSource { get; set; }

    public short? RoundSys { get; set; }

    public short? UserSign { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? PrjCode { get; set; }
}
