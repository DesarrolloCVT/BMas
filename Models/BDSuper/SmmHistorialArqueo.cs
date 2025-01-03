using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmHistorialArqueo
{
    public int IdArqueo { get; set; }

    public DateTime FechaArqueo { get; set; }

    public int? Apertura { get; set; }

    public string? Tipo { get; set; }

    public string? Moneda { get; set; }

    public int? Efectivo { get; set; }

    public int? Tarjeta { get; set; }

    public int? Cheque { get; set; }

    public int? Transferencia { get; set; }

    public int? Total { get; set; }

    public string? Observacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FechaRegistroArqueo { get; set; }
}
