using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtParametrosproduccion
{
    public int ParametroId { get; set; }

    public int GolpesMinuto { get; set; }

    public int? GolpesHora { get; set; }

    public int HorasJornada { get; set; }

    public int? GolpesJornada { get; set; }

    public int PorcDetencionaceptada { get; set; }

    public string Itemcode { get; set; } = null!;

    public int? MetaTotal { get; set; }

    public int? Sala { get; set; }
}
