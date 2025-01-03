using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtOrderAsignacion
{
    public int OrderId { get; set; }

    public string Itemcode { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public int Cantidad { get; set; }
}
