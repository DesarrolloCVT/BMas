using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gdp1
{
    public int AbsEntry { get; set; }

    public int PfsAbs { get; set; }

    public string? TableName { get; set; }

    public string? FieldName { get; set; }

    public string? RefObjType { get; set; }

    public string? Category { get; set; }

    public string? OrigType { get; set; }

    public string? Type { get; set; }

    public string? Descr { get; set; }

    public string? MaxType { get; set; }
}
