using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDetencion
{
    public int DetencionId { get; set; }

    public int OfId { get; set; }

    public string Maquina { get; set; } = null!;

    public int CategoriaId { get; set; }

    public string MotivoCod { get; set; } = null!;

    public TimeOnly HrInicio { get; set; }

    public TimeOnly HrTermino { get; set; }

    public string? Comentario { get; set; }

    public int? TotalMinutosDetencion { get; set; }

    public int? Estado { get; set; }

    public int? UserConfirma { get; set; }

    public DateTime? FechConfirma { get; set; }

    public int? Maq { get; set; }

    public int? Parte { get; set; }

    public int? Componente { get; set; }
}
