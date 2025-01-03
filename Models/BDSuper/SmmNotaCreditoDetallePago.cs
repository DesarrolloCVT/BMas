using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmNotaCreditoDetallePago
{
    public int? IdNotaCredito { get; set; }

    public int IdDetallePagoNota { get; set; }

    public int? Monto { get; set; }

    public DateTime? Fecha { get; set; }
}
