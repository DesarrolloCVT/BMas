using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pwz2
{
    public int IdEntry { get; set; }

    public string PymCode { get; set; } = null!;

    public string? BnkAccount { get; set; }

    public decimal? MaxIncom { get; set; }

    public decimal? MaxOutgo { get; set; }

    public decimal? Balance { get; set; }

    public decimal? ExpectBal { get; set; }

    public string? Checked { get; set; }

    public string? PymDisc { get; set; }

    public string? PymType { get; set; }

    public decimal? IntBalance { get; set; }

    public decimal? ExpIntBal { get; set; }

    public string? InterimAct { get; set; }

    public string? BnkCountry { get; set; }

    public string? BnkCode { get; set; }

    public string? BnkAccNo { get; set; }

    public string? FatherLn { get; set; }

    public string? NegativPym { get; set; }

    public string? NegPymBnk { get; set; }

    public string? NegCountry { get; set; }

    public string? NegPymAcct { get; set; }

    public string? PaymenMean { get; set; }

    public string? Iban { get; set; }

    public string? SwiftNum { get; set; }
}
