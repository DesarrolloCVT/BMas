using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz6
{
    public int IdEntry { get; set; }

    public int CondNum { get; set; }

    public string? SelFldId { get; set; }

    public string? FromString { get; set; }

    public int? FromNumber { get; set; }

    public decimal? FromMoney { get; set; }

    public DateTime? FromDate { get; set; }

    public string? FromMemo { get; set; }

    public string? ToString { get; set; }

    public int? ToNumber { get; set; }

    public decimal? ToMoney { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ToMemo { get; set; }
}
