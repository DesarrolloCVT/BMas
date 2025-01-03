using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAgendamiento
{
    public int AgendamientoId { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Termino { get; set; }

    public string Asunto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string ProductoCode { get; set; } = null!;

    public int Estado { get; set; }

    public int RecursoId { get; set; }

    public int? OfDocEntry { get; set; }

    public DateTime? FechaLimite { get; set; }

    public short? TipoProduccion { get; set; }

    public decimal? CantidadPlanificada { get; set; }

    public decimal? CantidadProducida { get; set; }

    public short? EstadoOf { get; set; }

    public short? Turno { get; set; }

    public int? Semana { get; set; }
}
