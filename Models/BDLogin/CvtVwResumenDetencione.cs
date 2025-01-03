using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenDetencione
{
    public int OfId { get; set; }

    public string DetencionMotivo { get; set; } = null!;

    public string CategoriaNombre { get; set; } = null!;

    public int? TotalMin { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public string TipoDetencion { get; set; } = null!;
}
