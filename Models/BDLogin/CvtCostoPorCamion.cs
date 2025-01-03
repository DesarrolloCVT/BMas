using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCostoPorCamion
{
    public int IdCostoCamion { get; set; }

    public string Patente { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public int IdGastoCamion { get; set; }

    public int? Monto { get; set; }

    public string? Comentario { get; set; }

    public string? TipoDocumento { get; set; }

    public int? FolioDocumento { get; set; }

    public string? Nrendicion { get; set; }
}
