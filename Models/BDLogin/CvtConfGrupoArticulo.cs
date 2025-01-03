using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtConfGrupoArticulo
{
    public int IdGrupo { get; set; }

    public string? CtaTransformacion { get; set; }

    public string? CtaDesecho { get; set; }

    public string? CtaHurto { get; set; }

    public string? CtaFaltante { get; set; }

    public string? CtaAjuste { get; set; }

    public string? CtaMuestra { get; set; }
}
