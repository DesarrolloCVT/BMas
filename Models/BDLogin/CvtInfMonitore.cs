using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfMonitore
{
    public int IdInvMonitores { get; set; }

    public string? CodActivo { get; set; }

    public string? IdUsuario { get; set; }

    public int? IdArea { get; set; }

    public int? IdMarca { get; set; }

    public string? Modelo { get; set; }

    public decimal? Pulgadas { get; set; }

    public string? Resolucion { get; set; }

    public string? Condicion { get; set; }

    public string? Conexion { get; set; }

    public string? Comentarios { get; set; }

    public int? Estado { get; set; }
}
