using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmDatoClientesNotacredito
{
    public int? FolioNum { get; set; }

    public string? DocSubType { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? DireccionFacturacion { get; set; }

    public string? DireccionDespacho { get; set; }

    public DateTime? DocDate { get; set; }

    public int DocEntry { get; set; }
}
