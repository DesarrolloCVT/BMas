using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oula
{
    public int SerialNum { get; set; }

    public string? Signed { get; set; }

    public string? Checked { get; set; }

    public string? Eulatype { get; set; }

    public string? Licensor { get; set; }

    public string? Licensee { get; set; }

    public string? InstallNo { get; set; }

    public string? Signer { get; set; }

    public string? Ufunction { get; set; }

    public string? Username { get; set; }

    public DateTime? SignDate { get; set; }

    public string? DocVer { get; set; }

    public byte[]? Euladoc { get; set; }

    public string? Eulaformat { get; set; }

    public string? Checksum { get; set; }
}
