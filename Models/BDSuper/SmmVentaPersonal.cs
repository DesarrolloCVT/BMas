using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVentaPersonal
{
    public int IdVenta { get; set; }

    public string? CodCliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? RunCliente { get; set; }

    public string? Telefono { get; set; }

    public DateTime? FechaCompra { get; set; }

    public int? MesCompra { get; set; }

    public int? DiaCompra { get; set; }

    public int? TotalCompra { get; set; }

    public int? IdUsuario { get; set; }
}
