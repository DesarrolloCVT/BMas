using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odpt
{
    public int DeposId { get; set; }

    public string? DeposType { get; set; }

    public DateTime? DeposDate { get; set; }

    public string? DeposCurr { get; set; }

    public string? BanckAcct { get; set; }

    public string? Memo { get; set; }

    public decimal? LocTotal { get; set; }

    public decimal? FcTotal { get; set; }

    public decimal? SysTotal { get; set; }

    public int? TransAbs { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public decimal? DocRate { get; set; }

    public string? Splited { get; set; }

    public string? VatAct { get; set; }

    public string? ComissAct { get; set; }

    public decimal? VatTotal { get; set; }

    public decimal? Comission { get; set; }

    public DateTime? ComissDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? DataSource { get; set; }

    public string? ObjType { get; set; }

    public int? FinncPriod { get; set; }

    public decimal? VatTotlSys { get; set; }

    public decimal? ComissnSys { get; set; }

    public short? UserSign { get; set; }

    public string? CommisVat { get; set; }

    public string? Project { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public decimal? ComisFc { get; set; }

    public decimal? VatTotlFc { get; set; }

    public string? ComisCurr { get; set; }
}
