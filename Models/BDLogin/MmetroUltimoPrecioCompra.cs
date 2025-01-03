using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class MmetroUltimoPrecioCompra
{
    public int IdRegistroPrecio { get; set; }

    public string? ItemCode { get; set; }

    public int UltimoPrecioCompra { get; set; }

    public decimal Porcentaje { get; set; }

    public DateTime FechaUltimoRegistro { get; set; }

    public string? Competencia { get; set; }

    public string? ProductoNoRegistrado { get; set; }

    public string? Proveedor { get; set; }
}
