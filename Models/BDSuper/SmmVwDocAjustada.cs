using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwDocAjustada
{
    public int PreventaId { get; set; }

    public string Codproducto { get; set; } = null!;

    public string? NomProd { get; set; }

    public int? StockSala { get; set; }

    public int? CantUni { get; set; }

    public int? Faltante { get; set; }

    public DateTime? FechaAjuste { get; set; }

    public int? IdUserAjuste { get; set; }

    public string UsuarioSistema { get; set; } = null!;
}
