using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1WtaxBaseDocView
{
    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public DateTime? DocDate { get; set; }

    public int Factor { get; set; }

    public string? CardCode { get; set; }

    public int ArrayOffset { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public int? Freight { get; set; }

    public decimal? NetSumLc { get; set; }

    public decimal? NetSumSc { get; set; }

    public decimal? NetSumFc { get; set; }

    public decimal? VatSumLc { get; set; }

    public decimal? VatSumSc { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? WtaxSumLc { get; set; }

    public decimal? WtaxSumSc { get; set; }

    public decimal? WtaxSumFc { get; set; }

    public decimal? WtaxNoVatwlc { get; set; }

    public decimal? WtaxNoVatwsc { get; set; }

    public decimal? WtaxNoVatwfc { get; set; }
}
