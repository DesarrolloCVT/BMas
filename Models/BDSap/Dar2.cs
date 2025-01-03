using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dar2
{
    public int ArcEntry { get; set; }

    public int LineId { get; set; }

    public string? Approve { get; set; }

    public int? DocType { get; set; }

    public int? DocNum { get; set; }

    public int? DocAbs { get; set; }

    public string? CardCode { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public decimal? Total { get; set; }

    public string? Action { get; set; }

    public string? Remarks { get; set; }

    public string? KeySeg1 { get; set; }

    public string? KeySeg2 { get; set; }

    public string? KeySeg3 { get; set; }

    public string? KeySeg4 { get; set; }

    public string? KeySeg5 { get; set; }

    public string? KeySeg6 { get; set; }

    public int? ClusterId { get; set; }
}
