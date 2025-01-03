using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Onfm
{
    public string AbsEntry { get; set; } = null!;

    public string? NfmName { get; set; }

    public string? NfmDescrip { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? NfmCode { get; set; }

    public string? NfmTw { get; set; }
}
