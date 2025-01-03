using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oat2
{
    public int AgrNo { get; set; }

    public int AgrLnNum { get; set; }

    public int AgrEfctNum { get; set; }

    public string? DatePeriod { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? CallUp { get; set; }

    public string? WhsCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? ConsumeFct { get; set; }

    public string? FreeTxt { get; set; }

    public int? LogInstanc { get; set; }

    public decimal? AmountLc { get; set; }

    public decimal? AmountFc { get; set; }

    public string? EncryptIv { get; set; }
}
