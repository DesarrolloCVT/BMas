using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroRevisionCamionFactura
{
    public int IdRevisionCamionFactura { get; set; }

    public int Folio { get; set; }

    public int IdRevisionCamion { get; set; }

    public string? PatenteSistema { get; set; }

    public string? Destino { get; set; }

    public string? Cliente { get; set; }
}
