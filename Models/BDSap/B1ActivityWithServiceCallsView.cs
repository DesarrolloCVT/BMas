using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ActivityWithServiceCallsView
{
    public int ObjType { get; set; }

    public int ClgCode { get; set; }

    public DateTime? Recontact { get; set; }

    public string? Action { get; set; }

    public short? CntctType { get; set; }

    public string? CntctTypeName { get; set; }

    public string? CardCode { get; set; }

    public string? CustmrName { get; set; }

    public short? AttendUser { get; set; }

    public int? AttendEmpl { get; set; }

    public string? Details { get; set; }

    public string? Closed { get; set; }

    public string? Personal { get; set; }

    public string? Notes { get; set; }

    public short? CntctSbjct { get; set; }

    public string? CntctSbjctname { get; set; }

    public int? AtcEntry { get; set; }

    public string? DocType { get; set; }

    public string? DocEntry { get; set; }

    public DateTime? CntctDate { get; set; }

    public short? Location { get; set; }

    public DateTime? EndDate { get; set; }

    public int? BeginTime { get; set; }

    public int? Endtime { get; set; }

    public decimal? Duration { get; set; }

    public string? DurType { get; set; }

    public int? CntctCode { get; set; }

    public int? Status { get; set; }

    public string? StatusName { get; set; }

    public string? Tentative { get; set; }

    public string? Priority { get; set; }

    public string? Reminder { get; set; }

    public DateTime? RemDate { get; set; }

    public short? RemTime { get; set; }

    public decimal? RemQty { get; set; }

    public string? RemType { get; set; }

    public int? SlpCode { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Room { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? ParentType { get; set; }

    public int? ParentId { get; set; }

    public int? PrevActvty { get; set; }

    public int? CntctTime { get; set; }

    public int? OprId { get; set; }

    public int? OprLine { get; set; }

    public string? RecurPat { get; set; }

    public int? SeriesNum { get; set; }

    public int? AssignedBy { get; set; }

    public string? Inactive { get; set; }

    public string? IsRemoved { get; set; }

    public int? Technician { get; set; }

    public string SchClosed { get; set; } = null!;

    public int? AttendReci { get; set; }
}
