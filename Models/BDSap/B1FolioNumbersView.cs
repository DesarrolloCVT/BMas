using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1FolioNumbersView
{
    public int? FolSeries { get; set; }

    public int? FolNumFrom { get; set; }

    public int? FolNumTo { get; set; }

    public string? ObjType { get; set; }

    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocSubType { get; set; }

    public string? Pticode { get; set; }

    public string? Letter { get; set; }

    public string? Canceled { get; set; }
}
