using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtProcesoAdicionalDetalle
{
    public int DetalleProcesoId { get; set; }

    public int ProcesoAdicionalId { get; set; }

    public int PackageId { get; set; }

    public int Cantidad { get; set; }

    public DateTime Fecha { get; set; }
}
