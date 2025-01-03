using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPorcentajePalletProducidosEnvasado
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public string? CtaCostoVenta { get; set; }

    public int? CantPalletsGrupo { get; set; }

    public int? CantPalletsTotal { get; set; }

    public decimal? Porcentaje { get; set; }
}
