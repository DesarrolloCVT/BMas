using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Asc6
{
    public int SrcvCallId { get; set; }

    public short Line { get; set; }

    public int? Technician { get; set; }

    public short? HandledBy { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndTime { get; set; }

    public decimal? Duration { get; set; }

    public short? Location { get; set; }

    public string? AddressId { get; set; }

    public string? Address { get; set; }

    public string? Reminder { get; set; }

    public decimal? RemQty { get; set; }

    public string? DisplInCal { get; set; }

    public string? Unsched { get; set; }

    public string? DurType { get; set; }

    public string? RemType { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? RemDate { get; set; }

    public string? RemSent { get; set; }

    public short? RemTime { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Room { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? AddrType { get; set; }

    public string? StreetNo { get; set; }

    public string? ZipCode { get; set; }

    public string? Block { get; set; }

    public string? County { get; set; }

    public string? TaxOffice { get; set; }

    public string? GlblLocNum { get; set; }

    public decimal? ActualDur { get; set; }

    public string? ActDurType { get; set; }

    public string? Close { get; set; }

    public string? Remark { get; set; }

    public string? AddrTypeBs { get; set; }

    public string? SignName { get; set; }

    public string? SaleOrders { get; set; }

    public DateTime? ChkInDate { get; set; }

    public int? ChkInTime { get; set; }

    public string? ChkInLoc { get; set; }

    public string? ChkLontitu { get; set; }

    public string? ChkLatitu { get; set; }

    public DateTime? ChkOutDate { get; set; }

    public int? ChkOutTime { get; set; }

    public byte[]? SignData { get; set; }

    public string? EncryptIv { get; set; }
}
