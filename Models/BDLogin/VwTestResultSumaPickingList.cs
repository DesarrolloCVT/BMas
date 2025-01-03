using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwTestResultSumaPickingList
{
    public int? CantOrigen { get; set; }

    public int? CantDest { get; set; }

    public int? NpalOrigen { get; set; }

    public int? NpalDestino { get; set; }

    public DateTime? FechaDestino { get; set; }

    public DateTime? FechaOrigen { get; set; }
}
