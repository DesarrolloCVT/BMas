using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRecursoMantencion
{
    public int RecursoId { get; set; }

    public string RecursoNombre { get; set; } = null!;

    public bool Externo { get; set; }
}
