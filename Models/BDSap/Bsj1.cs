using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bsj1
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string? Type { get; set; }

    public string? Params { get; set; }

    public short? RunAs { get; set; }

    public string? Status { get; set; }

    public int? PostTask { get; set; }

    public int? PreTask { get; set; }

    public DateTime? LastDate { get; set; }

    public short? LastTime { get; set; }

    public int? Retry { get; set; }

    public int? TimeOut { get; set; }

    public string? Message { get; set; }
}
