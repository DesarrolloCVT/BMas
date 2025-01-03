using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Octt
{
    public string TmpltName { get; set; } = null!;

    public string? Deleted { get; set; }

    public string? Renewal { get; set; }

    public short? RemindVal { get; set; }

    public string? RemindUnit { get; set; }

    public short? Duration { get; set; }

    public short? ResponsVal { get; set; }

    public string? ResponsUnt { get; set; }

    public string? Descriptio { get; set; }

    public short? PriceList { get; set; }

    public string? CntrctType { get; set; }

    public string? MonEnabled { get; set; }

    public string? TueEnabled { get; set; }

    public string? WedEnabled { get; set; }

    public string? ThuEnabled { get; set; }

    public string? FriEnabled { get; set; }

    public string? SatEnabled { get; set; }

    public string? SunEnabled { get; set; }

    public short? MonStart { get; set; }

    public short? MonEnd { get; set; }

    public short? TueStart { get; set; }

    public short? TueEnd { get; set; }

    public short? WedStart { get; set; }

    public short? WedEnd { get; set; }

    public short? ThuStart { get; set; }

    public short? ThuEnd { get; set; }

    public short? FriStart { get; set; }

    public short? FriEnd { get; set; }

    public short? SatStart { get; set; }

    public short? SatEnd { get; set; }

    public short? SunStrart { get; set; }

    public short? SunEnd { get; set; }

    public string? InclParts { get; set; }

    public string? InclWork { get; set; }

    public string? InclTravel { get; set; }

    public string? Attachment { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Remark { get; set; }

    public string? InclHldays { get; set; }

    public short? ResponseV { get; set; }

    public string? ResponseU { get; set; }

    public int? AtcEntry { get; set; }
}
