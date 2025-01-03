using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMailingInforme
{
    public int DistribucionId { get; set; }

    public string? Mail { get; set; }

    public string? Informe { get; set; }
}
