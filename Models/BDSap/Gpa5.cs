using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa5
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? Selected { get; set; }

    public string? LnType { get; set; }

    public string? ProdCode { get; set; }

    public string? ProdDescr { get; set; }

    public int? PodocAbs { get; set; }

    public int? PodocNum { get; set; }

    public string? DocType { get; set; }

    public int? DocAbs { get; set; }

    public int? DocNum { get; set; }

    public int? DocLineNum { get; set; }

    public DateTime? PostDate { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescr { get; set; }

    public string? DistNumber { get; set; }

    public int? SnBabs { get; set; }

    public int? ManagedBy { get; set; }

    public decimal? LnQty { get; set; }

    public decimal? SnBqty { get; set; }

    public decimal? LnCost { get; set; }

    public string? DebCred { get; set; }

    public decimal? LnTotal { get; set; }

    public decimal? SnBtotal { get; set; }

    public decimal? SbaccTotal { get; set; }

    public decimal? SbaccQty { get; set; }

    public decimal? AcaccTotal { get; set; }

    public decimal? AcaccQty { get; set; }

    public decimal? Applied { get; set; }

    public decimal? Variance { get; set; }

    public decimal? Mrvadjust { get; set; }
}
