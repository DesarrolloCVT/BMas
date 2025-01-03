using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlPesoProductoPalletizado
{
    public int IdContrPesoPallet { get; set; }

    public string? CodProducto { get; set; }

    public string? Lote { get; set; }

    public int? Turno { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdEtiquetadora { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUsuarioVerificador { get; set; }

    public string? Estado { get; set; }
}
