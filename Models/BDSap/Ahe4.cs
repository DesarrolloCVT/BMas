using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ahe4
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Employer { get; set; }

    public string? Position { get; set; }

    public string? Remarks { get; set; }

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
