using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtBitacoraProyecto
{
    public int IdBitacora { get; set; }

    public DateTime? FechaInicial { get; set; }

    public int? IdArea { get; set; }

    public string? Proyecto { get; set; }

    public string? Detalle { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Responsable { get; set; }
}
