using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ivlg
{
    public int AbsEntry { get; set; }

    public int? UtilVer { get; set; }

    public int? B1ver { get; set; }

    public int? SrcDbver { get; set; }

    public string? DestDbname { get; set; }

    public string? DestDbpath { get; set; }

    public int? FromDoc { get; set; }

    public DateTime? FromSysDat { get; set; }

    public int? ToDoc { get; set; }

    public DateTime? ToSysDate { get; set; }

    public string? CustDbUpd { get; set; }

    public string? HistTblCrt { get; set; }

    public string? SuccRecalc { get; set; }

    public string? Comment { get; set; }

    public string? EnblFromTo { get; set; }

    public string? StrFld { get; set; }

    public int? NumFld { get; set; }

    public string? LoadCust { get; set; }
}
