using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pqw1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public DateTime? PqtreqDate { get; set; }

    public decimal? PqtreqQty { get; set; }

    public string? BuyUnitMsr { get; set; }

    public string? FreeTxt { get; set; }

    public int? PqtgrpNum { get; set; }

    public int? PqtgrpSer { get; set; }

    public string? PqtgrpHw { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? WhsCode { get; set; }

    public int? Pqtseries { get; set; }

    public int? PrabsEntry { get; set; }

    public string? ReqName { get; set; }

    public int? PrlineNum { get; set; }

    public string? PrlineStat { get; set; }

    public string? DistriRule { get; set; }

    public string? Project { get; set; }

    public string? VendMfrNum { get; set; }

    public short? ShipType { get; set; }

    public decimal? ItmPerUnit { get; set; }

    public string? PriceMode { get; set; }
}
