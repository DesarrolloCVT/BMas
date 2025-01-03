using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwBobinasRegistradasEnvasado
{
    public DateOnly? FechaRegistro { get; set; }

    public int? Of { get; set; }

    public string Operador { get; set; } = null!;

    public int? Turno { get; set; }

    public int? Sala { get; set; }

    public string? Linea { get; set; }

    public string? MateriaPrima { get; set; }

    public string? LoteMp { get; set; }

    public int? Nbobina { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string? MotivoMerma { get; set; }

    public string? OrigenMerma { get; set; }

    public string? Lote { get; set; }

    public decimal? Cantidad { get; set; }

    public string TipoFilm { get; set; } = null!;
}
