using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hem7
{
    public int EmpId { get; set; }

    public short Line { get; set; }

    public string? ConName { get; set; }

    public string? PmntNotes { get; set; }

    public decimal? An { get; set; }

    public decimal? Ag { get; set; }

    public string? BankName { get; set; }

    public string? BankCode { get; set; }

    public string? BankAcct { get; set; }

    public int? LogInstanc { get; set; }

    public string? Ancurrency { get; set; }

    public string? Agcurrency { get; set; }

    public string? Sequence { get; set; }

    public string? EnBnkAcct { get; set; }

    public string? EncryptIv { get; set; }
}
