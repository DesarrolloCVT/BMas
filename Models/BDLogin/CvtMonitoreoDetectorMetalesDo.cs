using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMonitoreoDetectorMetalesDo
{
    public int IdMonitoreoMetalesDos { get; set; }

    public string Producto { get; set; } = null!;

    public short DetectaFe25mm { get; set; }

    public short NoFe30mm { get; set; }

    public short Acero25mm { get; set; }

    public short EnciendeBaliza { get; set; }

    public short SuenaBaliza { get; set; }

    public short BrazoRechazo { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public TimeOnly HoraMonitoreo { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public string? Observacion { get; set; }

    public int? IdEncargadaCalidad { get; set; }
}
