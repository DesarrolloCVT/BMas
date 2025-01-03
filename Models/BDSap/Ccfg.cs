using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ccfg
{
    public int ConfigEntr { get; set; }

    public string? ConfigName { get; set; }

    public DateTime? ConfigDate { get; set; }

    public short? ConfigTime { get; set; }

    public int? UserCode { get; set; }

    public int? CreateBy { get; set; }

    public string? ServerName { get; set; }

    public string? CompanyDb { get; set; }

    public string? Internal { get; set; }
}
