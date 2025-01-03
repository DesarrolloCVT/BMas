using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oacd
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public string? PeriodCat { get; set; }

    public int? FinncPriod { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocStatus { get; set; }

    public int? TransId { get; set; }

    public string? Comments { get; set; }

    public string? Reference { get; set; }

    public string? ObjType { get; set; }

    public string? Currency { get; set; }

    public decimal? DocRate { get; set; }

    public decimal? SysRate { get; set; }

    public string Pindicator { get; set; } = null!;

    public decimal? DocTotal { get; set; }

    public decimal? DocTotalFc { get; set; }

    public decimal? DocTotalSy { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public string? JrnlMemo { get; set; }

    public DateTime? AssetDate { get; set; }

    public string? CurSource { get; set; }

    public string? DocType { get; set; }

    public string? PrjSmarz { get; set; }

    public string? DstRlSmarz { get; set; }

    public string? ManDprType { get; set; }

    public string? Handwrtten { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? DprArea { get; set; }

    public int? Bplid { get; set; }

    public string? BaseRef { get; set; }

    public string? Lvaretire { get; set; }

    public short? CancelOpt { get; set; }

    public string? Bplname { get; set; }

    public string? VatRegNum { get; set; }

    public string? GdsMovType { get; set; }
}
