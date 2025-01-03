using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtStockAperturaMe
{
    public int Mes { get; set; }

    public int Año { get; set; }

    public string GrupoArticulo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public int SotckGlobal { get; set; }

    public string Bodega { get; set; } = null!;

    public int StockBodega { get; set; }

    public int Comprometido { get; set; }

    public int Pedido { get; set; }

    public int Disponible { get; set; }

    public int CostoPromedio { get; set; }

    public int? UltimoPrecioCompra { get; set; }

    public DateOnly? FechaUltimaCompra { get; set; }
}
