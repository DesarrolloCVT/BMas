using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroCargaCombustibleJefatura
{
    public int IdCarga { get; set; }

    public string? Patente { get; set; }

    public DateTime? FechaCarga { get; set; }

    public decimal? Litros { get; set; }

    public int? IdUsuarioCreador { get; set; }
}
