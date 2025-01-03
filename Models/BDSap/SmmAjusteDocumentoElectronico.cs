using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmAjusteDocumentoElectronico
{
    public int PreventaId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? StockSala { get; set; }

    public decimal? CantUnidades { get; set; }

    public decimal? Faltante { get; set; }
}
