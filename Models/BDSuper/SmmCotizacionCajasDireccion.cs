using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmCotizacionCajasDireccion
{
    public int IdDireccionCoti { get; set; }

    public int? IdCotizacion { get; set; }

    public string Direccion { get; set; } = null!;

    public int? CantCajas { get; set; }

    public string? TipoDireccion { get; set; }
}
