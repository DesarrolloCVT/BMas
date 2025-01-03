using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtLentejaDetalle
{
    public int IdInspeccionPtLentejaDetalle { get; set; }

    public int IdInspeccionPtLenteja { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal Impurezas { get; set; }

    public decimal MateriaExtranaAnimal { get; set; }

    public decimal MateriaExtrana { get; set; }

    public decimal GranosManchados { get; set; }

    public decimal GranosQuebrados { get; set; }

    public decimal GranosArrugados { get; set; }

    public string? Observacion { get; set; }
}
