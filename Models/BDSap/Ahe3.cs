using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ahe3
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public DateTime? Date { get; set; }

    public string? ReviewDesc { get; set; }

    public int? Manager { get; set; }

    public string? Grade { get; set; }

    public string? Remarks { get; set; }

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
