using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ivru
{
    public int AbsEntry { get; set; }

    public string? SourceDb { get; set; }

    public string? UtilityDb { get; set; }

    public int? Ivlgentry { get; set; }

    public DateTime? UpdDate { get; set; }

    public string? TblHinm { get; set; }

    public string? TblHitm { get; set; }

    public string? TblHitw { get; set; }

    public string? TblFinm { get; set; }

    public string? TblFitm { get; set; }

    public string? TblFitw { get; set; }

    public int? TrSeqHinm { get; set; }

    public int? TrSeqOinm { get; set; }

    public int? TrIdUtil { get; set; }

    public int? TrIdProd { get; set; }

    public string? Comment { get; set; }

    public string? StrFld { get; set; }

    public int? NumFld { get; set; }
}
