using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAfIndiceReajustabilidad
{
    public int Ano { get; set; }

    public int Mes { get; set; }

    public DateOnly? Periodo { get; set; }

    public decimal? Porcentaje { get; set; }
}
