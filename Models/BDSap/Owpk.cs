using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owpk
{
    public int AbsEntry { get; set; }

    public string PackagCode { get; set; } = null!;

    public string? PackagName { get; set; }

    public string? Note { get; set; }

    public byte[]? Content { get; set; }

    public string? Author { get; set; }

    public string? Version { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? IsSystem { get; set; }

    public string? PackagType { get; set; }

    public string? Isimdb { get; set; }

    public string? StraType { get; set; }

    public string? StraPara { get; set; }

    public string? SourceType { get; set; }

    public string? ViewName { get; set; }

    public string? ViewCtg { get; set; }

    public string? ViewSyn { get; set; }

    public int? Viewid { get; set; }
}
