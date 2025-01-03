using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oiqr
{
    public int DocEntry { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? DocTime { get; set; }

    public string? IoffIncAcc { get; set; }

    public string? DoffDecAcc { get; set; }

    public DateTime? DocDate { get; set; }

    public string? Reference { get; set; }

    public string? Comments { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? VersionNum { get; set; }

    public int? JdtNum { get; set; }

    public string? Reference2 { get; set; }

    public string? ObjType { get; set; }

    public int? DocNum { get; set; }

    public int? Series { get; set; }

    public int? PriceSrc { get; set; }

    public int? PriceList { get; set; }

    public string? JrnlMemo { get; set; }

    public string? Status { get; set; }

    public int? LogIns { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CountDate { get; set; }

    public int? CountTime { get; set; }

    public string? WddStatus { get; set; }

    public int? DraftKey { get; set; }

    public string? Printed { get; set; }

    public decimal? DocTotal { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public int? UpdateTs { get; set; }

    public string? CopyOption { get; set; }

    public int? BaseEntry { get; set; }

    public string? Pindicator { get; set; }

    public int? FinncPriod { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public DateTime? YearEndDt { get; set; }

    public string? UIdtienda { get; set; }
}
