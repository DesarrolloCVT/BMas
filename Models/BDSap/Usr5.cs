using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Usr5
{
    public string UserCode { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? ActionBy { get; set; }

    public string? ClientIp { get; set; }

    public DateTime Date { get; set; }

    public int Time { get; set; }

    public string? ClientName { get; set; }

    public int? ProcessId { get; set; }

    public int SessionId { get; set; }

    public int? ReasonId { get; set; }

    public string? ReasonDesc { get; set; }

    public int? WinSessnId { get; set; }

    public string? WinUsrName { get; set; }

    public string? ProcName { get; set; }

    public int? AliveDurtn { get; set; }

    public int? LogoutTime { get; set; }

    public string? Source { get; set; }

    public short? UserId { get; set; }
}
