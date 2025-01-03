using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanillaInsumo
{
    public int PinsumosId { get; set; }

    public int UsuarioSistema { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public int Mes { get; set; }

    public string Area { get; set; } = null!;

    public int Ano { get; set; }
}
