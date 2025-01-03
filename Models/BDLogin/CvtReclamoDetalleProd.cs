using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReclamoDetalleProd
{
    public int IdDetReclamo { get; set; }

    public int? IdReclamo { get; set; }

    public int? Npallet { get; set; }

    public int? Cantidad { get; set; }

    public string? CodProducto { get; set; }

    public string? Descripcion { get; set; }

    public string? UnidadDeMedida { get; set; }

    public string? Origen { get; set; }

    public string? Observaciones { get; set; }
}
