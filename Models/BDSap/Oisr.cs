using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oisr
{
    public int RequestNum { get; set; }

    public DateTime? OpenDate { get; set; }

    public int? OpenTime { get; set; }

    public int? TaskId { get; set; }

    public string? Contact { get; set; }

    public string? Phone { get; set; }

    public short? TaskType { get; set; }

    public string? Dscription { get; set; }

    public string? Answer { get; set; }

    public string? Status { get; set; }
}
