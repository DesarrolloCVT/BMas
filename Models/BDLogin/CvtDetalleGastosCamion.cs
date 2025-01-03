using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetalleGastosCamion
{
    public int IdGastoCamion { get; set; }

    public string? DetalleGasto { get; set; }

    public int? IdCategoriaGasto { get; set; }

    public string? Item { get; set; }
}
