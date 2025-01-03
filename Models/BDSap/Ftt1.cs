using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ftt1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? FileName { get; set; }

    public DateTime? ReleaDate { get; set; }

    public string? Descript { get; set; }

    public string? Localizat { get; set; }

    public string? ChartAcct { get; set; }

    public string? DocType { get; set; }

    public int? DimCode { get; set; }
}
