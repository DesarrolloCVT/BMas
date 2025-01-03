using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReportInspeccionArveja
{
    public int IdInspeccionPtArveja { get; set; }

    public string? Producto { get; set; }

    public string Lote { get; set; } = null!;

    public string? Proveedor { get; set; }

    public DateTime FechaRegisro { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int? IdVerificador { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GranosDanadosXinsectos { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal? GranosAmarillos { get; set; }

    public decimal GranosEnteros { get; set; }

    public decimal? MateriaExtrana { get; set; }

    public string? Observacion { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? Verificador { get; set; }
}
