using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oitr
{
    public int ReconNum { get; set; }

    public string? IsCard { get; set; }

    public string? ReconType { get; set; }

    public DateTime? ReconDate { get; set; }

    public decimal? Total { get; set; }

    public string? ReconCurr { get; set; }

    public string? Canceled { get; set; }

    public int? CancelAbs { get; set; }

    public string? IsSystem { get; set; }

    public string? InitObjTyp { get; set; }

    public int? InitObjAbs { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? ReconRule1 { get; set; }

    public string? ReconRule2 { get; set; }

    public string? ReconRule3 { get; set; }

    public string? IsMultiBp { get; set; }

    public string? VersionNum { get; set; }

    public int? OldMatNum { get; set; }

    public int? ReconJeid { get; set; }

    public string? BuildDesc { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatregNum { get; set; }

    public string? IsElectr { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public string? ObjType { get; set; }
}
