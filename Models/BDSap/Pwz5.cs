using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz5
{
    public int IdEntry { get; set; }

    public int InvId { get; set; }

    public decimal? Amount { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public DateTime? PostDate { get; set; }

    public string? ErrDisc { get; set; }

    public int ErrorLine { get; set; }

    public string? WriteErr { get; set; }

    public string Object { get; set; } = null!;

    public short InstlmntId { get; set; }

    public int? InvNum { get; set; }

    public string? Currency { get; set; }

    public string? LineType { get; set; }

    public decimal? DueBal { get; set; }

    public decimal? DueBalFc { get; set; }

    public decimal? DueBalSys { get; set; }

    public DateTime? ValDate { get; set; }

    public int? Bplid { get; set; }

    public string? Dppstatus { get; set; }
}
