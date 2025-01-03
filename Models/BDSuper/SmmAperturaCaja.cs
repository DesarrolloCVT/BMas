using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmAperturaCaja
{
    public DateTime Fecha { get; set; }

    public int? Usuario { get; set; }

    public int? Monto { get; set; }

    public string IdCajero { get; set; } = null!;
}
