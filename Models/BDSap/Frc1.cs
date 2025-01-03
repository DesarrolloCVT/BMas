using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Frc1
{
    public short CatId { get; set; }

    public int TemplateId { get; set; }

    public string AcctCode { get; set; } = null!;

    public short VisOrder { get; set; }

    public int? Cfwid { get; set; }

    public string? CalcMethod { get; set; }

    public int? SlpCode { get; set; }

    public string? PrcCode { get; set; }

    public string? CalMethod2 { get; set; }

    public string? CalMethod3 { get; set; }

    public string? Linked { get; set; }

    public string? Sign { get; set; }
}
