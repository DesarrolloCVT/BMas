using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1EusalesStockTransferView
{
    public string? OcrdLicTradNum { get; set; }

    public string? OwhsFromFedTaxId { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? Quantity { get; set; }

    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public int? FinncPriod { get; set; }

    public string? Canceled { get; set; }

    public string? OwtrCardCode { get; set; }

    public string? OwtrCardName { get; set; }

    public string? ShipperCardCode { get; set; }

    public string? ShipperCardName { get; set; }

    public string? OwhsFromCountry { get; set; }

    public string? OcryFromIsEc { get; set; }

    public string? OwhsToCountry { get; set; }

    public string? OcryToIsEc { get; set; }

    public decimal? DummyTax1NdPercent { get; set; }

    public string? DummyTax1CrditDebit { get; set; }

    public int? DummyTax1BaseArrTyp { get; set; }

    public string? DummyOvtgTriangularDeal { get; set; }

    public string? DummyOvtgCode { get; set; }

    public string? DummyOvtgGoddsShip { get; set; }

    public string? DummyOvtgVatCategory { get; set; }

    public string? DummyOvtgServSupply { get; set; }
}
