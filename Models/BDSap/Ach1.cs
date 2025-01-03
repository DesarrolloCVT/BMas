using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ach1
{
    public int CheckKey { get; set; }

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

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public decimal? LineMnyLc { get; set; }

    public decimal? LineMnySc { get; set; }

    public decimal? LineMnyFc { get; set; }

    public decimal? TotLineLc { get; set; }

    public decimal? TotLineSc { get; set; }

    public decimal? TotLineFc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
