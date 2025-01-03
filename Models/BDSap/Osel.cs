using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osel
{
    public short? UserId { get; set; }

    public string? FilterName { get; set; }

    public string? FormNum { get; set; }

    public int AbsEntry { get; set; }
}
