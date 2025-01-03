using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class FallasGruaPbi
{
    public string Tipo { get; set; } = null!;

    public string Proveedor { get; set; } = null!;

    public string GruaNumero { get; set; } = null!;

    public string? ChoferMomentoFalla { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaReparacion { get; set; }

    public DateTime FechaFalla { get; set; }

    public string EstadoGrua { get; set; } = null!;

    public string EmpresaReclamo { get; set; } = null!;

    public string? Comentario { get; set; }

    public decimal Horometro { get; set; }

    public string? Resolucion { get; set; }

    public int RfgId { get; set; }

    public string? UsuarioCierre { get; set; }

    public string? UsuarioCreacion { get; set; }

    public string TipoFalla { get; set; } = null!;
}
