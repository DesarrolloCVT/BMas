using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInventarioPalletVivosNoInventariado
{
    public string? BodegaSistema { get; set; }

    public int UbicacionSistema { get; set; }

    public string? RackSistema { get; set; }

    public string? Npallet { get; set; }

    public int? Estado { get; set; }

    public string? CodProductoSistema { get; set; }

    public string? ProductoSistema { get; set; }

    public string? LoteSistema { get; set; }

    public int CantidadSistema { get; set; }
}
