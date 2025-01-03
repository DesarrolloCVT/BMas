using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Faa1
{
    public int Code { get; set; }

    public int LineNum { get; set; }

    public int AttrId { get; set; }

    public string? AttrName { get; set; }

    public string? FieldType { get; set; }

    public string? DefaultVal { get; set; }

    public int? LogInstanc { get; set; }

    public int? SnapshotId { get; set; }
}
