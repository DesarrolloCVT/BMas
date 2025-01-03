using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtChequeMontoSeparado
{
    public int CheckKey { get; set; }

    public string? Unidad { get; set; }

    public string? Decena { get; set; }

    public string? Centena { get; set; }

    public string? UnidadMil { get; set; }

    public string? DecenaMil { get; set; }

    public string? CentenaMil { get; set; }

    public string? UnidadMillon { get; set; }

    public string? DecenaMillon { get; set; }

    public string? CentenaMillon { get; set; }

    public string? UnidadBillon { get; set; }
}
