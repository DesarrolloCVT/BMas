using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtAzucarDetalle
{
    public int IdInspeccionPtAzucarDetalle { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public short Impuresas { get; set; }

    public short MateriaExtranaAnimal { get; set; }

    public short MateriaExtrana { get; set; }

    public int IdInspeccionPtAzucar { get; set; }

    public string? Observacion { get; set; }
}
