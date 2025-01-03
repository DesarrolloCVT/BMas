using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwResumenTarea
{
    public int Ntarea { get; set; }

    public string Area { get; set; } = null!;

    public DateTime? Finicio { get; set; }

    public DateTime? Ftermino { get; set; }

    public int? Prioridad { get; set; }

    public int? Estado { get; set; }

    public string? Asunto { get; set; }

    public string? Detalle { get; set; }

    public int? PrcCumpli { get; set; }

    public string Asignado { get; set; } = null!;

    public int? IdAsignado { get; set; }

    public int IdTarea { get; set; }

    public string? Resolucion { get; set; }

    public int DptoId { get; set; }

    public string NomEstado { get; set; } = null!;

    public string? NomPrioridad { get; set; }

    public int? TiempoEstimado { get; set; }
}
