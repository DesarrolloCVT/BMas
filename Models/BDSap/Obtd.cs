using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obtd
{
    public int BatchNum { get; set; }

    public string? Status { get; set; }

    public short? NumOfTrans { get; set; }

    public DateTime? DateId { get; set; }

    public decimal? LocTotal { get; set; }

    public decimal? FcTotal { get; set; }

    public decimal? SysTotal { get; set; }

    public string? MemoId { get; set; }

    public short? UserSign { get; set; }

    public string? Remarks { get; set; }
}
