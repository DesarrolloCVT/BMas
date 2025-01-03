using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acpn
{
    public int CpnNo { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? TargetGrp { get; set; }

    public int? Owner { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? Remarks { get; set; }

    public string? WizardGen { get; set; }

    public byte[]? Template { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public int LogIns { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DataSource { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public string? Url { get; set; }

    public string? TmplPath { get; set; }

    public string? TargetType { get; set; }

    public string? ExeOption { get; set; }

    public string? Executed { get; set; }

    public string? VersionNum { get; set; }
}
