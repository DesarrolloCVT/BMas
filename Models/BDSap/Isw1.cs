using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Isw1
{
    public int WizAbsEnt { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? CardType { get; set; }

    public string? NatOfTrans { get; set; }

    public string? StatProc { get; set; }

    public string? CustProc { get; set; }

    public string? TransMode { get; set; }

    public string? Incoterms { get; set; }

    public string? PortEnEx { get; set; }

    public string? BpvatregNo { get; set; }

    public string? DomFrgId { get; set; }

    public string? CtryOrig { get; set; }

    public string? Bpcountry { get; set; }
}
