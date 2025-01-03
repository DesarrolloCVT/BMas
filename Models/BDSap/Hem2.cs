using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hem2
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? Type { get; set; }

    public string? Institute { get; set; }

    public string? Major { get; set; }

    public string? Diploma { get; set; }

    public int? LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
