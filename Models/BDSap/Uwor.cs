﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uwor
{
    public int DocEntry { get; set; }

    public int DocNum { get; set; }

    public int? Series { get; set; }

    public string? ItemCode { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public decimal? PlannedQty { get; set; }

    public decimal? CmpltQty { get; set; }

    public decimal? RjctQty { get; set; }

    public DateTime? PostDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? OriginAbs { get; set; }

    public int? OriginNum { get; set; }

    public string? OriginType { get; set; }

    public short? UserSign { get; set; }

    public string? Comments { get; set; }

    public DateTime? CloseDate { get; set; }

    public DateTime? RlsDate { get; set; }

    public string? CardCode { get; set; }

    public string? Warehouse { get; set; }

    public string? Uom { get; set; }

    public int? LineDirty { get; set; }

    public string? JrnlMemo { get; set; }

    public int? TransId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Printed { get; set; }

    public string? OcrCode { get; set; }

    public string Pindicator { get; set; } = null!;

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public short? SeqCode { get; set; }

    public int? Serial { get; set; }

    public string? SeriesStr { get; set; }

    public string? SubStr { get; set; }

    public int? LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Project { get; set; }

    public string? SupplCode { get; set; }

    public int? UomEntry { get; set; }

    public string? PickRmrk { get; set; }

    public DateTime? SysCloseDt { get; set; }

    public short? SysCloseTm { get; set; }

    public string? CloseVerNm { get; set; }

    public DateTime? StartDate { get; set; }

    public string? ObjType { get; set; }

    public string? ProdName { get; set; }

    public short? Priority { get; set; }

    public string? RouDatCalc { get; set; }

    public string? UpdAlloc { get; set; }

    public int? CreateTs { get; set; }

    public int? UpdateTs { get; set; }

    public string? VersionNum { get; set; }

    public string? DataSource { get; set; }

    public string? Sappassprt { get; set; }

    public int? AtcEntry { get; set; }

    public string? Attachment { get; set; }

    public string? AsChild { get; set; }

    public string? LinkToObj { get; set; }

    public string? ProcItms { get; set; }

    public string? ReopOriDoc { get; set; }

    public short? UNumSilo { get; set; }

    public int? UTransNumDesv { get; set; }

    public short? UNumSala { get; set; }

    public string? ULinea { get; set; }

    public int? UCantPtreal { get; set; }

    public int? UCantReproceso { get; set; }

    public int? UCantBarrido { get; set; }

    public string? UAbocador { get; set; }

    public string? UTurno { get; set; }

    public int? UPesoPromPallets { get; set; }

    public int? UPesoPromBolsas { get; set; }

    public string? UPaisOrigenMp { get; set; }

    public string? UOperador { get; set; }
}
