using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acl1
{
    public int ClgCode { get; set; }

    public int LineNum { get; set; }

    public DateTime? Date { get; set; }

    public string? Location { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public int? Time { get; set; }

    public short? OwnerUser { get; set; }

    public int? OwnerEmp { get; set; }

    public int LogInstanc { get; set; }
}
