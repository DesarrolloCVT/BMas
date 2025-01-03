using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otcx
{
    public int DocEntry { get; set; }

    public int? LineNum { get; set; }

    public int? DocType { get; set; }

    public int? BusArea { get; set; }

    public int? Cond1 { get; set; }

    public string? Udftable1 { get; set; }

    public int? NumVal1 { get; set; }

    public string? StrVal1 { get; set; }

    public decimal? MnyVal1 { get; set; }

    public int? Cond2 { get; set; }

    public string? Udftable2 { get; set; }

    public int? NumVal2 { get; set; }

    public string? StrVal2 { get; set; }

    public decimal? MnyVal2 { get; set; }

    public int? Cond3 { get; set; }

    public string? UdfTable3 { get; set; }

    public int? NumVal3 { get; set; }

    public string? StrVal3 { get; set; }

    public decimal? MnyVal3 { get; set; }

    public int? Cond4 { get; set; }

    public string? UdfTable4 { get; set; }

    public int? NumVal4 { get; set; }

    public string? StrVal4 { get; set; }

    public decimal? MnyVal4 { get; set; }

    public int? Cond5 { get; set; }

    public string? UdfTable5 { get; set; }

    public int? NumVal5 { get; set; }

    public string? StrVal5 { get; set; }

    public decimal? MnyVal5 { get; set; }

    public string? Descr { get; set; }

    public string? LnTaxCode { get; set; }

    public string? FrLnTax { get; set; }

    public string? FrHdrTax { get; set; }

    public string? Udfalias1 { get; set; }

    public string? Udfalias2 { get; set; }

    public string? Udfalias3 { get; set; }

    public string? Udfalias4 { get; set; }

    public string? Udfalias5 { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }
}
