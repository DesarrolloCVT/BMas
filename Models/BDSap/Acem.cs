using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acem
{
    public string CemCode { get; set; } = null!;

    public string? CemDescr { get; set; }

    public string? Active { get; set; }

    public string? ObjType { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public string? DataSource { get; set; }
}
