using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Actg
{
    public short GroupNum { get; set; }

    public string PymntGroup { get; set; } = null!;

    public string? PayDuMonth { get; set; }

    public short? ExtraMonth { get; set; }

    public short? ExtraDays { get; set; }

    public short? PaymntsNum { get; set; }

    public decimal? CredLimit { get; set; }

    public decimal? VolumDscnt { get; set; }

    public decimal? LatePyChrg { get; set; }

    public decimal? ObligLimit { get; set; }

    public short? ListNum { get; set; }

    public string? Payments { get; set; }

    public short? NumOfPmnts { get; set; }

    public decimal? Payment1 { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? OpenRcpt { get; set; }

    public string? DiscCode { get; set; }

    public string? DunningCod { get; set; }

    public string? BslineDate { get; set; }

    public short? InstNum { get; set; }

    public short? TolDays { get; set; }

    public string? Vatfirst { get; set; }

    public string? CrdMthd { get; set; }

    public string? CshRelev { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int LogInstanc { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
