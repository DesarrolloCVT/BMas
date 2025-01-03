using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Asc2
{
    public int SrcvCallId { get; set; }

    public short Line { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public decimal? TransToTec { get; set; }

    public decimal? Delivered { get; set; }

    public decimal? RetFromTec { get; set; }

    public decimal? Returned { get; set; }

    public string? Bill { get; set; }

    public decimal? QtyToBill { get; set; }

    public decimal? QtyToInv { get; set; }

    public string? ObjectType { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? VisOrder { get; set; }

    public string? EncryptIv { get; set; }
}
