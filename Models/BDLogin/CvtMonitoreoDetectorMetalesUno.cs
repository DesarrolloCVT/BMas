using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMonitoreoDetectorMetalesUno
{
    public int IdMonitoreoMetales { get; set; }

    public string Producto { get; set; } = null!;

    public TimeOnly HoraMonitoreo { get; set; }

    public short Fe15mm { get; set; }

    public short NoFe25mm { get; set; }

    public short AceroInox25mm { get; set; }

    public short EnciendeBaliza { get; set; }

    public short SuenaBaliza { get; set; }

    public short BrazoDeRechazo { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaMonitoreo { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public string? Observacion { get; set; }

    public int? IdEncargadaCalidad { get; set; }
}
