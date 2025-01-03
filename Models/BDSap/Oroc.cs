using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oroc
{
    public int AbsEntry { get; set; }

    public int? OccurCode { get; set; }

    public short? MovemnCode { get; set; }

    public string? BoeStatus { get; set; }

    public string? Descript { get; set; }

    public int? Color { get; set; }

    public string? FileFormat { get; set; }

    public string? BankCode { get; set; }
}
