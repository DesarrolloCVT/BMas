using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfCorreo
{
    public int IdCorreo { get; set; }

    public string? Usuario { get; set; }

    public string? Cuenta { get; set; }

    public string? Contrasena { get; set; }

    public string? DominioCorreo { get; set; }

    public int? IdArea { get; set; }
}
