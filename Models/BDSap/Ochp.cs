using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ochp
{
    public int AbsEntry { get; set; }

    public string? Chapter { get; set; }

    public string? Heading { get; set; }

    public string? SubHeading { get; set; }

    public string? Dscription { get; set; }

    public string ChapterId { get; set; } = null!;
}
