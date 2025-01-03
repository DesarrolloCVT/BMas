using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class LibroHonorariosSy
{
    public string Tipo { get; set; } = null!;

    public int? Docum { get; set; }

    public int? Numero { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Rut { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Bruto { get; set; }

    public decimal? W1 { get; set; }

    public decimal? Total { get; set; }

    public string? Clasif { get; set; }

    public DateTime Fechacon { get; set; }

    public int DocEntry { get; set; }

    public int? Bplid { get; set; }
}
