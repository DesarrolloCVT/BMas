using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwDatosProveedore
{
    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? Rut { get; set; }

    public string? Direccion { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? EMail { get; set; }

    public string PymntGroup { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? EMailL { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Cellolar { get; set; }
}
