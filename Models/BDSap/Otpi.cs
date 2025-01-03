using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otpi
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public string? DocType { get; set; }

    public string? Canceled { get; set; }

    public string? HandWriten { get; set; }

    public string? Printed { get; set; }

    public string? Transfered { get; set; }

    public string? ObjType { get; set; }

    public DateTime? DocDate { get; set; }

    public string? CardCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public int Series { get; set; }

    public short? Segment { get; set; }

    public int? CntctCode { get; set; }

    public DateTime? VatDate { get; set; }

    public string? Comments { get; set; }

    public short? TrnspCode { get; set; }

    public string? ShipToCode { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public int? LogInstanc { get; set; }

    public string? CurSource { get; set; }

    public string? DocCur { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? NumAtCard { get; set; }

    public string? CardName { get; set; }

    public DateTime? CancelDate { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? VatSum { get; set; }

    public string? PayRefNo { get; set; }

    public DateTime? PayRefDate { get; set; }

    public string? TaxMethod { get; set; }

    public int? AtcEntry { get; set; }

    public string? IsDpm { get; set; }

    public int AltRev { get; set; }

    public string Pindicator { get; set; } = null!;

    public int? TransId { get; set; }

    public string? JrnlMemo { get; set; }

    public int? Bplid { get; set; }

    public string? Bplname { get; set; }

    public string? VatregNum { get; set; }

    public string? GovContrId { get; set; }

    public string? Dppstatus { get; set; }

    public string? EncryptIv { get; set; }
}
