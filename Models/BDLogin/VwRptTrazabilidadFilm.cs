using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwRptTrazabilidadFilm
{
    public DateTime? Fecha { get; set; }

    public int? Nbobina { get; set; }

    public string Entidad { get; set; } = null!;

    public string? Operacion { get; set; }

    public int? Identidad { get; set; }

    public int? Ndocumento { get; set; }

    public string? Tipo { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoNeto { get; set; }

    public string? Usuario { get; set; }

    public string? Info { get; set; }
}
