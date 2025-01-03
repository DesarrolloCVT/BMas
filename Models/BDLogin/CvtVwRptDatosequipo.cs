using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRptDatosequipo
{
    public string? UsuarioEquipo { get; set; }

    public string? Dispositivo { get; set; }

    public string? NombreEquipo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Ram { get; set; }

    public string? Procesador { get; set; }

    public string? SistemaOperativo { get; set; }

    public string? CodAf { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdMantInfEnc { get; set; }

    public DateTime FechaMantencion { get; set; }

    public string TipoMantencion { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string? Falla { get; set; }

    public string? Causa { get; set; }

    public string? Solucion { get; set; }

    public string? Observacion { get; set; }

    public string CodActivo { get; set; } = null!;
}
