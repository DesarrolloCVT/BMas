using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oent
{
    public int DocEntry { get; set; }

    public int? DocNum { get; set; }

    public int? BaseDocNum { get; set; }

    public string? Printed { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? FreZoneNum { get; set; }

    public string? Shiper { get; set; }

    public string? Address { get; set; }

    public string? FromCntry { get; set; }

    public string? ToCntry { get; set; }

    public string? FromPort { get; set; }

    public string? ToPort { get; set; }

    public string? AirPlane { get; set; }

    public string? AirPlanNum { get; set; }

    public decimal? TotalFob { get; set; }

    public decimal? Taxes { get; set; }

    public decimal? Insurance { get; set; }

    public decimal? Others { get; set; }

    public decimal? TotalCif { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Comments { get; set; }

    public short? GroupNum { get; set; }

    public short? DocTime { get; set; }

    public int? SlpCode { get; set; }

    public short? TrnspCode { get; set; }

    public string? PartSupply { get; set; }

    public int? ImportEnt { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? NumForPrn { get; set; }

    public string? PurPackMsr { get; set; }

    public int? Series { get; set; }

    public short? BaseDocObj { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
