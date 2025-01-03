using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ipf3
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? Dscription { get; set; }

    public string? LaCallcAcc { get; set; }

    public decimal? CustSum { get; set; }

    public decimal? CustSumFc { get; set; }

    public decimal? CustSumSc { get; set; }

    public decimal? OpenSum { get; set; }

    public decimal? OpenSumFc { get; set; }

    public decimal? OpenSumSc { get; set; }

    public int? AccType { get; set; }

    public string? VatGroup { get; set; }

    public string? CstmVatStk { get; set; }

    public int? Ccdentry { get; set; }

    public int? LineNum2 { get; set; }
}
