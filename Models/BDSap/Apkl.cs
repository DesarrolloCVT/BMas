using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apkl
{
    public int AbsEntry { get; set; }

    public string? Name { get; set; }

    public short? OwnerCode { get; set; }

    public string? OwnerName { get; set; }

    public DateTime? PickDate { get; set; }

    public string? Remarks { get; set; }

    public string? Canceled { get; set; }

    public short? ShipType { get; set; }

    public string? Status { get; set; }

    public string? Printed { get; set; }

    public int LogInstac { get; set; }

    public string? ObjType { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? UseBaseUn { get; set; }
}
