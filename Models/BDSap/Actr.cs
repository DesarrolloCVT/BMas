using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Actr
{
    public int ContractId { get; set; }

    public string? CstmrCode { get; set; }

    public string? CstmrName { get; set; }

    public int? CntctCode { get; set; }

    public short? Owner { get; set; }

    public string? Status { get; set; }

    public string? CntrcTmplt { get; set; }

    public string? CntrcType { get; set; }

    public string? Renewal { get; set; }

    public short? RemindVal { get; set; }

    public string? RemindUnit { get; set; }

    public short? Duration { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public short? ResponsVal { get; set; }

    public string? ResponsUnt { get; set; }

    public string? Descriptio { get; set; }

    public string? SrcDocType { get; set; }

    public int? DocNum { get; set; }

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

    public string? Remarks1 { get; set; }

    public string? Remarks2 { get; set; }

    public string? RemindFlg { get; set; }

    public int? Ctr1count { get; set; }

    public int? DocEntry { get; set; }

    public int? RemTmDays { get; set; }

    public int? ResTmHours { get; set; }

    public string? InclHldays { get; set; }

    public string? SrvcType { get; set; }

    public DateTime? TermDate { get; set; }

    public short? ResponseV { get; set; }

    public string? ResponseU { get; set; }

    public int? AtcEntry { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public string? Bptype { get; set; }

    public int? OwnerCode { get; set; }

    public short? UserSign { get; set; }

    public string? ObjType { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }

    public string? Printed { get; set; }
}
