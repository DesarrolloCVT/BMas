using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtProductoBloqueadoDetalle
{
    public int IdProdBloqDetalle { get; set; }

    public int? IdProdBloqueado { get; set; }

    public int? IdPackage { get; set; }

    public DateTime? FechaBloqueo { get; set; }

    public DateTime? FechaLiberacion { get; set; }

    public int? IdUsuarioBloqueo { get; set; }

    public int? IdUsuarioLiberacion { get; set; }
}
