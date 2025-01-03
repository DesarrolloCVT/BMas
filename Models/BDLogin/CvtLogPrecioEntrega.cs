using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLogPrecioEntrega
{
    public int IdError { get; set; }

    public string? DescError { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Modulo { get; set; }
}
