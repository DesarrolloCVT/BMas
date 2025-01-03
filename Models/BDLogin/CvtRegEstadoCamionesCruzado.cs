using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegEstadoCamionesCruzado
{
    public int IdRegRecepcionCamiones { get; set; }

    public DateTime? Fercha { get; set; }

    public string? Referencia { get; set; }

    public int? Informados { get; set; }

    public int? Cruzados { get; set; }

    public int? Liberados { get; set; }

    public int? Llegados { get; set; }

    public int? Recepcionados { get; set; }

    public int? Oc { get; set; }

    public int? Ncamiones { get; set; }

    public string? Producto { get; set; }

    public string? Proveedor { get; set; }
}
