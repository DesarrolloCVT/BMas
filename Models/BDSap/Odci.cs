using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odci
{
    public int AbsEntry { get; set; }

    public string? ConfType { get; set; }

    public string? Code { get; set; }

    public string? Descr { get; set; }

    public decimal? PrcstVal { get; set; }

    public int? SuppUnit { get; set; }

    public string? Export { get; set; }

    public string? Import { get; set; }

    public string? StatCode { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? TextVal { get; set; }

    public string? ConfId { get; set; }

    public string? TriangDeal { get; set; }
}
