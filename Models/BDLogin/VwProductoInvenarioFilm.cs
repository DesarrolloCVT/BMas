using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwProductoInvenarioFilm
{
    public int Nbobina { get; set; }

    public int? IdBodega { get; set; }

    public string? LoteInterno { get; set; }

    public string? Producto { get; set; }

    public string? ItemName { get; set; }
}
