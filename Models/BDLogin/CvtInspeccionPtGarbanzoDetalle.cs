using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtGarbanzoDetalle
{
    public int IdInspeccionGarbanzoDetalle { get; set; }

    public int IdInspeccionPtGarbanzo { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GranosDanadosXinsectos { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal GranosPartidos { get; set; }

    public decimal GranosVerdosos { get; set; }

    public decimal MateriaExtrana { get; set; }

    public string? Observacion { get; set; }
}
