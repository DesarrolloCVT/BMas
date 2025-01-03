using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aisi
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocStatus { get; set; }

    public string? Revised { get; set; }

    public string? OrgRefNo { get; set; }

    public int? OrgRefEty { get; set; }

    public DateTime? OrgDocDate { get; set; }

    public int? TransId { get; set; }

    public string? Comments { get; set; }

    public string? ObjType { get; set; }

    public int? SrcLoc { get; set; }

    public string? SrcLocName { get; set; }

    public string? SrcGstin { get; set; }

    public int? TarLoc { get; set; }

    public string? TarLocName { get; set; }

    public string? TarGstin { get; set; }

    public int? Isdentry { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? JrnlMemo { get; set; }

    public string? Handwrtten { get; set; }

    public string Pindicator { get; set; } = null!;

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatregNum { get; set; }
}
