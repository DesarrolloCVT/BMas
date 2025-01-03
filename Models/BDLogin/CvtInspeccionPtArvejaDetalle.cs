using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtArvejaDetalle
{
    public int IdInspeccionArvejaDetalle { get; set; }

    public int IdInspeccionPtArveja { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GranosDanadosXinsectos { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal GranosEnteros { get; set; }

    public decimal? ContratePorColor { get; set; }

    public decimal? MateriaExtrana { get; set; }

    public string? Observacion { get; set; }
}
