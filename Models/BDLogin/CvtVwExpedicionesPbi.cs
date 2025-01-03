using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwExpedicionesPbi
{
    public string? Bodega { get; set; }

    public int Folio { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string? TipoExpedicion { get; set; }

    public string? Sector { get; set; }

    public int? NumDocum { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Nota { get; set; }

    public string? Usuario { get; set; }

    public string? Estado { get; set; }

    public string? Motivo { get; set; }

    public DateTime? FechaInicio { get; set; }

    public int? Incluidos { get; set; }

    public int? Confirmados { get; set; }

    public int? Horas { get; set; }

    public int? Minutos { get; set; }
}
