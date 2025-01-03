using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwCvtMaquinasPartesComponente
{
    public int CodMaquina { get; set; }

    public string Maquina { get; set; } = null!;

    public int? CodParte { get; set; }

    public string? Parte { get; set; }

    public int? CodComponente { get; set; }

    public string? Componente { get; set; }
}
