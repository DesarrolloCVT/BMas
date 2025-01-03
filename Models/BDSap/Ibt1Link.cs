using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ibt1Link
{
    public int? LogEntry { get; set; }

    public string? ItemCode { get; set; }

    public string? BatchNum { get; set; }

    public string? WhsCode { get; set; }

    public string? ItemName { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseNum { get; set; }

    public int? BaseLinNum { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? Quantity { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public int Direction { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? BsDocType { get; set; }

    public int? BsDocEntry { get; set; }

    public int? BsDocLine { get; set; }

    public string DataSource { get; set; } = null!;

    public int? UserSign { get; set; }
}
