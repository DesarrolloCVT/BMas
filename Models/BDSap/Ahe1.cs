using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ahe1
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Reason { get; set; }

    public string? ApprovedBy { get; set; }

    public int? CnfrmrNum { get; set; }

    public int LogInstanc { get; set; }

    public int? Type { get; set; }

    public string? EncryptIv { get; set; }
}
