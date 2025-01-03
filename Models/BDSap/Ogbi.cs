using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogbi
{
    public int AbsEntry { get; set; }

    public string? RepNo { get; set; }

    public string? RepCompany { get; set; }

    public string? RepPeriod { get; set; }

    public string? Currency { get; set; }

    public short? UserSign { get; set; }

    public string? CreateDate { get; set; }

    public int? RepType { get; set; }

    public string? RepEntity { get; set; }
}
