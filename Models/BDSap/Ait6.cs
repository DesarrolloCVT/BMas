using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait6
{
    public string ItemCode { get; set; } = null!;

    public int LineNum { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
