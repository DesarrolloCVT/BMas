using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwDetalleCliente
{
    public int IdPreventa { get; set; }

    public string? CodigoCliente { get; set; }

    public string? RunCliente { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? TipoVenta { get; set; }

    public string GroupName { get; set; } = null!;

    public string? DireccionEnvio { get; set; }

    public string? DireccionFact { get; set; }

    public short GroupCode { get; set; }
}
