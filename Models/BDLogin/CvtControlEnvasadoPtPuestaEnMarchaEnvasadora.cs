using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtPuestaEnMarchaEnvasadora
{
    public int IdPuestaEnMarchaEnvasadora { get; set; }

    public int? IdControlEnvPt { get; set; }

    public short? LimpiezaCorreasTraccionadoras { get; set; }

    public short? LimpiezaHombrosFormadores { get; set; }

    public short? LimpiezaRodillosTraccionadores { get; set; }

    public short? LimpiezaMordazas { get; set; }

    public short? EstadoVasosDosificadores { get; set; }

    public short? LimpiezaCintaTransportadora { get; set; }

    public short? EstadoGomaApoyoVertHor { get; set; }

    public short? EstadoConexionComponentesNeumaticos { get; set; }

    public string? EquipoMonitoreo { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
