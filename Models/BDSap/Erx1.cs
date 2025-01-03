using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Erx1
{
    public int ErnId { get; set; }

    public int NumTypeId { get; set; }

    public string? NumTypeNam { get; set; }

    public int? FirstNum { get; set; }

    public int? NextNum { get; set; }

    public int? LastNum { get; set; }

    public DateTime? ResetDate { get; set; }
}
