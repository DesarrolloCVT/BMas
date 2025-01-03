using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ollf
{
    public int AbsEntry { get; set; }

    public string Name { get; set; } = null!;

    public string? Descr { get; set; }

    public string? MenuGuid { get; set; }

    public string? Version { get; set; }

    public string? SchVersion { get; set; }

    public string? OutPath { get; set; }

    public int? FrmId { get; set; }

    public int? UpdateNum { get; set; }

    public string? MenuName { get; set; }

    public string? MenuPath { get; set; }

    public string? Assigned { get; set; }

    public string? SboVersion { get; set; }

    public string? Type { get; set; }

    public string? SubType { get; set; }
}
