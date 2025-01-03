using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRecepcionPbi
{
    public string? Bodega { get; set; }

    public int Folio { get; set; }

    public string Proveedor { get; set; } = null!;

    public string? TipoDocSap { get; set; }

    public int? NumSap { get; set; }

    public string? TipoRecepcion { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public int NDocumento { get; set; }

    public string? TipoDescarga { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string? Estado { get; set; }

    public string? Usuario { get; set; }

    public int? GrueroAsignado { get; set; }

    public int? Minutos { get; set; }
}
