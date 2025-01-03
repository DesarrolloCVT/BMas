using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReportInspeccionLenteja
{
    public int IdInspeccionPtLenteja { get; set; }

    public string Lote { get; set; } = null!;

    public DateTime Fecharegistro { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int? IdVerificador { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal Impurezas { get; set; }

    public decimal MateriaExtranaAnimal { get; set; }

    public decimal MateriaExtrana { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal GranosQuebrados { get; set; }

    public decimal GranosArrugados { get; set; }

    public string? Observacion { get; set; }

    public string? CardName { get; set; }

    public string? ItemName { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? Verificador { get; set; }
}
