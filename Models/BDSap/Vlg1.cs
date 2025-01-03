using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Vlg1
{
    public int AbsEntry { get; set; }

    public int RecNum { get; set; }

    public DateTime? FromSysDat { get; set; }

    public int? FromDocNum { get; set; }

    public short? FromDocTyp { get; set; }

    public DateTime? ToSysDate { get; set; }

    public int? ToDocNum { get; set; }

    public short? ToDocType { get; set; }

    public int? CalRecOinm { get; set; }

    public int? LastCalcTs { get; set; }

    public decimal? SumTranVal { get; set; }

    public string? StrFld { get; set; }

    public int? NumFld { get; set; }
}
