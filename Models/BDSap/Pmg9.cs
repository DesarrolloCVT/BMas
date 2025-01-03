using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pmg9
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public int BwrefId { get; set; }

    public int TargetType { get; set; }

    public int TargetAbs { get; set; }

    public int? TargetNum { get; set; }

    public int? TargetLine { get; set; }

    public int? SubProjId { get; set; }

    public int? StageId { get; set; }

    public int? SourceType { get; set; }

    public int? SourceAbs { get; set; }

    public int? SourceNum { get; set; }

    public int? SourceLine { get; set; }

    public decimal? Charged { get; set; }

    public decimal? ChargedQty { get; set; }

    public int? DestType { get; set; }

    public int? DestArr { get; set; }

    public int? DestAbs { get; set; }

    public int? DestLine { get; set; }
}
