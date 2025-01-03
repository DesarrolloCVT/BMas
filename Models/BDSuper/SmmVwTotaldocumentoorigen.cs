using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwTotaldocumentoorigen
{
    public int DocEntry { get; set; }

    public int? FolioNum { get; set; }

    public decimal? DocTotal { get; set; }

    public string? DocSubType { get; set; }

    public decimal? Totalineas { get; set; }
}
