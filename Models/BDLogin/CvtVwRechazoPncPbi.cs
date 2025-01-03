using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRechazoPncPbi
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

    public string? UAbocador { get; set; }

    public string? UOperador { get; set; }

    public short? UNumSala { get; set; }

    public string? ULinea { get; set; }

    public string? SubCategoria { get; set; }

    public decimal? Peso { get; set; }

    public decimal? UndxCaja { get; set; }

    public int? UCantPtreal { get; set; }

    public string? ProdName { get; set; }
}
