using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlLineasPacking
{
    public int ControlLineaId { get; set; }

    public int OrdenFabricacion { get; set; }

    public int Linea { get; set; }

    public DateTime Fecha { get; set; }

    public int CantPallets70 { get; set; }

    public int CantPallets30 { get; set; }

    public int CantPaletizadores { get; set; }

    public int CantAbastMercaderia { get; set; }

    public int CantAbastCajas { get; set; }

    public int CantAseo { get; set; }

    public int? CantCajas { get; set; }

    public int StaffId { get; set; }

    public string? Observacion { get; set; }

    public decimal? CintaAdhesiva { get; set; }

    public int? Pallets { get; set; }

    public int? Corchetes { get; set; }

    public decimal? FilmPaletizado { get; set; }
}
