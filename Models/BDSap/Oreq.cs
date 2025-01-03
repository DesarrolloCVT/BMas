using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oreq
{
    public int AbsEntry { get; set; }

    public int? Category { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public DateTime? LstUpdDate { get; set; }

    public int? LstUpdTime { get; set; }

    public string? UserSign { get; set; }

    public int? Port { get; set; }
}
