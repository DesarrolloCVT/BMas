using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCamionCargaDet
{
    public int IdCamionCarga { get; set; }

    public int IdContenedorCarga { get; set; }

    public short UbicacionEnCamion { get; set; }

    public string ObsCarga { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
