using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCfgEstructuraLotesCab
{
    public int IdCodificacion { get; set; }

    public string NombreCodificacion { get; set; } = null!;

    public short Estado { get; set; }

    public string DescripcionAmplia { get; set; } = null!;

    public DateTime VigenciaIni { get; set; }

    public DateTime VigenciaFin { get; set; }

    public short NumVersion { get; set; }

    public string Separador { get; set; } = null!;

    public string CodEjemplo { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
