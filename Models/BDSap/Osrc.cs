using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osrc
{
    public int Code { get; set; }

    public string? SysRptName { get; set; }

    public byte[]? SysRptTemp { get; set; }

    public string? CusRptName { get; set; }

    public byte[]? CusRptTemp { get; set; }

    public string? RptChoice { get; set; }
}
