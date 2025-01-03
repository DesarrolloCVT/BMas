using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oalt
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Priority { get; set; }

    public string? Active { get; set; }

    public int? NumOfParam { get; set; }

    public string? ParamData { get; set; }

    public string? Params { get; set; }

    public int? NumOfDocs { get; set; }

    public string? DocsData { get; set; }

    public string? Docs { get; set; }

    public string? UserText { get; set; }

    public int? QueryId { get; set; }

    public string? FrqncyType { get; set; }

    public int? FrqncyIntr { get; set; }

    public short? ExecDaY { get; set; }

    public int? ExecTime { get; set; }

    public DateTime? LastDate { get; set; }

    public short? LastTime { get; set; }

    public DateTime? NextDate { get; set; }

    public short? NextTime { get; set; }

    public short? UserSign { get; set; }

    public string? History { get; set; }

    public int? Qcategory { get; set; }
}
