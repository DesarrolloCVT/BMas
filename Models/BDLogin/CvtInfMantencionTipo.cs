using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfMantencionTipo
{
    public int IdInfTipoMantencion { get; set; }

    public int? Tipo { get; set; }

    public string? MantencionDet { get; set; }

    public int? IdMantInfEnc { get; set; }
}
