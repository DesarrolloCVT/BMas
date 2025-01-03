using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Udg1
{
    public string Code { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public short? Copies { get; set; }

    public string? PrintOnAdd { get; set; }

    public string? ExprtOnAdd { get; set; }

    public string? RoundSums { get; set; }

    public string? Remark { get; set; }

    public string? PrintSums { get; set; }

    public string? VndrNum { get; set; }

    public string? PrnDscnt { get; set; }

    public short? HandCopies { get; set; }

    public string? EngKbitem { get; set; }

    public string? EngKbcard { get; set; }

    public string? EmailOnAdd { get; set; }

    public string? PdfonAdd { get; set; }
}
