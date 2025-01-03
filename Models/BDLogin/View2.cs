using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class View2
{
    public int IdUsuario { get; set; }

    public string UsuarioSistema { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Depto { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public int? IdPerfil { get; set; }

    public string? MailUsuario { get; set; }
}
