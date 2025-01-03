using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omrl
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public DateTime? DocDate { get; set; }

    public string? RevalType { get; set; }

    public string? Handwrtten { get; set; }

    public string? Printed { get; set; }

    public string? Transfered { get; set; }

    public string? DocCur { get; set; }

    public decimal? DocRate { get; set; }

    public string? Ref2 { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public int? TransId { get; set; }

    public short? DocTime { get; set; }

    public string? Confirmed { get; set; }

    public short Instance { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? DataSource { get; set; }

    public string? StampNum { get; set; }

    public int? FinncPriod { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public int? LogInstanc { get; set; }

    public int? StationId { get; set; }

    public string? Rounding { get; set; }

    public short Segment { get; set; }

    public DateTime? ReqDate { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? Project { get; set; }
}
