using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi7
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? DocDate { get; set; }

    public string? DocType { get; set; }

    public string? JrnEntryNo { get; set; }

    public int? LnNo { get; set; }

    public string? Remark { get; set; }

    public string? AcctNo { get; set; }

    public string? Currency { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Fcdebit { get; set; }

    public decimal? Fccredit { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? EvaGrp { get; set; }

    public string? SettMeth { get; set; }

    public string? BillType { get; set; }

    public string? BillNo { get; set; }

    public string? BillDate { get; set; }

    public short? AttmtNum { get; set; }

    public string? Creator { get; set; }

    public string? Approver { get; set; }

    public string? Bookkeeper { get; set; }

    public string? Cashier { get; set; }

    public string? Posted { get; set; }

    public string? Reversed { get; set; }

    public string? DocNum { get; set; }
}
