using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trs1
{
    public int AbsEntry { get; set; }

    public string? ObjType { get; set; }

    public int LineId { get; set; }

    public string ApDocType { get; set; } = null!;

    public int ApDocEntry { get; set; }

    public int ApDocOrdNo { get; set; }

    public int? ApDocAdRef { get; set; }

    public int MeansType { get; set; }

    public int PayLineId { get; set; }

    public int PayDocType { get; set; }

    public int PayDocEntr { get; set; }
}
