using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtListadoDesechosporgrupopbi
{
    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public DateTime? Fecha { get; set; }

    public string GrupoArticulo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal? Kilos { get; set; }
}
