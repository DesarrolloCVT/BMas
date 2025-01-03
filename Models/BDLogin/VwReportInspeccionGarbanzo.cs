using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReportInspeccionGarbanzo
{
    public int IdInspeccionPtGarbanzo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Lote { get; set; } = null!;

    public string? AccionCorrectiva { get; set; }

    public int? IdVerificador { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GranosDanadosXinsectos { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal GranosPartidos { get; set; }

    public decimal GranosVerdosos { get; set; }

    public decimal MateriaExtrana { get; set; }

    public string? Observacion { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? ItemName { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? Verificador { get; set; }
}
