using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtProductoBloqueado
{
    public int IdProdBloqueado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdTipoBloqueo { get; set; }

    public string? Observacion { get; set; }

    public string? CodCliente { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaTerminoBloqueo { get; set; }

    public int? IdUsuarioLibera { get; set; }
}
