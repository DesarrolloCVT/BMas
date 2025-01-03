using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAsistenciaRelojControl
{
    public int IdAsistencia { get; set; }

    public string Rut { get; set; } = null!;

    public int? IdArea { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraTermino { get; set; }

    public TimeOnly Asistencia { get; set; }

    public TimeOnly? HeSalida { get; set; }
}
