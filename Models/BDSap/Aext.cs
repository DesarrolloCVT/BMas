using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aext
{
    public string ExpType { get; set; } = null!;

    public string? ExpName { get; set; }

    public string? ExpAcct { get; set; }

    public string? PaidByComp { get; set; }

    public string? VatGroup { get; set; }

    public string? VatGrpEu { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
