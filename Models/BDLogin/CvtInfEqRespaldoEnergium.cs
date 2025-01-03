using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEqRespaldoEnergium
{
    public int Id { get; set; }

    public string? Dispositivo { get; set; }

    public int? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Capacidad { get; set; }

    public string? Entrada { get; set; }

    public string? Salida { get; set; }

    public string? Potencia { get; set; }

    public int? NumeroDeTomas { get; set; }

    public string? TiempoDeRespaldo { get; set; }

    public string? RackDeComunicaciones { get; set; }

    public string? CodAf { get; set; }

    public int? Estado { get; set; }
}
