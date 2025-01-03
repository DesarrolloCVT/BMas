using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrw
{
    public int AbsEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public short Year { get; set; }

    public string? SentMeth { get; set; }

    public decimal? SentValue { get; set; }

    public string? LastAmeth { get; set; }

    public decimal? LastAvalue { get; set; }

    public string? ReportId { get; set; }
}
