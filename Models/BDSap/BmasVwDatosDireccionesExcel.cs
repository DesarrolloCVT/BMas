using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwDatosDireccionesExcel
{
    public string Codigo { get; set; } = null!;

    public string? Rut { get; set; }

    public string? RazonSocial { get; set; }

    public string Canal { get; set; } = null!;

    public string SubCanal { get; set; } = null!;

    public string? Vendedor { get; set; }

    public string? CodDireccion { get; set; }

    public string? Calle { get; set; }

    public string? Comuna { get; set; }

    public string? Nregion { get; set; }

    public string? Region { get; set; }

    public string? Zona { get; set; }

    public string? Transporte { get; set; }

    public string? Km { get; set; }
}
