using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obdc
{
    public int Code { get; set; }

    public string? Server { get; set; }

    public string? License { get; set; }

    public string? Company { get; set; }

    public int? Dbtype { get; set; }

    public string? Dbuser { get; set; }

    public string? Dbpassword { get; set; }

    public string? Username { get; set; }

    public string? Upassword { get; set; }

    public string? Dbtrusted { get; set; }

    public string? Jcopath { get; set; }

    public int? Language { get; set; }

    public string? AddOnIf { get; set; }

    public string? StateFder { get; set; }

    public string? FormatFder { get; set; }

    public string? FileFolder { get; set; }
}
