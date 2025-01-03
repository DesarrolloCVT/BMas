using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmPreventum
{
    public int PreventaId { get; set; }

    public string? CodigoCliente { get; set; }

    public string? DireccionFact { get; set; }

    public string? DireccionEnvio { get; set; }

    public string? RunCliente { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? TipoVenta { get; set; }

    public int? GrupoCliente { get; set; }

    public int? IdUsuario { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? TotalPreventa { get; set; }
}
