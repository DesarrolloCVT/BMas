using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlHigene
{
    public int IdControlHigene { get; set; }

    public DateTime Fecha { get; set; }

    public int IdMonitor { get; set; }

    public int IdArea { get; set; }

    public string TipoContrato { get; set; } = null!;

    public int IdPersona { get; set; }

    public int LimpiezaUniforme { get; set; }

    public int AfeitadoPeloCorto { get; set; }

    public int Uñas { get; set; }

    public int Joyas { get; set; }

    public int Higene { get; set; }

    public string? AccionCorrectiva { get; set; }

    public int? Promedio { get; set; }

    public int? PorcentajeCumplimiento { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? EstadoUniforme { get; set; }

    public int? HeridaExpuesta { get; set; }
}
