using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Augr
{
    public short GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? GroupDec { get; set; }

    public string? Allowences { get; set; }

    public short? Tplid { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? GroupType { get; set; }

    public short? CockpitId { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? VersionNum { get; set; }
}
