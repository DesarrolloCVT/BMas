using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rpr
{
    public int SeqId { get; set; }

    public string? SeqName { get; set; }

    public short? LineNum { get; set; }

    public int? ObjectId { get; set; }

    public short? SubDocType { get; set; }
}
