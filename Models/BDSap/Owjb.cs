using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owjb
{
    public int Id { get; set; }

    public string? HandlerTyp { get; set; }

    public int? ExecId { get; set; }

    public int? Rev { get; set; }

    public DateTime? DueDate { get; set; }

    public int? ProcInstId { get; set; }

    public string? Type { get; set; }

    public string? HandlerCfg { get; set; }
}
