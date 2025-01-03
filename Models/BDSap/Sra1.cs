using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sra1
{
    public int ActionCode { get; set; }

    public int ParamCode { get; set; }

    public string KeyString { get; set; } = null!;

    public int KeyNumber { get; set; }

    public string? ValString { get; set; }

    public int? ValNumber { get; set; }

    public decimal? ValMoney { get; set; }
}
