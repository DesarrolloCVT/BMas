using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oprc
{
    public string PrcCode { get; set; } = null!;

    public string? PrcName { get; set; }

    public string? GrpCode { get; set; }

    public decimal? Balance { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? DimCode { get; set; }

    public string? CctypeCode { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Active { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Ccowner { get; set; }

    public string? UCodCcpadre { get; set; }
}
