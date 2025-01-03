using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Olgl
{
    public int AbsEntry { get; set; }

    public string SrcObjType { get; set; } = null!;

    public int SrcObjAbs { get; set; }

    public string? ObjType { get; set; }

    public short? UserSign { get; set; }

    public DateTime? PrintDate { get; set; }

    public short? PrintTime { get; set; }

    public string? PrBrand { get; set; }

    public string? PrType { get; set; }

    public string? PrModel { get; set; }

    public string? PrFwVer { get; set; }

    public string? PrDllVer { get; set; }

    public string? FisSeries { get; set; }

    public string? FisNumber { get; set; }

    public string? DocNumber { get; set; }

    public short? FisUser { get; set; }
}
