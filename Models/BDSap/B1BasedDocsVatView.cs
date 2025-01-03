using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1BasedDocsVatView
{
    public int AbsEntry { get; set; }

    public int LineSeq { get; set; }

    public string SrcObjType { get; set; } = null!;

    public int SrcObjAbs { get; set; }

    public int? DocNum { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? DeductSum { get; set; }

    public decimal? EqSum { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public int? FolioNum { get; set; }

    public string? FolioPref { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public string? DocType { get; set; }

    public DateTime? VatDate { get; set; }

    public string? LicTradNum { get; set; }

    public int? Series { get; set; }

    public string? Canceled { get; set; }
}
