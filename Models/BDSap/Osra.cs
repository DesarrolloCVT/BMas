using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osra
{
    public int ActionCode { get; set; }

    public string? Title { get; set; }

    public string? Notes { get; set; }

    public int? UserKey { get; set; }

    public string? Password { get; set; }

    public DateTime? RunDate { get; set; }

    public int? RunTime { get; set; }

    public int? RunCounter { get; set; }

    public int? ReportType { get; set; }

    public string? Active { get; set; }

    public DateTime? StartDate { get; set; }

    public string? EndType { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndCounter { get; set; }

    public string? MissBehav { get; set; }

    public string? RcrType { get; set; }

    public int? RcrIntervl { get; set; }

    public int? RcrSubType { get; set; }

    public int? RcrData2 { get; set; }

    public int? RcrData1 { get; set; }

    public string? ErrAct { get; set; }

    public string? TransfXslt { get; set; }

    public int? TimeOut { get; set; }

    public string? MsgTitle { get; set; }

    public string? MsgBody { get; set; }

    public string? LicSrvr { get; set; }

    public int? Language { get; set; }

    public string? LstRunStat { get; set; }

    public int? ErrorCount { get; set; }

    public string? PrntLayout { get; set; }

    public int? DistLstCod { get; set; }

    public string? Finished { get; set; }

    public string? Sldaddr { get; set; }

    public string? ObjType { get; set; }

    public int? ObjAbsEnt { get; set; }

    public int? OnceAt { get; set; }

    public int? Every { get; set; }

    public int? StartAt { get; set; }

    public int? EndAt { get; set; }

    public string? Dftype { get; set; }
}
