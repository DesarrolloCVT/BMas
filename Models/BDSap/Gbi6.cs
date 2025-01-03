using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi6
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? AcctCode { get; set; }

    public string? Currency { get; set; }

    public string? EvalGrp { get; set; }

    public decimal? PerBbal { get; set; }

    public decimal? PerBqty { get; set; }

    public decimal? PerBfcbal { get; set; }

    public decimal? Cpdamt { get; set; }

    public decimal? Cpdqty { get; set; }

    public decimal? Cpdfcamt { get; set; }

    public decimal? Cpcamt { get; set; }

    public decimal? Cpcqty { get; set; }

    public decimal? Cpcfcamt { get; set; }

    public decimal? PerEbal { get; set; }

    public decimal? PerEqty { get; set; }

    public decimal? PerEfcbal { get; set; }

    public string? AcctPeriod { get; set; }
}
