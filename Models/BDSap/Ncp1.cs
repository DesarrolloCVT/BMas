using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ncp1
{
    public int AbsEntry { get; set; }

    public int? PageEntry { get; set; }

    public string? Type { get; set; }

    public int? WidgetId { get; set; }

    public string? Size { get; set; }

    public int? Index { get; set; }

    public string? Settings { get; set; }
}
