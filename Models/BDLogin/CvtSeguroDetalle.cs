using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSeguroDetalle
{
    public int IdDetalleSeguro { get; set; }

    public string? Poliza { get; set; }

    public int? IdMateriaAsegurada { get; set; }

    public string? Descripcion { get; set; }

    public decimal? MontoAsegurado { get; set; }

    public string? Nfactura { get; set; }

    public string? CodProveedor { get; set; }
}
