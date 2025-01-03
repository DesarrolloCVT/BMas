using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCamionCarga
{
    public int IdCamionCarga { get; set; }

    public string Patente { get; set; } = null!;

    public DateTime FechaDespacho { get; set; }

    public short UsaCarro { get; set; }

    public string PatenteCarro { get; set; } = null!;

    public short IndVuelta { get; set; }

    public string DescripcionRuta { get; set; } = null!;

    public string ObsEntrega { get; set; } = null!;

    public string Obs1 { get; set; } = null!;

    public string Obs2 { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public short CantPeonetas { get; set; }
}
