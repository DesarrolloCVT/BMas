using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Amr3
{
    public int DocEntry { get; set; }

    public int BaseLine { get; set; }

    public int LineNum { get; set; }

    public string? Snbnum { get; set; }

    public DateTime? AdmisDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? CurrCost { get; set; }

    public decimal? NewCost { get; set; }

    public decimal? DebCred { get; set; }

    public decimal? SnbopenQty { get; set; }

    public decimal? RtoStock { get; set; }

    public int? SnbSysNum { get; set; }

    public int? SnbAbsEnt { get; set; }

    public decimal? SnbQty { get; set; }

    public decimal? SnbCostT { get; set; }

    public string? SnbLotNum { get; set; }

    public string? SnbMfn { get; set; }
}
