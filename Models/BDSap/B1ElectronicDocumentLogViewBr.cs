using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ElectronicDocumentLogViewBr
{
    public int AbsEntry { get; set; }

    public string? ActType { get; set; }

    public string? ActStatus { get; set; }

    public int? DocNum { get; set; }

    public int? Serial { get; set; }

    public DateTime? DocDate { get; set; }

    public short? SeqCode { get; set; }

    public string? NfeSeries { get; set; }

    public string? NfeModel { get; set; }

    public string? TaxId0 { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? CountryS { get; set; }

    public string? CityS { get; set; }

    public string? AssignedId { get; set; }

    public short? Submits { get; set; }

    public DateTime? MdCreateDate { get; set; }

    public short? UserSign { get; set; }

    public string? ActMessage { get; set; }

    public int? EnvType { get; set; }

    public string? ObjType { get; set; }

    public int? DocEntry { get; set; }

    public string? SrcObjType { get; set; }

    public int? SrcObjAbs { get; set; }

    public int? NfeNoFrom { get; set; }

    public int? NfeNoTo { get; set; }

    public short? Year { get; set; }

    public string? Reason { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public string Code { get; set; } = null!;

    public string? ObjectId { get; set; }

    public string? ReportId { get; set; }

    public int? Bplid { get; set; }

    public string? DocBtch { get; set; }

    public short? DocBtchLn { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime? RecvDate { get; set; }

    public string? Carrier { get; set; }

    public string? SendData { get; set; }

    public string? RecvData { get; set; }

    public string? IsRemoved { get; set; }

    public string? Canceled { get; set; }

    public string? EdocGenTyp { get; set; }

    public string? Cancel { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? SendTime { get; set; }
}
