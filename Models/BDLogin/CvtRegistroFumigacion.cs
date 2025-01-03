using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroFumigacion
{
    public int IdFumigacion { get; set; }

    public int NumeroRecepcion { get; set; }

    public int TotalKilos { get; set; }

    public int Kilos { get; set; }

    public DateTime FechaFumigacion { get; set; }

    public string Certificado { get; set; } = null!;

    public int MetrosCubicos { get; set; }

    public int Dosis { get; set; }

    public int Temperatura { get; set; }

    public int Dias { get; set; }

    public int Horas { get; set; }

    public DateOnly? FechaVentilacion { get; set; }

    public string? Observaciones { get; set; }
}
