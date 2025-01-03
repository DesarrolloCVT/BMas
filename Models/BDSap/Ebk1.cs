using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ebk1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public decimal? NetValue { get; set; }

    public int? VatCatgory { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? WithheldAm { get; set; }

    public int? WhPrctCat { get; set; }

    public int? ExClassTyp { get; set; }

    public int? ExClassCat { get; set; }

    public int? VatclassTy { get; set; }

    public int? VatclassCa { get; set; }

    public int? LogInstanc { get; set; }
}
