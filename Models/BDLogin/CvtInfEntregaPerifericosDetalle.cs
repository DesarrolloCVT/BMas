using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEntregaPerifericosDetalle
{
    public int IdDetPeri { get; set; }

    public int? IdDispositivo { get; set; }

    public int? Cantidad { get; set; }

    public int? TipoEntrega { get; set; }

    public string? Comentarios { get; set; }

    public int? IdEntPeriferico { get; set; }
}
