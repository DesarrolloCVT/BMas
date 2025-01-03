using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VistaInventarioOctubre2017
{
    public int Correlativo { get; set; }

    public int? Inventario { get; set; }

    public string? ConteoCod { get; set; }

    public string? Codigo { get; set; }

    public string? Producto { get; set; }

    public int? Entidad { get; set; }

    public string? Usuario { get; set; }

    public int? Id { get; set; }

    public int? Conteo { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Numserie { get; set; }

    public byte Estado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string? Contenedor { get; set; }

    public string FechaElab { get; set; } = null!;

    public string FechaVcto { get; set; } = null!;

    public string IdUbicCod { get; set; } = null!;
}
