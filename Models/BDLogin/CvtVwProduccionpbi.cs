using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwProduccionpbi
{
    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? Horas { get; set; }

    public int? Of { get; set; }

    public string Grupo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Sala { get; set; }

    public string? Linea { get; set; }

    public string? GolpesMin { get; set; }

    public string Operador { get; set; } = null!;

    public string? OrigenPrimario { get; set; }

    public int? ContenedorasControlEnvasado { get; set; }

    public decimal? ProducidoOf { get; set; }

    public int? ReprocesoKilos { get; set; }

    public int? BarridoKilos { get; set; }

    public int? MermaContenedoras { get; set; }

    public decimal RechazadoKilosCalidad { get; set; }
}
