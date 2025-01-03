using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDevolucionesPbi
{
    public string Grupo { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public decimal? Kilos { get; set; }

    public int? MesDevolucion { get; set; }

    public int? AñoDevolucion { get; set; }

    public string? CodCliente { get; set; }

    public string? Cliente { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string Motivo { get; set; } = null!;

    public string? PatenteCamion { get; set; }

    public string? UsuarioReceptorDevolucion { get; set; }

    public string? AreaResponsable { get; set; }
}
