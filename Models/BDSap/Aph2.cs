using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aph2
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int? StageId { get; set; }

    public int? Area { get; set; }

    public int? Priority { get; set; }

    public string? Remarks { get; set; }

    public string? Closed { get; set; }

    public int? Solutionid { get; set; }

    public string? Solution { get; set; }

    public int? Respnsible { get; set; }

    public int? Entered { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Effort { get; set; }

    public int LogInstanc { get; set; }

    public string? EncryptIv { get; set; }
}
