using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPermisoTrabajoSeguro
{
    public int IdPts { get; set; }

    public string? Empresa { get; set; }

    public string? AreaTrabajo { get; set; }

    public string? Tarea { get; set; }

    public string? Responsable { get; set; }

    public string? TipoTrabajo { get; set; }

    public int? TotalAst { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? DiasDuracion { get; set; }

    public string? Estado { get; set; }

    public string? Comentario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioRegistra { get; set; }
}
