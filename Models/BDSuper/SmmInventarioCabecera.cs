using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmInventarioCabecera
{
    public int InventarioId { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public int IdUsuario { get; set; }

    public int IdUsuarioEncargado { get; set; }

    public int TipoInventario { get; set; }

    public int Estado { get; set; }

    public string? Comentarios { get; set; }
}
