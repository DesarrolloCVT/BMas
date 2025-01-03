using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obpl
{
    public int Bplid { get; set; }

    public string Bplname { get; set; } = null!;

    public string? BplfrName { get; set; }

    public string? VatregNum { get; set; }

    public string? RepName { get; set; }

    public string? Industry { get; set; }

    public string? Business { get; set; }

    public string? Address { get; set; }

    public string? AddressFr { get; set; }

    public string? MainBpl { get; set; }

    public string? TxOffcNo { get; set; }

    public string? Disabled { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DflCust { get; set; }

    public string? DflVendor { get; set; }

    public string? DflWhs { get; set; }

    public string? DflTaxCode { get; set; }

    public string? RevOffice { get; set; }

    public string? TaxIdNum { get; set; }

    public string? TaxIdNum2 { get; set; }

    public string? TaxIdNum3 { get; set; }

    public string? AddtnlId { get; set; }

    public int? CompNature { get; set; }

    public int? EconActT { get; set; }

    public string? CredCorig { get; set; }

    public string? Ipiperiod { get; set; }

    public int? CoopAssocT { get; set; }

    public string? PrefState { get; set; }

    public int? ProfTax { get; set; }

    public int? CompQualif { get; set; }

    public int? DeclType { get; set; }

    public string? AddrType { get; set; }

    public string? Street { get; set; }

    public string? StreetNo { get; set; }

    public string? Building { get; set; }

    public string? ZipCode { get; set; }

    public string? Block { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? PmtClrAct { get; set; }

    public string? CommerReg { get; set; }

    public DateTime? DateOfInc { get; set; }

    public string? Spedprof { get; set; }

    public int? EnvTypeNfe { get; set; }

    public string? Opt4Icms { get; set; }

    public string? AliasName { get; set; }

    public string? GlblLocNum { get; set; }

    public DateTime? TaxRptFrm { get; set; }

    public string? Suframa { get; set; }

    public string? DfltResWhs { get; set; }

    public int? SnapshotId { get; set; }

    public int? Bplnum { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
