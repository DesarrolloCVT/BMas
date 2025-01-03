using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTratoPorArea
{
    public int IdArea { get; set; }

    public string NombreArea { get; set; } = null!;

    public int MontoTrato { get; set; }

    public int MontoHora { get; set; }

    public int MontoMin { get; set; }

    public int Dia { get; set; }

    public int IdTrato { get; set; }
}
