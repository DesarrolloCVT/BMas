using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwListaUsuariosVerificadore
{
    public int IdUsuario { get; set; }

    public string UsuarioSistema { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public bool? Verificador { get; set; }

    public string? RutaFirma { get; set; }
}
