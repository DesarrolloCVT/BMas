using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwExpedicionFilmPbi
{
    public int FolioExp { get; set; }

    public string? Bodega { get; set; }

    public string Usuario { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public int? NDocumento { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Nota { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaInicio { get; set; }

    public int? Horas { get; set; }

    public string? Motivo { get; set; }

    public int? Minutos { get; set; }
}
