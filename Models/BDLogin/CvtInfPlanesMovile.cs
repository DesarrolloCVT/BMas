using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfPlanesMovile
{
    public string PlanCodigo { get; set; } = null!;

    public string PlanNombre { get; set; } = null!;

    public int Gb { get; set; }

    public int Minutos { get; set; }

    public int Sms { get; set; }

    public int CargoFijoNeto { get; set; }

    public int ValorMinutoAdicional { get; set; }

    public int VelocidadResidual { get; set; }
}
