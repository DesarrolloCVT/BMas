using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtToneladasMovida
{
    public string Tipo { get; set; } = null!;

    public int? Dia { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? DocNum { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Ton { get; set; }

    public string Tproducto { get; set; } = null!;

    public string ItmsGrpNam { get; set; } = null!;
}
