using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSalasenvasado
{
    public int SalaId { get; set; }

    public int NumSala { get; set; }

    public int CantMaquinas { get; set; }

    public string? CantLinea { get; set; }
}
