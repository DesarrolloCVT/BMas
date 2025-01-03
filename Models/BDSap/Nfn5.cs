using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nfn5
{
    public short SeqCode { get; set; }

    public int? NfeNoFrom { get; set; }

    public int? NfeNoTo { get; set; }

    public short? Year { get; set; }

    public string? Reason { get; set; }

    public string? Reply { get; set; }

    public string? Status { get; set; }

    public short VisOrder { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTime { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }
}
