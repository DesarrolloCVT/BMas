using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acr1
{
    public string Address { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public string? Street { get; set; }

    public string? Block { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public string? LicTradNum { get; set; }

    public int? LineNum { get; set; }

    public string? TaxCode { get; set; }

    public string? Building { get; set; }

    public string AdresType { get; set; } = null!;

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? AddrType { get; set; }

    public string? StreetNo { get; set; }

    public string? AltCrdName { get; set; }

    public string? AltTaxId { get; set; }

    public string? TaxOffice { get; set; }

    public string? GlblLocNum { get; set; }

    public string? Ntnlty { get; set; }

    public string? Diotnat { get; set; }

    public string? TaaSenbl { get; set; }

    public string? GstregnNo { get; set; }

    public int? Gsttype { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public string? EncryptIv { get; set; }

    public string? Myftype { get; set; }

    public DateTime? VatResDate { get; set; }

    public int? VatResCode { get; set; }

    public string? VatResName { get; set; }

    public string? VatResAddr { get; set; }
}
