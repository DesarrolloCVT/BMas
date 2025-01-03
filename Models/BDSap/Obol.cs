using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obol
{
    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public int? ItemUid { get; set; }
}
