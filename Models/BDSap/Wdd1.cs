using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wdd1
{
    public int WddCode { get; set; }

    public int StepCode { get; set; }

    public int UserId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public short? SortId { get; set; }

    public DateTime? AuthUpdDat { get; set; }

    public int? AuthUpdTim { get; set; }

    public int? Substt { get; set; }
}
