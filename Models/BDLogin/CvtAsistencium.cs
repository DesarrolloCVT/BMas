using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAsistencium
{
    public int AsistenciaId { get; set; }

    public int IdArea { get; set; }

    public int IdLabores { get; set; }

    public string IdPersonal { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public TimeOnly HoraEntrada { get; set; }

    public TimeOnly? HoraSalida { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Comentario { get; set; }

    public int? MinutosTrabajados { get; set; }

    public string? Empresa { get; set; }

    public int? Turno { get; set; }

    public int? TotalMinTrabajados { get; set; }

    public decimal? TotalHorasTrabajadas { get; set; }

    public int? TotalPagoxHoras { get; set; }
}
