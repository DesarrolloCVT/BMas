using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Astt
{
    public int AbsId { get; set; }

    public string Name { get; set; } = null!;

    public short? UserSign { get; set; }

    public string? IsVat { get; set; }

    public int? NfTaxId { get; set; }

    public int? TpsId { get; set; }

    public decimal? Plabalance { get; set; }

    public string? Locked { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CreditCtrl { get; set; }
}
