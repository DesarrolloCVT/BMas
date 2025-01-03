using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroVerificacionBolsa
{
    public int IdVerificacionBolsas { get; set; }

    public int Of { get; set; }

    public DateTime Fecha { get; set; }

    public int IdPersonal { get; set; }

    public int Linea { get; set; }

    public TimeOnly? ColacionInicio { get; set; }

    public TimeOnly? ColacionTermino { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaElaboracion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int? IdVerificador { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaVerificacion { get; set; }
}
