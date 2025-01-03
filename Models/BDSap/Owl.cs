using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owl
{
    public int? WfinstId { get; set; }

    public int TaskId { get; set; }

    public string? Wfid { get; set; }

    public string? Wfname { get; set; }

    public string? TaskDesc { get; set; }

    public string? ObjType { get; set; }

    public string? Operation { get; set; }

    public string? ObjKey { get; set; }

    public DateTime? EnterDate { get; set; }

    public short? EnterTime { get; set; }

    public string? TaskType { get; set; }

    public DateTime? DueDate { get; set; }

    public short? DueTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? Owner { get; set; }

    public short? Priority { get; set; }

    public short? UserSign { get; set; }

    public string? Status { get; set; }

    public int? LogIns { get; set; }

    public short? UserSign2 { get; set; }

    public string? Deleted { get; set; }

    public int? DuraDays { get; set; }

    public short? DuraHours { get; set; }

    public string? TaskName { get; set; }

    public string? IsPicked { get; set; }

    public string? Attachment { get; set; }

    public int? AtcEntry { get; set; }

    public int? WorkListId { get; set; }

    public string? ObjSubType { get; set; }

    public string? ForwardTo { get; set; }

    public string? WasRead { get; set; }

    public string? TrigParams { get; set; }

    public string? Key { get; set; }
}
