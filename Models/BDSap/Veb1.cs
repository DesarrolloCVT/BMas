using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Veb1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? ExmpDoc { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? IssueTime { get; set; }

    public short? ExmpType { get; set; }

    public string? AllItems { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public decimal? Rate { get; set; }

    public string? TaxCode { get; set; }

    public string? AuthName { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? LogInstanc { get; set; }

    public int? VisOrder { get; set; }
}
