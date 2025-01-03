using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionPtPorotoNegroDetalle
{
    public int IdInspeccionPorotoNegroDetalle { get; set; }

    public int IdIspeccionPtPorotoNegro { get; set; }

    public int Linea { get; set; }

    public TimeOnly HoraAnalisis { get; set; }

    public decimal GanosDañadosXinsecto { get; set; }

    public decimal GranosManchado { get; set; }

    public decimal GranosPartidos { get; set; }

    public int GranosColor { get; set; }

    public decimal MateriaExtraña { get; set; }

    public string? Observacion { get; set; }
}
