using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocfh
{
    public int Cfhid { get; set; }

    public string? Cfhname { get; set; }

    public short? UserSign { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
