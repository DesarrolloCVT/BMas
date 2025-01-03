using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otrb
{
    public int AbsEntry { get; set; }

    public int? Bplid { get; set; }

    public int? Gpcid { get; set; }

    public string? Gpccode { get; set; }

    public short? Year { get; set; }

    public string? PrdType { get; set; }

    public int? PrdNum { get; set; }

    public DateTime? PrdDate { get; set; }

    public string RunName { get; set; } = null!;

    public DateTime? RunDate { get; set; }

    public string? Status { get; set; }

    public string? StateTax { get; set; }

    public DateTime? DueDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }
}
