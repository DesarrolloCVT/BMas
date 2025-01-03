using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMotivoDentecion
{
    public string MotivoCod { get; set; } = null!;

    public string DetencionMotivo { get; set; } = null!;

    public int CategoriaId { get; set; }

    public int? Estado { get; set; }

    public int? Tipo { get; set; }

    public int? TiempoEstimado { get; set; }
}
