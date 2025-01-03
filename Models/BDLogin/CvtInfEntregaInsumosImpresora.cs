using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEntregaInsumosImpresora
{
    public int IdEntInsImp { get; set; }

    public int? IdToner { get; set; }

    public int? GuiaDimacofi { get; set; }

    public string? IdActivoF { get; set; }

    public string? Hhimpresora { get; set; }

    public int? ContPaginas { get; set; }

    public string? Comentarios { get; set; }

    public DateTime? FechaInstalacion { get; set; }
}
