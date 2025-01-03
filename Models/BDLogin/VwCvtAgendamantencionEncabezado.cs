using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwCvtAgendamantencionEncabezado
{
    public int Folio { get; set; }

    public string TipoMantencion { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public DateTime FechaLimite { get; set; }

    public int CantHoras { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Datos { get; set; }
}
