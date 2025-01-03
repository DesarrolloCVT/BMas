using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oslt
{
    public int SltCode { get; set; }

    public string? ItemCode { get; set; }

    public int? StatusNum { get; set; }

    public int? Owner { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string? Subject { get; set; }

    public string? Symptom { get; set; }

    public string? Cause { get; set; }

    public string? Descriptio { get; set; }

    public string? Attachment { get; set; }

    public int? AtcEntry { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int? DataVers { get; set; }
}
