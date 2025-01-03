using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osrd
{
    public string? ItemCode { get; set; }

    public int? DocType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? DocLineNum { get; set; }

    public decimal? DocQuty { get; set; }

    public decimal? DocOpenQty { get; set; }

    public DateTime? DocDate { get; set; }

    public string Status { get; set; } = null!;

    public int SrdType { get; set; }

    public string? ItemName { get; set; }

    public string? WhsCode { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? ManOutOnly { get; set; }

    public string Direction { get; set; } = null!;

    public int? CreateNew { get; set; }

    public string DataSource { get; set; } = null!;

    public int? UserSign { get; set; }
}
