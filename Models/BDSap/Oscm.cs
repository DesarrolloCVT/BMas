using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oscm
{
    public short RuleId { get; set; }

    public short? RuleType { get; set; }

    public short? ParentId { get; set; }

    public string? Status { get; set; }

    public short? Priority { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? ExtCond { get; set; }
}
