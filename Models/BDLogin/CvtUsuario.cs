using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtUsuario
{
    public int IdUsuario { get; set; }

    public string UsuarioSistema { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int IdArea { get; set; }

    public string? Depto { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public int IdPerfil { get; set; }

    public string? MailUsuario { get; set; }

    public string? ClaveEncriptada { get; set; }

    public bool? Verificador { get; set; }

    public string? RutaFirma { get; set; }

    public string? RutaFoto { get; set; }

    public string? RestriccionBodega { get; set; }

    public int? IdPerfilMovile { get; set; }

    public int? TelefonoContacto { get; set; }

    public bool? JefeArea { get; set; }
}
