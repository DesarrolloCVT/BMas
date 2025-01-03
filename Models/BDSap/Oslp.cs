using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oslp
{
    public int SlpCode { get; set; }

    public string SlpName { get; set; } = null!;

    public string? Memo { get; set; }

    public decimal? Commission { get; set; }

    public short? GroupCode { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int? EmpId { get; set; }

    public string? Active { get; set; }

    public string? Telephone { get; set; }

    public string? Mobil { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }

    public string? UIdtienda { get; set; }

    public string? UCodInterno { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }

    public string UExxVendorPos { get; set; } = null!;

    public string? UExxTipoVendorPos { get; set; }

    public string? UExxDescuentoPos { get; set; }
}
