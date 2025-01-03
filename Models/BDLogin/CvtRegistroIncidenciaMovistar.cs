using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroIncidenciaMovistar
{
    public int IdIncidenciaInf { get; set; }

    public string? Nticket { get; set; }

    public DateTime? FechaCaida { get; set; }

    public string? Diagnostico { get; set; }

    public DateTime? FechaReparacion { get; set; }

    public string? ServicioAfectado { get; set; }

    public string? Comentarios { get; set; }
}
