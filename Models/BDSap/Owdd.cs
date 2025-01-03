using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owdd
{
    public int WddCode { get; set; }

    public int? WtmCode { get; set; }

    public int? OwnerId { get; set; }

    public int? DocEntry { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public int? CurrStep { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? IsDraft { get; set; }

    public short? MaxReqr { get; set; }

    public short? MaxRejReqr { get; set; }

    public int? SrcDocEnt { get; set; }

    public string? DraftType { get; set; }

    public int? DraftEntry { get; set; }

    public string? Bftype { get; set; }

    public int? ProcessId { get; set; }

    public string? ProcesStat { get; set; }

    public string? StpUpdated { get; set; }
}
