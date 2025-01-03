using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owex
{
    public int Id { get; set; }

    public short? IsActive { get; set; }

    public short? IsConCurr { get; set; }

    public short? IsScope { get; set; }

    public string? ProcInstId { get; set; }

    public int? ParentId { get; set; }

    public int? ProcDefId { get; set; }

    public string? ActId { get; set; }

    public string? DataContex { get; set; }

    public int? B1wfinstId { get; set; }

    public string? LastUpdate { get; set; }
}
