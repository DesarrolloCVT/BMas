using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLotesBloqueadosSap
{
    public string ItemCode { get; set; } = null!;

    public string BatchNum { get; set; } = null!;

    public string Llave { get; set; } = null!;
}
