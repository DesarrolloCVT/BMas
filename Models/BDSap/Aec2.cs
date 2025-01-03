using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec2
{
    public int AbsEntry { get; set; }

    public string? Code { get; set; }

    public int? ParentId { get; set; }

    public string? ActType { get; set; }

    public string? ActDesc { get; set; }

    public string? ActStatus { get; set; }

    public string? IsRemoved { get; set; }

    public string? ActMessage { get; set; }

    public int? ActEnv { get; set; }

    public int? Bplid { get; set; }

    public short? Submits { get; set; }

    public string? ObjectId { get; set; }

    public string? ReportId { get; set; }

    public string? SrcObjType { get; set; }

    public int? SrcObjAbs { get; set; }

    public string? Cancel { get; set; }

    public string? AssignedId { get; set; }

    public string? DocBtch { get; set; }

    public short? DocBtchLn { get; set; }

    public string? GenType { get; set; }

    public string? TestMode { get; set; }

    public string? PeriodType { get; set; }

    public int? PeriodNum { get; set; }

    public short? Year { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public short LogInstanc { get; set; }

    public int? SchedJobId { get; set; }

    public string? Guid { get; set; }

    public string? Authority { get; set; }

    public string? CancStatus { get; set; }

    public int? EdocType { get; set; }

    public string? EdocNum { get; set; }

    public string? ProcTarget { get; set; }

    public decimal? UB1sysXmlamount { get; set; }

    public DateTime? UB1sysSendDateIntm { get; set; }
}
