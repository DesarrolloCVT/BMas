using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmNotaCreditoDatoCliente
{
    public int IdNotaCredito { get; set; }

    public int? FolioDocumento { get; set; }

    public string? TipoDocumento { get; set; }

    public string? CodCliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? DireccionDespacho { get; set; }

    public string? DireccionFacturacion { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public DateTime? FechaCreacionRegistoNota { get; set; }

    public int? TipoNc { get; set; }
}
