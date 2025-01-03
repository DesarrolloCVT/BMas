using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSolicitudCompra
{
    public int SolicitudCompraId { get; set; }

    public DateTime FechaNecesaria { get; set; }

    public string Proyecto { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string? MetodoPago { get; set; }

    public short? CondicionPago { get; set; }

    public int Estado { get; set; }

    public string TipoSolicitud { get; set; } = null!;
}
