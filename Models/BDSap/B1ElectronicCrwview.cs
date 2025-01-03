using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ElectronicCrwview
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public string? ActType { get; set; }

    public string? ActStatus { get; set; }

    public string? ActDesc { get; set; }

    public string? ActMessage { get; set; }

    public int? ActEnv { get; set; }

    public int? Branch { get; set; }

    public string? SrcObjType { get; set; }

    public int? SrcObjAbs { get; set; }

    public short? Submits { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime? RecvDate { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? IsRemoved { get; set; }

    public string? Cancelation { get; set; }

    public string? SendData { get; set; }

    public string? RecvData { get; set; }

    public string? ReportId { get; set; }

    public string? AssignedId { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public short? Year { get; set; }

    public string? SentMeth { get; set; }

    public decimal? SentValue { get; set; }

    public string? LastAmeth { get; set; }

    public decimal? LastAvalue { get; set; }
}
