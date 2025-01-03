using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otrt
{
    public string TrtCode { get; set; } = null!;

    public string? Dscription { get; set; }

    public string? FrgnMode { get; set; }

    public string? Memo { get; set; }

    public string? TransCode { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? StampTax { get; set; }

    public string? AutoVat { get; set; }

    public string? ManageWtax { get; set; }

    public string? DeferedTax { get; set; }
}
