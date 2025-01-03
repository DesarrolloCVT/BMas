using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTicket
{
    public int IdTicket { get; set; }

    public int IdCategoriaTicket { get; set; }

    public int? IdTipoProblema { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Descripcion { get; set; }

    public int? IdArea { get; set; }

    public int? IdTomaTicket { get; set; }

    public DateTime? FechaTomaTicket { get; set; }

    public int? Prioridad { get; set; }
}
