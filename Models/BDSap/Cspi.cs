using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cspi
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public DateTime? LstUpdDate { get; set; }

    public int? LstUpdTime { get; set; }

    public string? CheckSum { get; set; }
}
