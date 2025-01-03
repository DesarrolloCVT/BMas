using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aec8
{
    public int AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public int? ParentId { get; set; }

    public string? ActType { get; set; }

    public string? ActDesc { get; set; }

    public string? ActStatus { get; set; }

    public string? ActMessage { get; set; }

    public string? TestMode { get; set; }

    public string? Guid { get; set; }

    public string? Authority { get; set; }

    public string? ProcSource { get; set; }

    public string? MetaData { get; set; }

    public string? Mimetype { get; set; }

    public string? FileName { get; set; }

    public string? CardCode { get; set; }

    public DateTime? DocDate { get; set; }

    public string? ObjType { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? AssignedId { get; set; }
}
