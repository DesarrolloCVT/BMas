using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osl
{
    public string Guid { get; set; } = null!;

    public string? Origin { get; set; }

    public string? SrcLink { get; set; }

    public string? OwnerCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }
}
