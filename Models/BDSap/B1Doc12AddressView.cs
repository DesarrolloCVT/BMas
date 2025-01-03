using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1Doc12AddressView
{
    public int DocEntry { get; set; }

    public string? ObjectType { get; set; }

    public string? CountryS { get; set; }

    public string? CityS { get; set; }

    public string? CountryB { get; set; }

    public string? AltCrdNamB { get; set; }

    public string? AltTaxIdB { get; set; }

    public string? StateB { get; set; }

    public string? CityB { get; set; }

    public string? StreetB { get; set; }

    public string? TaxId0 { get; set; }

    public string? Carrier { get; set; }
}
