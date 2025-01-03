using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adpa
{
    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? DirectDpr { get; set; }

    public string? RetMeth { get; set; }

    public string? AreaType { get; set; }

    public string? DrvdArea { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? MainArea { get; set; }

    public string? CreditCtrl { get; set; }

    public int? TaxType { get; set; }

    public string? DirRevPost { get; set; }

    public int? SnapshotId { get; set; }

    public string? BpTaxCorr { get; set; }

    public string? ItmTaxCorr { get; set; }

    public int? UsgTaxCorr { get; set; }
}
