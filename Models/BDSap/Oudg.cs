using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oudg
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Warehouse { get; set; }

    public int? SalePerson { get; set; }

    public string? Ictcard { get; set; }

    public string? CashAcct { get; set; }

    public string? CheckAcct { get; set; }

    public short? CreditCard { get; set; }

    public string? PrintRcpt { get; set; }

    public string? ShortRcpt { get; set; }

    public short? Color { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? PrintHeadr { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    public string? EMail { get; set; }

    public string? FrgnAddr { get; set; }

    public string? FrnPrntHdr { get; set; }

    public string? FrgnPhone1 { get; set; }

    public string? FrgnPhone2 { get; set; }

    public string? FrgnFax { get; set; }

    public string? DflTaxCode { get; set; }

    public string? FreeZoneNo { get; set; }

    public short? UserSign { get; set; }

    public string? Free1 { get; set; }

    public string? UseTax { get; set; }

    public string? AdrsFromWh { get; set; }

    public int? Language { get; set; }

    public string? Font { get; set; }

    public int? FontSize { get; set; }

    public int? Bplid { get; set; }

    public string? AssetInDoc { get; set; }

    public string? AttachPath { get; set; }

    public string? DflPticode { get; set; }

    public string? Free4 { get; set; }

    public string? Free2 { get; set; }

    public string? Free3 { get; set; }

    public int? DflPosCr { get; set; }

    public string? TimeFormat { get; set; }

    public string? DateFormat { get; set; }

    public string? DateSep { get; set; }

    public string? DecSep { get; set; }

    public string? ThousSep { get; set; }

    public string? WallPaper { get; set; }

    public string? WllPprDsp { get; set; }

    public string? SkinType { get; set; }

    public int? CharMonth { get; set; }

    public string? HandleEdoc { get; set; }
}
