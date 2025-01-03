using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omao
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Url { get; set; }

    public string? Type { get; set; }

    public string? Provider { get; set; }

    public string? ViewStyle { get; set; }

    public string? LogonMethd { get; set; }

    public string? LogonPyld { get; set; }

    public string? Enable { get; set; }

    public string? System { get; set; }

    public string? B1mobileAp { get; set; }

    public string? B1salesApp { get; set; }

    public string? B1srvcApp { get; set; }
}
