using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orcl
{
    public int AbsEntry { get; set; }

    public int? RcpEntry { get; set; }

    public int? Instance { get; set; }

    public DateTime? PlanDate { get; set; }

    public string? Status { get; set; }

    public string? DocObjType { get; set; }

    public int? DocEntry { get; set; }
}
