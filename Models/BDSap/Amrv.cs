using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Amrv
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public DateTime? DocDate { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public int? TransId { get; set; }

    public short? DocTime { get; set; }

    public string? RevalType { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Series { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public int? StationId { get; set; }

    public string? RincmAcct { get; set; }

    public string? RexpnAcct { get; set; }

    public int LogInstanc { get; set; }

    public string ObjType { get; set; } = null!;

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public string? VersionNum { get; set; }

    public string? InflaReval { get; set; }

    public string? SupplCode { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? CreatedBy { get; set; }
}
