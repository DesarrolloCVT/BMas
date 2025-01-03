using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Whl3
{
    public DateTime? LastDate { get; set; }

    public string CardCode { get; set; } = null!;

    public string Nip { get; set; } = null!;

    public string BankAcc { get; set; } = null!;
}
