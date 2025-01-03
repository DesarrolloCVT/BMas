using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwListClienteInterno
{
    public string CodCliente { get; set; } = null!;

    public string? NomCliente { get; set; }

    public string? Run { get; set; }

    public string? Telefono { get; set; }

    public decimal? Saldo { get; set; }

    public decimal? Credito { get; set; }
}
