using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfConexionRemotum
{
    public int IdConRemota { get; set; }

    public string? Usuario { get; set; }

    public string? IdTemViewer { get; set; }

    public string? Contrasena { get; set; }

    public int? IdArea { get; set; }

    public string? Tipo { get; set; }

    public string? UsuarioDominio { get; set; }
}
