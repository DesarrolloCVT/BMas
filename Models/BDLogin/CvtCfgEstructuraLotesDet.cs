using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCfgEstructuraLotesDet
{
    public int IdCodificacion { get; set; }

    public int IdCodDetPosicion { get; set; }

    public short Orden { get; set; }

    public string NombreCampo { get; set; } = null!;

    public short LargoPosiciones { get; set; }

    public short TipoDato { get; set; }

    public short UsaDiccionario { get; set; }

    public short IdDiccionario { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
