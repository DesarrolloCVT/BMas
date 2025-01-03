using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCfgEstructuraLotesDatum
{
    public int IdDiccionario { get; set; }

    public string DescDiccionario { get; set; } = null!;

    public int IdCodItemDetalle { get; set; }

    public string CodItemDetalle { get; set; } = null!;

    public string DescItemDetalle { get; set; } = null!;

    public string RefTablaSap { get; set; } = null!;

    public string RefCampoSap { get; set; } = null!;

    public string RefValorCampoSap { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
