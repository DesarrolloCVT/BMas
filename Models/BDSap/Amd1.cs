using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Amd1
{
    public int LineNum { get; set; }

    public int PmnNum { get; set; }

    public int PmnInvId { get; set; }

    public DateTime? PmnDate { get; set; }

    public string? CardCode { get; set; }

    public string? InvType { get; set; }

    public int? InvEntry { get; set; }

    public short? InstId { get; set; }

    public int? InvTransId { get; set; }

    public string? Fccurrency { get; set; }

    public decimal? InvRate { get; set; }

    public decimal? PmnRate { get; set; }

    public string? Approved { get; set; }

    public decimal? AmountDiff { get; set; }

    public decimal? TaxAmtDiff { get; set; }

    public string? TmpJe { get; set; }
}
