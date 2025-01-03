using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apm3
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? StageId { get; set; }

    public string? Path { get; set; }

    public string? File { get; set; }

    public DateTime? Date { get; set; }

    public int LogInstanc { get; set; }
}
