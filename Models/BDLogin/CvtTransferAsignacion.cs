using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransferAsignacion
{
    public int TransferId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public int? Recepcion { get; set; }
}
