﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aqi1
{
    public int DocEntry { get; set; }

    public int DocLineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? InvntryUom { get; set; }

    public decimal? OnHandBef { get; set; }

    public decimal? Price { get; set; }

    public decimal? Quantity { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string? IoffIncAcc { get; set; }

    public string? DoffDecAcc { get; set; }

    public string? OcrCode { get; set; }

    public string? WhsCode { get; set; }

    public decimal? DocTotal { get; set; }

    public decimal? DocTotalFc { get; set; }

    public decimal? DocTotalSy { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? ObjType { get; set; }

    public string? Project { get; set; }

    public string? BarCode { get; set; }

    public string? InvUoM { get; set; }

    public decimal? InvUoMqty { get; set; }

    public int? BinEntry { get; set; }

    public short? FirmCode { get; set; }

    public string? SuppCatNum { get; set; }

    public string? CardCode { get; set; }

    public string? Remark { get; set; }

    public int? Location { get; set; }

    public short? ItmsGrpCod { get; set; }

    public int LogInstanc { get; set; }

    public string? BinNegQty { get; set; }

    public int? VisOrder { get; set; }

    public decimal? ActPrice { get; set; }

    public decimal? PostValueL { get; set; }

    public decimal? PostValueS { get; set; }
}