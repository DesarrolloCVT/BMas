using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwReportInspeccionAzucar
{
    public int IdInspeccionPtAzucar { get; set; }

    public string Lote { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int? IdVerificador { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public short Impuresas { get; set; }

    public short MateriaExtranaAnimal { get; set; }

    public short MateriaExtrana { get; set; }

    public string? Observacion { get; set; }

    public string EncargadoCalidad { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? CardName { get; set; }

    public string? Verificador { get; set; }
}
