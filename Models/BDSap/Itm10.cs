using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Itm10
{
    public string ItemCode { get; set; } = null!;

    public int? IscommCode { get; set; }

    public int? IssubMasUn { get; set; }

    public decimal? Isfactor { get; set; }

    public int? IsorCstimp { get; set; }

    public int? IsorCstexp { get; set; }

    public int? IsnaTraImp { get; set; }

    public int? IsnaTraExp { get; set; }

    public int? IsstProImp { get; set; }

    public int? IsstProExp { get; set; }

    public string? IsoriCntry { get; set; }

    public int? IsserCode { get; set; }

    public string? IsitemType { get; set; }

    public string? IsserSupMt { get; set; }

    public string? IsserPayMt { get; set; }

    public string? IsorCryimp { get; set; }

    public string? IsorCryexp { get; set; }

    public string? IsuseWeigh { get; set; }

    public string? Isrelevant { get; set; }

    public string? IsstatCode { get; set; }
}
