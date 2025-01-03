using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class Location
{
    public int LocationId { get; set; }

    public int SiteId { get; set; }

    public int LayoutId { get; set; }

    public int PackageId { get; set; }

    public DateTime LocationInDate { get; set; }

    public DateTime? LocationOutDate { get; set; }

    public int? IdUsuario { get; set; }
}
