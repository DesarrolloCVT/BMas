using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofrt
{
    public int AbsId { get; set; }

    public string Name { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public short? Frtcounter { get; set; }

    public string? MoveChk1 { get; set; }

    public string? MoveChk2 { get; set; }

    public short? MoveTo1 { get; set; }

    public short? MoveTo2 { get; set; }

    public string? Title1 { get; set; }

    public string? Title2 { get; set; }

    public string? ShowMiss { get; set; }

    public short? ToTitle1 { get; set; }

    public short? ToTitle2 { get; set; }

    public short? UserSign { get; set; }

    public int? DimCode { get; set; }
}
