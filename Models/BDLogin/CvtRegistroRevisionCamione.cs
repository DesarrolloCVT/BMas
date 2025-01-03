using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroRevisionCamione
{
    public int IdRevisionCamion { get; set; }

    public string UConductor { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public TimeOnly HoraCarga { get; set; }

    public short CamionLimpio { get; set; }

    public short ProductoBuenEstado { get; set; }

    public short EstadoCarpa { get; set; }

    public short EstadoLuces { get; set; }

    public short Externo { get; set; }

    public int? IdUsuario { get; set; }

    public int? TotalDoc { get; set; }

    public TimeOnly? HoraTerminoCarga { get; set; }

    public string? AccionCorrectiva { get; set; }

    public string? QuienCarga { get; set; }

    public short? LibreOlores { get; set; }
}
