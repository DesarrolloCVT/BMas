using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtc2
{
    public int AbsEntry { get; set; }

    public int BaseLineId { get; set; }

    public int LineId { get; set; }

    public int? DocEntry { get; set; }

    public string? DocObjType { get; set; }

    public decimal? VatAmnt { get; set; }

    public decimal? DocTot { get; set; }

    public decimal? WtbaseAmnt { get; set; }

    public decimal? WtaccAmnt { get; set; }

    public decimal? WtpercpAm { get; set; }

    public decimal? Wtpercent { get; set; }
}
