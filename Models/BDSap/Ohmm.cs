using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohmm
{
    public int DocEntry { get; set; }

    public string? ModelAuth { get; set; }

    public string? ModelName { get; set; }

    public string? ModelVer { get; set; }

    public string? Desc { get; set; }

    public string? Status { get; set; }

    public byte[]? InfoFile { get; set; }

    public int? UpdateBy { get; set; }

    public string? ChangeBy { get; set; }

    public string? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public string? ChangeDate { get; set; }

    public int? ChangeTime { get; set; }

    public int? TaskId { get; set; }

    public DateTime? DeployDate { get; set; }

    public int? DeployTime { get; set; }

    public string? Language { get; set; }
}
