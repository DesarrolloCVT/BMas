using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Boe1
{
    public int BoeKey { get; set; }

    public int LineId { get; set; }

    public string? LineDitail { get; set; }

    public decimal? LineMoney { get; set; }

    public string? LineCurr { get; set; }

    public string? LineAcct { get; set; }

    public string? LineAC { get; set; }

    public string? Code { get; set; }

    public string? CredAcct { get; set; }

    public decimal? TotalLine { get; set; }

    public decimal? VatPercent { get; set; }

    public int? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
