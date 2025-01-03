using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwReporInspeccionArroz
{
    public int IdInspeccionPtArroz { get; set; }

    public string Lote { get; set; } = null!;

    public DateTime? FechaRegisro { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal Color { get; set; }

    public int Impurezas { get; set; }

    public int ArrozCascara { get; set; }

    public int SemillasObjetables { get; set; }

    public decimal GranosPartidos { get; set; }

    public decimal GranosYesados { get; set; }

    public decimal GranosDanados { get; set; }

    public string? Observacion { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? Verificador { get; set; }

    public int? IdVerificador { get; set; }
}
