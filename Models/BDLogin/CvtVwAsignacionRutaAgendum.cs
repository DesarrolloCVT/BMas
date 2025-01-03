using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwAsignacionRutaAgendum
{
    public string CamionId { get; set; } = null!;

    public DateTime FechaEntrega { get; set; }

    public int Pedido { get; set; }

    public int DocNum { get; set; }

    public string Cliente { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CantidadPallet { get; set; }

    public int PesoPallet { get; set; }

    public short? UHoraEntrega { get; set; }

    public string? UAgendamiento { get; set; }

    public short? Hora { get; set; }

    public short? Minuto { get; set; }

    public DateTime? FechaEntregaAgendada { get; set; }

    public string? Descripcion { get; set; }

    public string? DocStatus { get; set; }

    public string? Camion { get; set; }

    public string? Horario { get; set; }
}
