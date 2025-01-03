using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aob1
{
    public int AlertCode { get; set; }

    public string ObjType { get; set; } = null!;

    public string ObjCode { get; set; } = null!;

    public string? ObjName { get; set; }

    public string? SendIntrnl { get; set; }

    public string? Confirmed1 { get; set; }

    public DateTime? ConfDate1 { get; set; }

    public short? ConfTime1 { get; set; }

    public string? SendEmail { get; set; }

    public string? EMail { get; set; }

    public string? Confirmed2 { get; set; }

    public DateTime? ConfDate2 { get; set; }

    public short? ConfTime2 { get; set; }

    public string? SendSms { get; set; }

    public string? PortNum { get; set; }

    public string? Confirmed3 { get; set; }

    public DateTime? ConfDate3 { get; set; }

    public short? ConfTime3 { get; set; }

    public string? SendFax { get; set; }

    public string? Fax { get; set; }

    public string? Confirmed4 { get; set; }

    public DateTime? ConfDate4 { get; set; }

    public short? ConfTime4 { get; set; }
}
