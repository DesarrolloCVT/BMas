using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtBulto
{
    public int IdBulto { get; set; }

    public string Descripcion { get; set; } = null!;

    public short Tipo { get; set; }

    public decimal Peso { get; set; }

    public decimal LargoMaximo { get; set; }

    public decimal AltoMaximo { get; set; }

    public decimal AnchoMaximo { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
