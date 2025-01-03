using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oeit
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? Issuer { get; set; }

    public string? IssuerBrch { get; set; }

    public string? Cnterpart { get; set; }

    public string? Vat { get; set; }

    public string? PaymtMthod { get; set; }

    public string? SubmitedBy { get; set; }

    public string? SelfPrice { get; set; }
}
