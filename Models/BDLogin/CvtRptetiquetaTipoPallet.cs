using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRptetiquetaTipoPallet
{
    /// <summary>
    /// 1: Normal    2: envasado
    /// </summary>
    public int? IdTipo { get; set; }

    public string? Descripcion { get; set; }

    public byte? PideClave { get; set; }

    public int? NoCopias { get; set; }

    public string? ClaveSeguridad { get; set; }
}
