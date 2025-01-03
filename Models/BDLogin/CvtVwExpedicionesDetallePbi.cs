using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwExpedicionesDetallePbi
{
    public string IdBulto { get; set; } = null!;

    public string? CodProducto { get; set; }

    public string? Lote { get; set; }

    public string? Descripción { get; set; }

    public int? TotalEnvases { get; set; }
}
