using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Certificado
{
    public short? Ano { get; set; }

    public string Mes { get; set; } = null!;

    public string? Rut { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Bruto { get; set; }

    public decimal? Retencion { get; set; }

    public decimal? Total { get; set; }

    public decimal? Certif { get; set; }

    public int UBplid { get; set; }
}
