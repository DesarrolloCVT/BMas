using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtPuestaEnMarchaMaquina
{
    public int IdMonPuestaMarchaMaq { get; set; }

    public int? Operador1 { get; set; }

    public int? Operador2 { get; set; }

    public string? LineaOperativa { get; set; }

    public string? Tto1 { get; set; }

    public string? Tto2 { get; set; }

    public string? TermoEnfardadora { get; set; }

    public int? IdControlEnvPt { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Tto1limPiezaCabezal { get; set; }

    public string? Tto2limPiezaCabezal { get; set; }

    public string? TermoEnfardadoraLimpiezaCab { get; set; }
}
