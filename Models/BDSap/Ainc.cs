using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ainc
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int Series { get; set; }

    public DateTime? CountDate { get; set; }

    public int? Time { get; set; }

    public string? CountType { get; set; }

    public int? Taker1Type { get; set; }

    public int? Taker1Id { get; set; }

    public int? Taker2Type { get; set; }

    public int? Taker2Id { get; set; }

    public string? Status { get; set; }

    public string? Ref2 { get; set; }

    public string? Remarks { get; set; }

    public int LogIns { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ObjType { get; set; }

    public string? WddStatus { get; set; }

    public int? DraftKey { get; set; }

    public string? Printed { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public int? TeamCount { get; set; }

    public int? IndvCount { get; set; }

    public decimal? DiffQty { get; set; }

    public decimal? DiffPercen { get; set; }

    public int? UpdateTs { get; set; }

    public short? CreateTime { get; set; }

    public string? Pindicator { get; set; }

    public int? FinncPriod { get; set; }

    public DateTime? PostDate { get; set; }

    public string? VersionNum { get; set; }

    public string? DataSource { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public DateTime? YearEndDt { get; set; }

    public string? UIdtienda { get; set; }
}
