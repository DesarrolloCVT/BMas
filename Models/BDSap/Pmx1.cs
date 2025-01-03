using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pmx1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? CateType { get; set; }

    public string? CateCode { get; set; }

    public string? Keyword { get; set; }

    public string? Category { get; set; }

    public string? Debit { get; set; }

    public string? Credit { get; set; }

    public string? Fcdebit { get; set; }

    public string? Fccredit { get; set; }
}
