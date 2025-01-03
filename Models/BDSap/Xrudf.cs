using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xrudf
{
    public int Udfid { get; set; }

    public string? ColumnId { get; set; }

    public string? Module { get; set; }

    public int? AttributeT { get; set; }

    public string? Descriptio { get; set; }

    public string? MetaName { get; set; }
}
