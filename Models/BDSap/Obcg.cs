using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obcg
{
    public string? CardCode { get; set; }

    public decimal? BkChgAmt { get; set; }

    public int SerialNo { get; set; }

    public string? DocCurr { get; set; }

    public decimal? BcgTaxAmt { get; set; }
}
