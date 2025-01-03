using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCategoriaDetencione
{
    public int CategoriaId { get; set; }

    public string CategoriaNombre { get; set; } = null!;

    public int? Estado { get; set; }
}
