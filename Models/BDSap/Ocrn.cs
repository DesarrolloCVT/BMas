using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrn
{
    public string CurrCode { get; set; } = null!;

    public string? CurrName { get; set; }

    public string? ChkName { get; set; }

    public string? Chk100Name { get; set; }

    public string? DocCurrCod { get; set; }

    public string? FrgnName { get; set; }

    public string? F100name { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? RoundSys { get; set; }

    public short? UserSign2 { get; set; }

    public short? Decimals { get; set; }

    public string? Isrcalc { get; set; }

    public string? RoundPym { get; set; }

    public string? ConvUnit { get; set; }

    public string? BaseCurr { get; set; }

    public decimal? Factor { get; set; }

    public string? ChkNamePl { get; set; }

    public string? Chk100Npl { get; set; }

    public string? FrgnNamePl { get; set; }

    public string? F100namePl { get; set; }

    public string? IsocurrCod { get; set; }

    public decimal? MaxInDiff { get; set; }

    public decimal? MaxOutDiff { get; set; }

    public decimal? MaxInPcnt { get; set; }

    public decimal? MaxOutPcnt { get; set; }

    public string? IsocurrNum { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
