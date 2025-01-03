using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hmm3
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? LangCode { get; set; }

    public string? LangDesc { get; set; }
}
