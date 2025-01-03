using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Civi
{
    public int AbsEntry { get; set; }

    public string? EnableRun { get; set; }

    public DateTime? EnblRunDt { get; set; }

    public int? MsgSource { get; set; }

    public string? IsOilmupd { get; set; }

    public int? EnblDays { get; set; }

    public int? LstChkMsg { get; set; }

    public DateTime? LstMsgDate { get; set; }

    public int? LstHndlMsg { get; set; }

    public string? EnableUpd { get; set; }

    public string? IgnPreUpd { get; set; }

    public string? ForceRsp { get; set; }

    public DateTime? ReorderFrm { get; set; }

    public DateTime? ReorderTo { get; set; }

    public string? InitMap { get; set; }

    public string? InitStd { get; set; }
}
