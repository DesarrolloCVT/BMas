using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opci
{
    public int InstancePk { get; set; }

    public int? TemplateFk { get; set; }

    public string? InstName { get; set; }

    public string? InstDesc { get; set; }

    public string? Creator { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public decimal? CloPrcnt { get; set; }

    public string? Memo { get; set; }

    public string? Attachment { get; set; }

    public int? AtcEntry { get; set; }
}
