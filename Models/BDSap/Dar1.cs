using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dar1
{
    public int ArcEntry { get; set; }

    public int LineId { get; set; }

    public string? DocType { get; set; }

    public int? DocNum { get; set; }

    public int? DocAbs { get; set; }

    public decimal? Total { get; set; }

    public DateTime? RefDate { get; set; }

    public int? ClusterId { get; set; }

    public string? Remarks { get; set; }

    public string? KeySeg1 { get; set; }

    public string? KeySeg2 { get; set; }

    public string? KeySeg3 { get; set; }

    public string? KeySeg4 { get; set; }

    public string? KeySeg5 { get; set; }

    public string? KeySeg6 { get; set; }

    public string? KeySeg7 { get; set; }

    public string? KeySeg8 { get; set; }

    public string? KeySeg9 { get; set; }

    public string? KeySeg10 { get; set; }

    public int? Series { get; set; }

    public string? DocSubType { get; set; }

    public string? Pindicator { get; set; }

    public short? Instance { get; set; }

    public short? Segment { get; set; }

    public string? CardCode { get; set; }
}
