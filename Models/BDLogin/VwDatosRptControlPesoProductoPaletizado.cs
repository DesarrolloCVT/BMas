using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDatosRptControlPesoProductoPaletizado
{
    public string? CodProducto { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? Lote { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Turno { get; set; }

    public string? StaffName { get; set; }

    public TimeOnly? HoraPeso { get; set; }

    public int? Npallet { get; set; }

    public TimeOnly? HoraTermPallet { get; set; }

    public decimal? PesoPallet { get; set; }

    public int? Sscc { get; set; }

    public string? AccionCorrectiva { get; set; }

    public string? Observaciones { get; set; }
}
