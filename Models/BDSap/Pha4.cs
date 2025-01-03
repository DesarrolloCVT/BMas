using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pha4
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? StageId { get; set; }

    public int? Typ { get; set; }

    public int? Docnum { get; set; }

    public int? DocEntry { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? Total { get; set; }

    public int? LineNum { get; set; }

    public string? Status { get; set; }

    public int? LogInstanc { get; set; }

    public string? AmountCat { get; set; }

    public string? Categorize { get; set; }

    public string? Operation { get; set; }

    public string? Chargeable { get; set; }

    public decimal? Charged { get; set; }

    public decimal? ChargedQty { get; set; }

    public string? DocType { get; set; }

    public string? EncryptIv { get; set; }

    public decimal? PartTotal { get; set; }
}
