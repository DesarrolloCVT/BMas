using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apf
{
    public int AbsEntry { get; set; }

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string? RefObjType { get; set; }

    public string Category { get; set; } = null!;

    public string? OrigType { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public int LogInstanc { get; set; }

    public string? Type { get; set; }

    public string? Descr { get; set; }

    public string? MaxType { get; set; }
}
