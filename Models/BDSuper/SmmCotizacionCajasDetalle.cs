using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmCotizacionCajasDetalle
{
    public int IdDetCotizacion { get; set; }

    public int? CotizacionId { get; set; }

    public string? CodProducto { get; set; }

    public int? Cantidad { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? Precio { get; set; }

    public int? CostoTotal { get; set; }

    public decimal? MargenProducto { get; set; }

    public int? PrecioTotal { get; set; }

    public string? CodigoKitPred { get; set; }
}
