using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtArrozDetalle
{
    public int IdDetalleInspeccionPtArroz { get; set; }

    public int IdInspeccionPtArroz { get; set; }

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
}
