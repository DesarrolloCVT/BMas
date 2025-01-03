using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class DimFecha
{
    public int FechaId { get; set; }

    public DateOnly Fecha { get; set; }

    public int Dia { get; set; }

    public int Mes { get; set; }

    public int Año { get; set; }
}
