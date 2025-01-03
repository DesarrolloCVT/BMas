using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class RegistrosJornadaPractica
{
    public string Rut { get; set; } = null!;

    public string? Nombre { get; set; }

    public DateTime? Ingreso { get; set; }

    public DateTime? Salida { get; set; }
}
