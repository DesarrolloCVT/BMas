using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwTranferSaplotesFilm
{
    public int IdTransferenciaFilm { get; set; }

    public string? LoteInterno { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Producto { get; set; }

    public string? ItemName { get; set; }
}
