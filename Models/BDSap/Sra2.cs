using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sra2
{
    public int ActionCode { get; set; }

    public DateTime Date { get; set; }

    public int Time { get; set; }

    public string? Status { get; set; }

    public int? ReturnCode { get; set; }

    public string? ReturnStr { get; set; }

    public byte[]? ResDag { get; set; }

    public byte[]? ResPdf { get; set; }

    public byte[]? ResHtml { get; set; }

    public byte[]? ResXml { get; set; }

    public string? Results { get; set; }

    public byte[]? ResLog { get; set; }

    public byte[]? ErrScreen { get; set; }
}
