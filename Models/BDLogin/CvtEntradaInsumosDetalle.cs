using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEntradaInsumosDetalle
{
    public int EntradaInsumosId { get; set; }

    public int EntradaInsumosDetalleId { get; set; }

    public int DocEntry { get; set; }

    public string CardCode { get; set; } = null!;

    public string CardName { get; set; } = null!;

    public int DocNum { get; set; }

    public int LineNum { get; set; }

    public string ItemCode { get; set; } = null!;

    public string Dscription { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal OpenQty { get; set; }

    public string Bodega { get; set; } = null!;

    public decimal? CantRecepcionar { get; set; }
}
