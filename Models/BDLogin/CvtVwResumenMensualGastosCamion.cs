using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenMensualGastosCamion
{
    public string Patente { get; set; } = null!;

    public string Propietario { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string? DetalleGasto { get; set; }

    public int? Monto { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? CantDocumentos { get; set; }
}
