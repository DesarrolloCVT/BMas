using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class MmetroLogUltimoPrecioCompra
{
    public int IdRegistroPrecio { get; set; }

    public string? Producto { get; set; }

    public int Precio { get; set; }

    public DateTime FechaRegistro { get; set; }
}
