using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Btc1
{
    public int AbsEntry { get; set; }

    public short LineId { get; set; }

    public string? Glact { get; set; }

    public string? Project { get; set; }

    public string? PrftCenter { get; set; }

    public string? VatCode { get; set; }

    public int? LogInstanc { get; set; }

    public string? PrftCent2 { get; set; }

    public string? PrftCent3 { get; set; }

    public string? PrftCent4 { get; set; }

    public string? PrftCent5 { get; set; }
}
