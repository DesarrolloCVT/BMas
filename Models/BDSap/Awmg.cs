using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awmg
{
    public int Id { get; set; }

    public int? TemplateId { get; set; }

    public string? TmplateKey { get; set; }

    public string? Name { get; set; }

    public string? Version { get; set; }

    public int? Maxins { get; set; }

    public string? Status { get; set; }

    public byte[]? Xmlfile { get; set; }

    public string? Desc { get; set; }

    public int LogIns { get; set; }

    public string? StartType { get; set; }
}
