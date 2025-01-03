using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class OinmExx
{
    public decimal? Price { get; set; }

    public int? TransNum { get; set; }

    public int? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public string? BaseRef { get; set; }

    public int? DocLineNum { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? ItemCode { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public string? Warehouse { get; set; }

    public decimal? CalcPrice { get; set; }

    public string? CardCode { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? TransValue { get; set; }

    public string? BaseCurr { get; set; }
}
