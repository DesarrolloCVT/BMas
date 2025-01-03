using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Isw2
{
    public int WizAbsEnt { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? CommCode { get; set; }

    public string? SerCode { get; set; }

    public string? AddMunit { get; set; }

    public decimal? FactorAm { get; set; }

    public string? OriRegSta { get; set; }

    public string? DstRegSta { get; set; }

    public string? CtryOrig { get; set; }

    public string? SerSupplM { get; set; }

    public string? SerPymMeth { get; set; }

    public string? ItemType { get; set; }

    public string? ItemName { get; set; }

    public string? DestRegCry { get; set; }

    public string? OrigRegCry { get; set; }

    public string? UseWeight { get; set; }

    public string? StatCode { get; set; }

    public string? NatOfTrans { get; set; }

    public string? StatProc { get; set; }
}
