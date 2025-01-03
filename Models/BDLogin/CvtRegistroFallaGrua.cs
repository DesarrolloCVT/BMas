using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroFallaGrua
{
    public int RfgId { get; set; }

    public string EmpresaReclamo { get; set; } = null!;

    public int GruaId { get; set; }

    public int TfallaId { get; set; }

    public DateTime FechaFalla { get; set; }

    public int ChoferMomentoFalla { get; set; }

    public int UsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaReparacion { get; set; }

    public int? UsuarioCierre { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Comentario { get; set; }

    public string? Resolucion { get; set; }

    public int EstadoGrua { get; set; }

    public decimal Horometro { get; set; }
}
