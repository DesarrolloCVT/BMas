using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwCvtStockLotesWmsSapxBodegaVsinventarioTest2
{
    public string Grupo { get; set; } = null!;

    public string? Cuenta { get; set; }

    public string? NombreCuenta { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public decimal? AvgPrice { get; set; }

    public string? Bodega { get; set; }

    public string? Lote { get; set; }

    public int? CantidadWms { get; set; }

    public int? CantidadSap { get; set; }

    public int? Diferencia { get; set; }

    public int? CantidadInventario { get; set; }
}
