using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ahe6
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public int? RoleId { get; set; }

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
