using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cumi
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public short UserSign { get; set; }

    public int? FatherId { get; set; }

    public int? SortNum { get; set; }

    public string? Type { get; set; }

    public string? ObjType { get; set; }

    public string? Key { get; set; }

    public int? FormMenuId { get; set; }

    public int? FormNum { get; set; }

    public string? RepPath { get; set; }

    public short? Levels { get; set; }
}
