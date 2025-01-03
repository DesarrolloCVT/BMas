using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oeml
{
    public int AbsEntry { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public int? DocEntry { get; set; }

    public string? ObjType { get; set; }

    public int? DocNum { get; set; }

    public string? EmailAddr { get; set; }

    public DateTime? SendDate { get; set; }

    public short? SendTime { get; set; }

    public short? Userid { get; set; }

    public string? UName { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public int? AtcEntry { get; set; }

    public int? AlertCode { get; set; }

    public string? RecpntObjT { get; set; }

    public string? RecpntObjC { get; set; }

    public string? Confirmed { get; set; }
}
