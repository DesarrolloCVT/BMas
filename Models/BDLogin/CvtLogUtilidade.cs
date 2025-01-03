using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLogUtilidade
{
    public int IdLogUtilidad { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int Ntransaccion { get; set; }

    public string TipoTransac { get; set; } = null!;
}
