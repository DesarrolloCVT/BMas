using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odsw
{
    public string? ItemCode { get; set; }

    public int? SysNumber { get; set; }

    public string? WhsCode { get; set; }

    public string? Location { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Transfered { get; set; }

    public short? Instance { get; set; }

    public int AbsEntry { get; set; }

    public int? MdAbsEntry { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
