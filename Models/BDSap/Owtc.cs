using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owtc
{
    public int AbsEntry { get; set; }

    public string? RctType { get; set; }

    public int? RctAbs { get; set; }

    public string? Jurisdict { get; set; }

    public string? WtaxType { get; set; }

    public int? WtAbsEntry { get; set; }

    public DateTime? DueDate { get; set; }

    public int? CerSeries { get; set; }

    public int? Number { get; set; }

    public string? RefNumber { get; set; }

    public decimal? SumVatAmnt { get; set; }

    public decimal? SumDocTot { get; set; }

    public decimal? SumBaseAmn { get; set; }

    public decimal? SumAccumAm { get; set; }

    public decimal? SumPercpAm { get; set; }

    public string? Pticode { get; set; }

    public string? Handwrtten { get; set; }

    public string? Pindicator { get; set; }

    public string? PticodeRef { get; set; }
}
