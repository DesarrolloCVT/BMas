using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpw3
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public int CrTaxCtgry { get; set; }

    public int CrTaxType { get; set; }

    public decimal? CrUtiliz { get; set; }

    public decimal? CrUtilizFc { get; set; }

    public decimal? CrUtilizSc { get; set; }

    public string? PymMeth { get; set; }

    public decimal? PymAmnt { get; set; }

    public decimal? PymAmntFc { get; set; }

    public decimal? PymAmntSc { get; set; }

    public int MatType { get; set; }
}
