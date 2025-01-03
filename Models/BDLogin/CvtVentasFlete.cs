using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVentasFlete
{
    public int CvtVentasFletesId { get; set; }

    public string Ciudad { get; set; } = null!;

    public int Valor { get; set; }
}
