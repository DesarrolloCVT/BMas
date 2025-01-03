using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwCantPalletRecepCv201
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public int? Semana { get; set; }

    public string? Origen { get; set; }

    public string Grupo { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Producto { get; set; }

    public int? CantEtiquetas { get; set; }

    public int? CantProducto { get; set; }

    public decimal? Kilos { get; set; }
}
