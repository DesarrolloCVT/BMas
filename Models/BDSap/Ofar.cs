using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ofar
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? AssetDate { get; set; }

    public string? Ref { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public string? DprArea { get; set; }

    public int? TransId { get; set; }

    public string? Handwrtten { get; set; }

    public string Pindicator { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatRegNum { get; set; }

    public decimal? RevalPerc { get; set; }

    public string? IfrsPsting { get; set; }
}
