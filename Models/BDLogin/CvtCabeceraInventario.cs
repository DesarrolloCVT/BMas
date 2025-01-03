using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCabeceraInventario
{
    public int InventarioId { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public int IdUsuario { get; set; }

    public int IdUsuarioEncargado { get; set; }

    public int TipoInventario { get; set; }

    public int Estado { get; set; }

    public string? Comentarios { get; set; }
}
