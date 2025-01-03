using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfImpresora
{
    public int Id { get; set; }

    public string? TipoDispositivo { get; set; }

    public string? TipoContrato { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Usuario { get; set; }

    public string? Contraseña { get; set; }

    public string? Mac { get; set; }

    public string? DireccionIp { get; set; }

    public string? Conectividad { get; set; }

    public string? Tóner { get; set; }

    public string? UbicaciónUsuario { get; set; }

    public string? CodAf { get; set; }

    public string? SerieDimacofi { get; set; }

    public int? Estado { get; set; }
}
