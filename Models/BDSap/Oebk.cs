using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oebk
{
    public int AbsEntry { get; set; }

    public string Mark { get; set; } = null!;

    public string? CancelMark { get; set; }

    public string Uid { get; set; } = null!;

    public string? IssueVatid { get; set; }

    public string? Cpvatid { get; set; }

    public string? Series { get; set; }

    public string? Aa { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? InvoiceTyp { get; set; }

    public string? Currency { get; set; }

    public decimal? TlNetVal { get; set; }

    public decimal? TlVatAmn { get; set; }

    public decimal? TlWheldAmn { get; set; }

    public decimal? TlGrossVal { get; set; }

    public int? LinkDocTyp { get; set; }

    public int? LinkDocEnt { get; set; }

    public string? IsNegMark { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public int? SourceEcm8 { get; set; }

    public string? ObjType { get; set; }

    public short? UserSign2 { get; set; }
}
