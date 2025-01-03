using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCategoriaGastoCamion
{
    public int IdCategoriaGasto { get; set; }

    public string Categoria { get; set; } = null!;

    public string? Cuenta { get; set; }
}
