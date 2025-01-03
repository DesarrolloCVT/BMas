using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ortl
{
    public int LogEntry { get; set; }

    public string? ResCode { get; set; }

    public int? DocType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLine { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public int? ActionType { get; set; }

    public short? LocType { get; set; }

    public string? LocCode { get; set; }

    public string? VersionNum { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public decimal? DocQty { get; set; }

    public decimal? Price { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? OpenQty { get; set; }

    public string? DocNum { get; set; }

    public string? BaseDocNum { get; set; }

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }
}
