using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReportInspeccionPorotoNegro
{
    public int IdIspeccionPtPorotoNegro { get; set; }

    public string Lote { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int? IdVerificador { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GanosDañadosXinsecto { get; set; }

    public decimal GranosManchado { get; set; }

    public decimal GranosPartidos { get; set; }

    public int GranosColor { get; set; }

    public decimal MateriaExtraña { get; set; }

    public string? Observacion { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? CardName { get; set; }

    public string? ItemName { get; set; }

    public string? Verificador { get; set; }
}
