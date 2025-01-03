using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcm
{
    public int DocEntry { get; set; }

    public int? ObjAbs { get; set; }

    public int? ObjType { get; set; }

    public string? ItemCode { get; set; }

    public DateTime? DueDate { get; set; }

    public string? OrderType { get; set; }

    public decimal? Quantity { get; set; }

    public string? Uom { get; set; }

    public string? CardCode { get; set; }

    public string? Warehouse { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public string? Origin { get; set; }

    public string? Status { get; set; }

    public short? UserSign { get; set; }

    public DateTime? DocDate { get; set; }

    public short? DocTime { get; set; }

    public int? Bplid { get; set; }

    public decimal? PriceBefDi { get; set; }

    public decimal? DiscPrcnt { get; set; }

    public DateTime? ReleasDate { get; set; }

    public decimal? PriceAftV { get; set; }

    public string? FromWhse { get; set; }

    public DateTime? FstReqDate { get; set; }

    public int? UomEntry { get; set; }

    public decimal? NumPerMsr { get; set; }

    public int? AgrNo { get; set; }

    public int? AgrLnNum { get; set; }

    public string? UseDiscnt { get; set; }

    public string? PriceMode { get; set; }

    public string? RouDatCalc { get; set; }
}
