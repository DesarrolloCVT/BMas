using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtChecklistGrua
{
    public int RegistroChecklistGruaId { get; set; }

    public string UsuarioResponsable { get; set; } = null!;

    public string NumeroGrua { get; set; } = null!;

    public string AreaTrabajo { get; set; } = null!;

    public string TipoMaquina { get; set; } = null!;

    public string Turno { get; set; } = null!;

    public string Horometro { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string EstadoLuces { get; set; } = null!;

    public string EstadoMotor { get; set; } = null!;

    public string FugaAguaAceite { get; set; } = null!;

    public string EstadoDireccion { get; set; } = null!;

    public string EstadoTransmision { get; set; } = null!;

    public string EscaleraAccesoPasamanos { get; set; } = null!;

    public string EstadoBocina { get; set; } = null!;

    public string AlarmaRetroceso { get; set; } = null!;

    public string EspejoRetrovisor { get; set; } = null!;

    public string EstadoTableroDatos { get; set; } = null!;

    public string EstadoExtintor { get; set; } = null!;

    public string EstadoBateria { get; set; } = null!;

    public string EstadoAsiento { get; set; } = null!;

    public string CinturonSeguridad { get; set; } = null!;

    public string BalizaPertiga { get; set; } = null!;

    public string EstadoNeumaticos { get; set; } = null!;

    public string LlantasTuercas { get; set; } = null!;

    public string CadenasTorre { get; set; } = null!;

    public string UnasHorquilla { get; set; } = null!;

    public string SoporteCilindro { get; set; } = null!;

    public string FlexiblePoleaRodamiento { get; set; } = null!;

    public string SeguroUnaHorquilla { get; set; } = null!;

    public string PuntoBloqueo { get; set; } = null!;

    public string? Observaciones { get; set; }
}
