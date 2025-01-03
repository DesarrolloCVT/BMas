using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwRecepcionResumenSmm
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public int? ReceptionId { get; set; }

    public decimal? Cantidad { get; set; }

    public int? BaseUnMed { get; set; }

    public decimal? UniTotal { get; set; }
}
