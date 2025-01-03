using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwTranferenciaSapFilm
{
    public int IdTransferenciaFilm { get; set; }

    public string? Producto { get; set; }

    public string? ItemName { get; set; }

    public decimal? Cantidad { get; set; }
}
