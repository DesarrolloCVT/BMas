using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRamonestacionPersona
{
    public string? Name { get; set; }

    public string? LastName { get; set; }

    public int IdAmonestacion { get; set; }

    public string Pin { get; set; } = null!;
}
