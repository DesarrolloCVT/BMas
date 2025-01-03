using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTarifasExterno
{
    public string CvtCargo { get; set; } = null!;

    public decimal ValorHora { get; set; }

    public string Empresa { get; set; } = null!;
}
