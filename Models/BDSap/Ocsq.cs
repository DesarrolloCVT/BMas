using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocsq
{
    public int AbsId { get; set; }

    public string? SeqType { get; set; }

    public string? FormId { get; set; }

    public string? ColToken { get; set; }

    public int? VisualIndx { get; set; }

    public string? VisInForm { get; set; }
}
