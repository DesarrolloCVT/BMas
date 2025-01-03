using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAcuerdoComercial
{
    public int IdAcuerdoComercial { get; set; }

    public string? CodProveedor { get; set; }

    public short? ListaDePrecio { get; set; }

    public short? CompraSemanal { get; set; }

    public int? TipoAcuerdo { get; set; }

    public decimal? DescuestoProveedor { get; set; }
}
