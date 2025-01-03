using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwInformeValorizadoTratosxAsistencium
{
    public string Area { get; set; } = null!;

    public string Rut { get; set; } = null!;

    public string? Trabajador { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public TimeOnly Asistencia { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraTermino { get; set; }

    public int? HrsTurno { get; set; }

    public int? ValorPagar { get; set; }
}
