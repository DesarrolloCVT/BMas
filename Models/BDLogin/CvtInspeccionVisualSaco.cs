using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionVisualSaco
{
    public int IdInspeccionSacos { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string ItemCode { get; set; } = null!;

    public TimeOnly Hora { get; set; }

    public string LoteMp { get; set; } = null!;

    public string LotePt { get; set; } = null!;

    public string? CardCode { get; set; }

    public decimal Humedad { get; set; }

    public short? MateriaExtranaAnimal { get; set; }

    public short? MateriaExtrana { get; set; }

    public int IdUsuario { get; set; }

    public short EstadoSaco { get; set; }

    public string? AccionCorrectiva { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public bool? ProvMixto { get; set; }

    public string? ProveedoresMixtos { get; set; }

    public int? IdEncargadaCalidad { get; set; }

    public int? NaccionCorrectiva { get; set; }
}
