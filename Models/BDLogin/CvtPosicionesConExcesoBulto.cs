using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPosicionesConExcesoBulto
{
    public string? SiteShortDescription { get; set; }

    public int LayoutId { get; set; }

    public string? LayoutDescription { get; set; }

    public int PalletPermitidos { get; set; }

    public int? PalletUbicados { get; set; }
}
