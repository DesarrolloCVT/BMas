using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awl3
{
    public int? WfinstId { get; set; }

    public int TaskId { get; set; }

    public int LineId { get; set; }

    public string? Note { get; set; }

    public string? Creator { get; set; }

    public DateTime? NoteDate { get; set; }

    public string? Access { get; set; }

    public int LogIns { get; set; }
}
