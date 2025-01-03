using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Csi27
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? RelateType { get; set; }

    public int? RelateLine { get; set; }

    public int? GroupNum { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? LineTotalF { get; set; }

    public decimal? LineTotalS { get; set; }

    public int? InClassTyp { get; set; }

    public int? InClassCat { get; set; }

    public int? ExClassTyp { get; set; }

    public int? ExClassCat { get; set; }

    public int? VatCate { get; set; }

    public decimal? NetValue { get; set; }

    public decimal? NetValueFc { get; set; }

    public decimal? NetValueSc { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? VatAmFc { get; set; }

    public decimal? VatAmSc { get; set; }

    public int? WtPercCat { get; set; }

    public decimal? WtAmount { get; set; }

    public decimal? WtAmountFc { get; set; }

    public decimal? WtAmountSc { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public string? WtCategory { get; set; }

    public int? VatclassTy { get; set; }

    public int? VatclassCa { get; set; }

    public int? EbvatExCau { get; set; }
}
