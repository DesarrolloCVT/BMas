using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPreRecepcion
{
    public int PreRecepcionId { get; set; }

    public int Oc { get; set; }

    public string Ncontenedor { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public DateTime Fproduccion { get; set; }

    public string LoteProveedor { get; set; } = null!;

    public int Cantidad { get; set; }

    public DateTime? Fvencimiento { get; set; }

    public decimal? CantPallets { get; set; }

    public int? Tcontenedor { get; set; }

    public DateOnly Eta { get; set; }

    public DateOnly? Etd { get; set; }
}
