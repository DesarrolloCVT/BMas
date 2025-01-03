using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmVwInfoClientePreventum
{
    public string CodCliente { get; set; } = null!;

    public string? NombreCliente { get; set; }

    public string? RutCliente { get; set; }

    public string? Telefono { get; set; }

    public string? EMail { get; set; }

    public short? CodGrupCliente { get; set; }
}
