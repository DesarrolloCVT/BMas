using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAsignacionRutum
{
    public int AsignacionId { get; set; }

    public string CamionId { get; set; } = null!;

    public DateTime FechaEntrega { get; set; }

    public int Pedido { get; set; }

    public string Cliente { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CantidadPallet { get; set; }

    public int PesoPallet { get; set; }

    public int? PrioridadCarga { get; set; }

    public string? Carro { get; set; }

    public string? Chofer { get; set; }

    public int? CantPeonetas { get; set; }

    public TimeOnly? HoraSalida { get; set; }

    public string? Observacion { get; set; }
}
