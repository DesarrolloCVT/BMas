using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroRechazoProductoNoConforme
{
    public int IdRechazoPt { get; set; }

    public int? Lote { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Producto { get; set; }

    public decimal? CantContenedoras { get; set; }

    public string? TipoNc { get; set; }

    public string? Especificacion { get; set; }

    public int? IdSubcategoriaNc { get; set; }

    public string? MotivoRechazo { get; set; }

    public string? DestinoRechazo { get; set; }

    public TimeOnly? HoraRechazo { get; set; }
}
