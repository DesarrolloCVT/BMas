using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Soi3
{
    public int WizardId { get; set; }

    public int Soinum { get; set; }

    public int? AgrNum { get; set; }

    public int? AgrNo { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? PayToCtry { get; set; }

    public int? PmntNum { get; set; }

    public int? PmntEntry { get; set; }

    public int? PmntType { get; set; }

    public DateTime? PmntDate { get; set; }

    public decimal? ExcBasSum { get; set; }

    public decimal? ExciseSum { get; set; }

    public decimal? VatBaseSum { get; set; }

    public decimal? VatSum { get; set; }

    public string? RegNo { get; set; }

    public DateTime? RegDate { get; set; }

    public string? ExecStat { get; set; }

    public int? Bplid { get; set; }
}
