using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oclc
{
    public int AbsEntry { get; set; }

    public string? ClnpScn { get; set; }

    public DateTime? ClnpDate { get; set; }

    public DateTime? UpTo { get; set; }

    public string? Rmrks { get; set; }

    public int? CreateTs { get; set; }

    public short? UserSign { get; set; }
}
