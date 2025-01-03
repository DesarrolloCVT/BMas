using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sfc9
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseLine { get; set; }

    public string? TargetBase { get; set; }

    public string? ObjType { get; set; }

    public decimal? DrawnSum { get; set; }

    public decimal? DrawnSumFc { get; set; }

    public decimal? DrawnSumSc { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjCode { get; set; }

    public decimal? ApplDrawn { get; set; }

    public decimal? ApplDrawnF { get; set; }

    public decimal? ApplDrawnS { get; set; }

    public int? BaseDocNum { get; set; }

    public DateTime? BsDocDate { get; set; }

    public DateTime? BsDueDate { get; set; }

    public string? BsCardName { get; set; }

    public string? BsComments { get; set; }

    public string? Posted { get; set; }

    public decimal? Vat { get; set; }

    public decimal? VatFc { get; set; }

    public decimal? VatSc { get; set; }

    public decimal? Gross { get; set; }

    public decimal? GrossFc { get; set; }

    public decimal? GrossSc { get; set; }

    public string? IsGross { get; set; }
}
