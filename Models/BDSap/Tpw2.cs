using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpw2
{
    public int AbsEntry { get; set; }

    public int LineNumber { get; set; }

    public int? TaxCategry { get; set; }

    public int? TaxType { get; set; }

    public decimal? PyblAmnt { get; set; }

    public decimal? PyblAmntFc { get; set; }

    public decimal? PyblAmntSc { get; set; }

    public decimal? Plaamnt { get; set; }

    public decimal? PlaamntFc { get; set; }

    public decimal? PlaamntSc { get; set; }
}
