using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroCargaCombustible
{
    public int IdLitrosPrecio { get; set; }

    public string Patente { get; set; } = null!;

    public int NumeroDocumento { get; set; }

    public DateOnly FechaDeCarga { get; set; }

    public decimal Litros { get; set; }

    public int? Odometro { get; set; }

    public decimal PrecioLitro { get; set; }

    public bool CargaEnPlanta { get; set; }

    public int? IdUsuarioCreador { get; set; }

    public int? Nestanque { get; set; }
}
