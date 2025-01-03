using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mdc1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectKey { get; set; }

    public string? Name { get; set; }

    public DateTime? LastDate { get; set; }

    public string? Action { get; set; }

    public string? ObjectCode { get; set; }

    public string? ActFailed { get; set; }

    public string? OrigAction { get; set; }

    public string? SubObjType { get; set; }

    public string? SubObjKey { get; set; }

    public string? SubObjNam1 { get; set; }

    public string? SubObjNam2 { get; set; }

    public string? SubObjNam3 { get; set; }
}
