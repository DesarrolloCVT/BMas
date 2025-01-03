using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwExcelResumenTicket
{
    public int IdTicket { get; set; }

    public string Estado { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string? Categoria { get; set; }

    public string? TipoProblema { get; set; }

    public string UsuarioSolicitante { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaTomaTicket { get; set; }

    public string? EncargadoTicket { get; set; }

    public DateTime? FechaTermino { get; set; }
}
