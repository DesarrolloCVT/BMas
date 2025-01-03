using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcr
{
    public string RcurCode { get; set; } = null!;

    public string? RcurDesc { get; set; }

    public string? Frequency { get; set; }

    public short? Remind { get; set; }

    public DateTime? LastPosted { get; set; }

    public DateTime? NextDeu { get; set; }

    public short? EntryCount { get; set; }

    public decimal? Volume { get; set; }

    public string? VolCurr { get; set; }

    public decimal? FinancVol { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? TransCode { get; set; }

    public string? Memo { get; set; }

    public string? LimitRtrns { get; set; }

    public short? Returns { get; set; }

    public DateTime? LimitDate { get; set; }

    public short Instance { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? StampTax { get; set; }

    public string? AutoVat { get; set; }

    public string? ManageWtax { get; set; }

    public string? Ref3 { get; set; }

    public string? DeferedTax { get; set; }
}
