using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class LogSistemaCvt
{
    public int LogId { get; set; }

    public string Entidad { get; set; } = null!;

    public int EntidadId { get; set; }

    public DateTime Fecha { get; set; }

    public string ValorAntiguo { get; set; } = null!;

    public string ValorNuevo { get; set; } = null!;

    public string UsuarioId { get; set; } = null!;
}
