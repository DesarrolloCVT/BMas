using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oefdw
{
    public int AbsEntry { get; set; }

    public string? RunName { get; set; }

    public DateTime? RunDate { get; set; }

    public short? RunTime { get; set; }

    public string? Status { get; set; }

    public int? UserSign { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? Branch { get; set; }

    public string? ProfType { get; set; }

    public string? BlockC { get; set; }

    public string? BlockD { get; set; }

    public string? BlockE { get; set; }

    public string? BlockH { get; set; }

    public string? BlockG { get; set; }

    public string? BlockI { get; set; }

    public string? FlPurCode { get; set; }

    public int? AccEmploye { get; set; }

    public string? AccExtern { get; set; }

    public string? ItmFrom { get; set; }

    public string? ItmTo { get; set; }

    public short? ItmGroup { get; set; }

    public string? ItQryGroup { get; set; }

    public string? RptReason { get; set; }
}
