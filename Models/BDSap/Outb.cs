using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Outb
{
    public string TableName { get; set; } = null!;

    public string? Descr { get; set; }

    public int? TblNum { get; set; }

    public string? ObjectType { get; set; }

    public string? UsedInObj { get; set; }

    public string? LogTable { get; set; }

    public string? Archivable { get; set; }

    public string? ArchivDate { get; set; }

    public string? DisplyMenu { get; set; }
}
