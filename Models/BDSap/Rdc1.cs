using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rdc1
{
    public string DocCode { get; set; } = null!;

    public int LineNum { get; set; }

    public string? DocName { get; set; }

    public int LangCode { get; set; }

    public byte[]? Template { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTime { get; set; }
}
