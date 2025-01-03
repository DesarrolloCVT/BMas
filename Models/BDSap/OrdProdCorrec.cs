using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class OrdProdCorrec
{
    public int OwDocEntry { get; set; }

    public int OwDocNum { get; set; }

    public string? OwItemCode { get; set; }

    public decimal? OwPlannedQt { get; set; }

    public decimal? OwCmpltQty { get; set; }

    public DateTime? OwCloseDate { get; set; }

    public DateTime? OwRlsDate { get; set; }

    public string? OwWarehouse { get; set; }

    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? BaseQty { get; set; }

    public decimal? PlannedQty { get; set; }

    public decimal? IssuedQty { get; set; }

    public string? IssueType { get; set; }

    public string? WareHouse { get; set; }

    public string? OrdItemName { get; set; }
}
