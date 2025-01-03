using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRechazosDetertorMetale
{
    public int Id { get; set; }

    public int Fecha { get; set; }

    public string CodProducto { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public int Cantidad { get; set; }

    public string Proveedor { get; set; } = null!;

    public string Elemento { get; set; } = null!;

    public int Origen { get; set; }

    public string? AccionCorrectiva { get; set; }
}
