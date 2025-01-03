using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRotacionBodegaRecuperacion
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public string Tipo { get; set; } = null!;

    public string? OrigenDestino { get; set; }

    public string? ProcesoOrigen { get; set; }

    public string? Motivo { get; set; }

    public string GrupoProducto { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Costo { get; set; }
}
