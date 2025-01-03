using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osdl
{
    public int AbsEntry { get; set; }

    public string? DataSubjct { get; set; }

    public string? SubjctKey { get; set; }

    public string? DataTable { get; set; }

    public int? TblKeyCnt { get; set; }

    public string? KeyVal1 { get; set; }

    public string? KeyVal2 { get; set; }

    public string? KeyVal3 { get; set; }

    public string? KeyVal4 { get; set; }

    public string? Property { get; set; }

    public int? UserSign { get; set; }

    public int? AccessDate { get; set; }

    public int? AccessTime { get; set; }

    public string? AccessChnl { get; set; }

    public string? Version { get; set; }
}
