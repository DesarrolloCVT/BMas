using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLogSistema
{
    public int LogId { get; set; }

    public int? IdSubMenu { get; set; }

    public int IdUsuario { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
