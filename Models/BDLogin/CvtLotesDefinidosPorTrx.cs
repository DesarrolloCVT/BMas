using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLotesDefinidosPorTrx
{
    public int IdDefinicion { get; set; }

    public string Descripcion { get; set; } = null!;

    public int ObjType { get; set; }

    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int DocEntryRel { get; set; }

    public string ItemCode { get; set; } = null!;

    public int IdCodificacion { get; set; }

    public string CodigoLote { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaUpdate { get; set; }

    public string Equipo { get; set; } = null!;

    public string EqUsuario { get; set; } = null!;

    public string IpAddress { get; set; } = null!;
}
