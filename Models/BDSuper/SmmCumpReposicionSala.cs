using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmCumpReposicionSala
{
    public int IdCumplimiento { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdNomVerificado { get; set; }

    public int? IdVerificador { get; set; }

    public string? CodProducto { get; set; }

    public string? CodBarra { get; set; }

    public string? DispoProducto { get; set; }

    public string? Limpieza { get; set; }

    public string? FeFo { get; set; }

    public string? Fleje { get; set; }

    public DateTime? FechaVencProd { get; set; }

    public int? PrcCumpl { get; set; }
}
