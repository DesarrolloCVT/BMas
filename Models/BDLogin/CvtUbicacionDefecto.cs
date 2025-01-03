using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtUbicacionDefecto
{
    public long SiteId { get; set; }

    public byte Tipo { get; set; }

    public long LayoutId { get; set; }

    public DateTime FechaCreacion { get; set; }
}
