using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmVencimientoProyectadoBma
{
    public int? Bodega { get; set; }

    public string UCategoria { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public DateOnly? Fvencimiento { get; set; }

    public string Estado { get; set; } = null!;

    public int? DiasVencimiento { get; set; }

    public int? Price { get; set; }

    public decimal? Costo { get; set; }

    public int Enumerador { get; set; }
}
