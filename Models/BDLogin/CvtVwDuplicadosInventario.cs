using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDuplicadosInventario
{
    public int InventarioId { get; set; }

    public int? Cantidad { get; set; }

    public int Npallet { get; set; }
}
