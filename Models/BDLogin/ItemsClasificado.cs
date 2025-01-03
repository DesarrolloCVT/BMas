using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class ItemsClasificado
{
    public int Id { get; set; }

    public string? Item { get; set; }

    public string? CentroCosto { get; set; }

    public string? GastoItem { get; set; }

    public string? Clasificacion { get; set; }
}
