using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogdp
{
    public int AbsEntry { get; set; }

    public string RunName { get; set; } = null!;

    public DateTime? RunDate { get; set; }

    public string? Status { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }

    public string? Action { get; set; }

    public string? Bptype { get; set; }

    public DateTime? PostDateTo { get; set; }

    public string? EmpType { get; set; }
}
