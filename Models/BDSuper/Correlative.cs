using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Correlative
{
    public int CorrelativeId { get; set; }

    public int? CorrelativeIn { get; set; }

    public int? CorrelativeOut { get; set; }

    public int? CorrelativeNow { get; set; }

    public string? CorrelativeDescription { get; set; }
}
