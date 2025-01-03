using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtArticuloDocumento
{
    public string? DocNumero { get; set; }

    public int DocId { get; set; }

    public int ArticuloId { get; set; }

    public DateTime DocFecha { get; set; }

    public int DocStock { get; set; }

    public int DocPrecio { get; set; }
}
