using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmRegImpEtiquetum
{
    public int IdRegImpEtiq { get; set; }

    public string? CodProd { get; set; }

    public DateOnly? FechRegistro { get; set; }

    public int? Estado { get; set; }
}
