using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtContenedore
{
    public int IdContenedor { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Peso { get; set; }

    public decimal Alto { get; set; }

    public decimal Ancho { get; set; }

    public decimal Largo { get; set; }

    public string Marca { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Material { get; set; } = null!;

    public short Tipo { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
