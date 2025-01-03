using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAnalisisCostoDiario
{
    public string ItemCode { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string WhsCode { get; set; } = null!;

    public decimal AvgPriceDia { get; set; }

    public DateTime? FechaInsert { get; set; }

    public DateTime? FechaUpdate { get; set; }
}
