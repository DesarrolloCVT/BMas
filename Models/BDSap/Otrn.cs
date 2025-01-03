using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otrn
{
    public int AbsEntry { get; set; }

    public string Category { get; set; } = null!;

    public string PriCode { get; set; } = null!;

    public string SecCode { get; set; } = null!;

    public int? SourceLang { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
