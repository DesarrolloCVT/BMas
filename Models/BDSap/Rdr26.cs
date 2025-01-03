using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rdr26
{
    public int DocEntry { get; set; }

    public string? SuplyType { get; set; }

    public int? SubSplyTyp { get; set; }

    public string? DocType { get; set; }

    public int? TransMode { get; set; }

    public decimal? Distance { get; set; }

    public string? TransDocNo { get; set; }

    public DateTime? TransDate { get; set; }

    public string? VehicleTyp { get; set; }

    public string? VehicleNo { get; set; }

    public string? EwayBillNo { get; set; }

    public DateTime? EwbDate { get; set; }

    public string? FrmTraName { get; set; }

    public string? FrmAddres1 { get; set; }

    public string? FrmAddres2 { get; set; }

    public string? FrmZipCode { get; set; }

    public string? ActFrmStat { get; set; }

    public string? ToTraName { get; set; }

    public string? ToAddres1 { get; set; }

    public string? ToAddres2 { get; set; }

    public string? ToZipCode { get; set; }

    public string? ActToState { get; set; }

    public string? FrmGstn { get; set; }

    public string? FrmState { get; set; }

    public string? ToGstn { get; set; }

    public string? ToState { get; set; }

    public int? MainHsnEnt { get; set; }

    public string? FrmPlace { get; set; }

    public string? ToPlace { get; set; }

    public string? TransId { get; set; }

    public string? TransName { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public int? TspEntry { get; set; }

    public int? TspLine { get; set; }

    public int? TransType { get; set; }
}
