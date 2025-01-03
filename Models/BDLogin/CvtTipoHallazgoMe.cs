using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTipoHallazgoMe
{
    public int IdTipoHallazgo { get; set; }

    public int IdCategoriaHallazgo { get; set; }

    public string? NombreTipoHallazgo { get; set; }
}
