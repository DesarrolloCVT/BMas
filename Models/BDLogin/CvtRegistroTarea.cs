using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroTarea
{
    public int IdTarea { get; set; }

    public int DptoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? Prioridad { get; set; }

    public int? Estado { get; set; }

    public string? Asunto { get; set; }

    public string? Detalle { get; set; }

    public int? PrcCumpli { get; set; }

    public int? IdAsignado { get; set; }

    public int? IdCreador { get; set; }

    public string? Resolucion { get; set; }

    public int? TiempoEstimado { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaTerminoReal { get; set; }

    public TimeOnly? HoraInicioReal { get; set; }

    public TimeOnly? HoraTeminoReal { get; set; }
}
