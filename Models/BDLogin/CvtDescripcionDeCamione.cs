using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtDescripcionDeCamione
{
    public string Patente { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Año { get; set; } = null!;

    public string Propietario { get; set; } = null!;

    public int IdTipoCarroceria { get; set; }

    public int? KilometroRecorrido { get; set; }

    public int? CapacidadPallet { get; set; }

    public int? Tipo { get; set; }

    public string? NombreCorto { get; set; }
}
