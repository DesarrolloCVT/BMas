using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Abtc
{
    public int AbsEntry { get; set; }

    public string? InOpCode { get; set; }

    public string? PstTrans { get; set; }

    public string? BporAct { get; set; }

    public string? PstMethod { get; set; }

    public string? ActFee { get; set; }

    public string? ProjFee { get; set; }

    public string? PrftCntFee { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public string? Descript { get; set; }

    public string? PrftCntFe2 { get; set; }

    public string? PrftCntFe3 { get; set; }

    public string? PrftCntFe4 { get; set; }

    public string? PrftCntFe5 { get; set; }

    public short? UserSign2 { get; set; }
}
