using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLaboresTurno
{
    public int IdLaborTurno { get; set; }

    public int Turno { get; set; }

    public DateOnly Fecha { get; set; }

    public int? LaboresVariasP { get; set; }

    public int? LaboresVariasC { get; set; }

    public int? GruerosP { get; set; }

    public int? GruerosC { get; set; }

    public int? ApoyoPickingP { get; set; }

    public int? ApoyoPickingC { get; set; }

    public int? OtrosP { get; set; }

    public int? OtrosC { get; set; }

    public int? InasistenciasP { get; set; }

    public int? InasistenciasC { get; set; }

    public int? AtrasosRetiroP { get; set; }

    public int? AtrasosRetiroC { get; set; }

    public string? ObservacionDotacion { get; set; }

    public int? CamionesTurnoAnterior { get; set; }

    public int? CamionesLlegadosTurno { get; set; }

    public int? CamionesDescargados { get; set; }

    public int? CamionesPendientes { get; set; }

    public int? BajadaPedidos { get; set; }

    public int? PedidosPreparadosAp { get; set; }

    public int? PedidosPreparadosPicking { get; set; }

    public int? PedidosPreparadosOtros { get; set; }

    public string? ObservacionPedidos { get; set; }

    public int? CamionesCargadosPl { get; set; }

    public int? CamionesCargadosExt { get; set; }

    public string? ObservacionCargaCamiones { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? UsuarioRegistro { get; set; }
}
