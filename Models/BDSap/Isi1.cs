using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Isi1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? SourceType { get; set; }

    public int? SourceNo { get; set; }

    public int? SrcEntry { get; set; }

    public int? SrcStaType { get; set; }

    public string? SrcTaxAcct { get; set; }

    public int? Sacentry { get; set; }

    public int? TarStaType { get; set; }

    public string? TarTaxAcct { get; set; }

    public decimal? DistAmnt { get; set; }

    public string? SrcSubType { get; set; }

    public string? Itctype { get; set; }
}
