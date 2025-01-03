using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oftp
{
    public string Taskid { get; set; } = null!;

    public string? UserId { get; set; }

    public int? Curr { get; set; }

    public int? Total { get; set; }

    public string? ErrorCode { get; set; }

    public string? State { get; set; }

    public DateTime? Starttime { get; set; }

    public string? FileName { get; set; }

    public string? Result { get; set; }

    public string? Onettoken { get; set; }

    public string? Tasktype { get; set; }
}
