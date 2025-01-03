using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1Report349StockTransferView
{
    public int DocEntry { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public int DocNum { get; set; }

    public string? Canceled { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? Quantity { get; set; }

    public int? OrdinLnum { get; set; }

    public string? DummyTax1CrditDebit { get; set; }

    public int? DummyTax1SrcLineNum { get; set; }

    public int? DummyTax1BaseAbsEntry { get; set; }

    public decimal? DummyTax1BaseSum { get; set; }

    public string? OvtgOperationCode { get; set; }

    public string? DummyOvtgCategory { get; set; }

    public string? DummyOvtgCode { get; set; }

    public string? OcrdLicTradNum { get; set; }

    public string? OwtrCardCode { get; set; }

    public string? OwtrCardName { get; set; }

    public string? OcrdCardType { get; set; }

    public string? ShipperCardCode { get; set; }

    public string? ShipperCardName { get; set; }

    public string? OwhsFromFedTaxId { get; set; }

    public string? OwhsFromCountry { get; set; }

    public string? OcryFromIsEc { get; set; }

    public string? OwhsToCountry { get; set; }

    public string? OcryToIsEc { get; set; }
}
