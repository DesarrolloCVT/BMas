using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtListadoProductosPbi
{
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Grupo { get; set; }

    public string? Marca { get; set; }

    public string? Ean13 { get; set; }

    public string? Dun14 { get; set; }

    public string? ProvPredet { get; set; }

    public decimal? UndxCaja { get; set; }

    public decimal? Peso { get; set; }
}
