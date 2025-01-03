using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oin
{
    public int InsId { get; set; }

    public string? Customer { get; set; }

    public string? CustmrName { get; set; }

    public int? ContactCod { get; set; }

    public string? DirectCsmr { get; set; }

    public string? DrctCsmNam { get; set; }

    public string? ManufSn { get; set; }

    public string? InternalSn { get; set; }

    public string? Warranty { get; set; }

    public DateTime? WrrntyStrt { get; set; }

    public DateTime? WrrntyEnd { get; set; }

    public short? ResponsVal { get; set; }

    public string? ResponsUnt { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public short? ItemGroup { get; set; }

    public DateTime? ManufDate { get; set; }

    public int? Delivery { get; set; }

    public int? DeliveryNo { get; set; }

    public int? Invoice { get; set; }

    public int? InvoiceNum { get; set; }

    public DateTime? DlvryDate { get; set; }

    public string? CntctPhone { get; set; }

    public string? Street { get; set; }

    public string? Block { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? InstLction { get; set; }

    public int? Contract { get; set; }

    public DateTime? CntrctStrt { get; set; }

    public DateTime? CntrctEnd { get; set; }

    public string? Attachment { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Building { get; set; }

    public string? Status { get; set; }

    public int? ReplcIns { get; set; }

    public int? RepByIns { get; set; }

    public int? Technician { get; set; }

    public int? Territory { get; set; }

    public int? AtcEntry { get; set; }

    public string? Transfered { get; set; }

    public string? AddrType { get; set; }

    public short? Instance { get; set; }

    public string? StreetNo { get; set; }

    public string? Bptype { get; set; }

    public int? OwnerCode { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }
}
