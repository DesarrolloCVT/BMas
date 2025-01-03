using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oat1
{
    public int AgrNo { get; set; }

    public int AgrLineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public short? ItemGroup { get; set; }

    public decimal? PlanQty { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Currency { get; set; }

    public decimal? CumQty { get; set; }

    public decimal? CumAmntFc { get; set; }

    public decimal? CumAmntLc { get; set; }

    public string? FreeTxt { get; set; }

    public string? InvntryUom { get; set; }

    public int? LogInstanc { get; set; }

    public int? VisOrder { get; set; }

    public decimal? RetPortion { get; set; }

    public DateTime? WrrtyEnd { get; set; }

    public string? LineStatus { get; set; }

    public decimal? PlanAmtLc { get; set; }

    public decimal? PlanAmtFc { get; set; }

    public decimal? Discount { get; set; }

    public int? UomEntry { get; set; }

    public string? UomCode { get; set; }

    public decimal? NumPerMsr { get; set; }

    public decimal? UndlvQty { get; set; }

    public decimal? UndlvAmntL { get; set; }

    public decimal? UndlvAmntF { get; set; }

    public short? TrnspCode { get; set; }

    public string? Project { get; set; }

    public string? TaxCode { get; set; }

    public decimal? Taxrate { get; set; }

    public decimal? PlVatAmtLc { get; set; }

    public decimal? PlVatAmtFc { get; set; }

    public decimal? CumVtAmtLc { get; set; }

    public decimal? CumVtAmtFc { get; set; }

    public string? EncryptIv { get; set; }
}
