using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opqw
{
    public int AbsEntry { get; set; }

    public string SetName { get; set; } = null!;

    public string? SetDesc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public short? UserSign { get; set; }

    public string? CreatDraft { get; set; }

    public string? GroupBy { get; set; }

    public DateTime? ValidUntil { get; set; }

    public int? Bplid { get; set; }

    public DateTime? ReqDate { get; set; }

    public string? BaseOn { get; set; }
}
