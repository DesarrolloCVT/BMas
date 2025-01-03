using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otnl
{
    public int AbsEntry { get; set; }

    public int? TrNtAbsEnt { get; set; }

    public int? TrNtLineNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? WhsCode { get; set; }

    public int? DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? DocType { get; set; }

    public int? DocLineNum { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseType { get; set; }

    public int? BaseLnNum { get; set; }

    public int? ActionType { get; set; }

    public string? Ccdnum { get; set; }

    public string? ItemCode { get; set; }

    public string? DirectImp { get; set; }

    public string? CntrOrigin { get; set; }

    public decimal? AccQty { get; set; }

    public decimal? AccNegQ { get; set; }

    public decimal? AccRelQty { get; set; }

    public decimal? Ccdqty { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public decimal? OnHandQty { get; set; }

    public int? Oilmentry { get; set; }
}
