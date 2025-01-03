using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Xrrel
{
    public string ParentId { get; set; } = null!;

    public string ChildId { get; set; } = null!;

    public int? RelType { get; set; }

    public int? SeqNo { get; set; }

    public int Global { get; set; }
}
