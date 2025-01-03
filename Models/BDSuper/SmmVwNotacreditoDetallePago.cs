using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwNotacreditoDetallePago
{
    public int? IdNotaCredito { get; set; }

    public string? CodCliente { get; set; }

    public int IdDetallePagoNota { get; set; }

    public int? Monto { get; set; }

    public DateTime? Fecha { get; set; }
}
