using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Req1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? MsgType { get; set; }

    public string? ErrCode { get; set; }

    public string? MsgBody { get; set; }

    public string? Status { get; set; }

    public DateTime? MsgDate { get; set; }

    public int? MsgTime { get; set; }
}
