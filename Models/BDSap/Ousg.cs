using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ousg
{
    public int Id { get; set; }

    public string? Usage { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public string? UserSign { get; set; }

    public short? PostTax { get; set; }

    public string? TaxOnly { get; set; }

    public string? Cfopiis { get; set; }

    public string? Cfopios { get; set; }

    public string? Cfopii { get; set; }

    public string? Cfopois { get; set; }

    public string? Cfopoos { get; set; }

    public string? Cfopoe { get; set; }

    public string? Descr { get; set; }

    public string? FreeChrgBp { get; set; }

    public string? ThirdParty { get; set; }

    public string? Adjustment { get; set; }
}
