using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ascl
{
    public int CallId { get; set; }

    public string? Subject { get; set; }

    public string? Customer { get; set; }

    public string? CustmrName { get; set; }

    public int? ContctCode { get; set; }

    public string? ManufSn { get; set; }

    public string? InternalSn { get; set; }

    public int? ContractId { get; set; }

    public DateTime? CntrctDate { get; set; }

    public DateTime? ResolDate { get; set; }

    public short? ResolTime { get; set; }

    public string? Free1 { get; set; }

    public DateTime? Free2 { get; set; }

    public short? Origin { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public short? ItemGroup { get; set; }

    public short? Status { get; set; }

    public string? Priority { get; set; }

    public short? CallType { get; set; }

    public short? ProblemTyp { get; set; }

    public short? Assignee { get; set; }

    public string? Descrption { get; set; }

    public string? ObjType { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? CloseDate { get; set; }

    public short? CloseTime { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? Scl1count { get; set; }

    public int? Scl2count { get; set; }

    public string? IsEntitled { get; set; }

    public int? InsId { get; set; }

    public int? Technician { get; set; }

    public string? Resolution { get; set; }

    public int? Scl1NxtLn { get; set; }

    public int? Scl2NxtLn { get; set; }

    public int? Scl3NxtLn { get; set; }

    public int? Scl4NxtLn { get; set; }

    public int? Scl5NxtLn { get; set; }

    public string? IsQueue { get; set; }

    public string? Queue { get; set; }

    public DateTime? ResolOnDat { get; set; }

    public short? ResolOnTim { get; set; }

    public DateTime? RespByDate { get; set; }

    public short? RespByTime { get; set; }

    public DateTime? RespOnDate { get; set; }

    public short? RespOnTime { get; set; }

    public short? RespAssign { get; set; }

    public DateTime? AssignDate { get; set; }

    public short? AssignTime { get; set; }

    public short? UpdateTime { get; set; }

    public short? Responder { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int? DocNum { get; set; }

    public int? Series { get; set; }

    public string? Handwrtten { get; set; }

    public string? Pindicator { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndTime { get; set; }

    public decimal? Duration { get; set; }

    public string? DurType { get; set; }

    public string? Reminder { get; set; }

    public decimal? RemQty { get; set; }

    public string? RemType { get; set; }

    public DateTime? RemDate { get; set; }

    public string? RemSent { get; set; }

    public short? RemTime { get; set; }

    public short? Location { get; set; }

    public string? AddrName { get; set; }

    public string? AddrType { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Room { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? DisplInCal { get; set; }

    public string? SupplCode { get; set; }

    public string? Attachment { get; set; }

    public int? AtcEntry { get; set; }

    public string? NumAtCard { get; set; }

    public short? ProSubType { get; set; }

    public string? Bptype { get; set; }

    public string? Telephone { get; set; }

    public string? Bpphone1 { get; set; }

    public string? Bpphone2 { get; set; }

    public string? Bpcellular { get; set; }

    public string? Bpfax { get; set; }

    public string? BpshipCode { get; set; }

    public string? BpshipAddr { get; set; }

    public string? BpbillCode { get; set; }

    public string? BpbillAddr { get; set; }

    public int? Bpterrit { get; set; }

    public string? BpeMail { get; set; }

    public string? BpprojCode { get; set; }

    public string? Bpcontact { get; set; }

    public int? OwnerCode { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }

    public string? Printed { get; set; }

    public int? DataVers { get; set; }
}
