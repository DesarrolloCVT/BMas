using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obsj
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Desc { get; set; }

    public string? Status { get; set; }

    public string? Schedule { get; set; }

    public DateTime? NextDate { get; set; }

    public short? NextTime { get; set; }

    public string? Bfparams { get; set; }

    public string? Efparams { get; set; }

    public int? Bfretry { get; set; }

    public int? Efretry { get; set; }

    public short? RunAs { get; set; }

    public string? Message { get; set; }

    public string? RunType { get; set; }
}
