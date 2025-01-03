using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtq17
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjectType { get; set; }

    public string? ImpDocType { get; set; }

    public string? ImpDocNum { get; set; }

    public DateTime? DateOfReg { get; set; }

    public DateTime? CustClrDat { get; set; }

    public string? ConcActNum { get; set; }

    public string? AdditNum { get; set; }

    public decimal? AddItmDv { get; set; }

    public short? TpVtransp { get; set; }

    public string? DrawSreg { get; set; }

    public decimal? AddFrNavyA { get; set; }

    public string? TypeOfImp { get; set; }

    public short? NSeqAdic { get; set; }
}
