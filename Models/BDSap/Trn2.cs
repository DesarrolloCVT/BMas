using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trn2
{
    public int TrnAbsEntr { get; set; }

    public int LineNum { get; set; }

    public int SubLineNum { get; set; }

    public int LangCode { get; set; }

    public string? Text { get; set; }
}
