using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRendicionCostosDetalle
{
    public int IdDetRendi { get; set; }

    public int? IdRendi { get; set; }

    public DateTime? FechaRend { get; set; }

    public int? Comprobante { get; set; }

    public string? TipoDoc { get; set; }

    public string? ConceptoIngreso { get; set; }

    public int? OrdenCompra { get; set; }

    public int? Monto { get; set; }

    public string? Observacion { get; set; }

    public string? RutaDoc { get; set; }

    public string? ExtencionDoc { get; set; }

    public string? NombreDoc { get; set; }
}
