using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwFilmConReserva
{
    public int Nbobina { get; set; }

    public string Operacion { get; set; } = null!;

    public int IdTransferenciaFilm { get; set; }

    public string? Estado { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public decimal? ReserveQuantity { get; set; }

    public decimal? PesoBruto { get; set; }
}
