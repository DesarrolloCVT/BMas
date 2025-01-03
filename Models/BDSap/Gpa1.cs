using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gpa1
{
    public int AbsEntry { get; set; }

    public int LineId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? DocType { get; set; }

    public int? DocNum { get; set; }

    public int? DocAbs { get; set; }

    public int? DocLineNum { get; set; }

    public int? ManagedBy { get; set; }

    public string? Selected { get; set; }

    public string? DistNumber { get; set; }

    public DateTime? PostDate { get; set; }

    public string? WhsCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? CogsAcct { get; set; }

    public decimal? CogsAmnt { get; set; }

    public decimal? SalesAmnt { get; set; }

    public decimal? GrssProfit { get; set; }

    public decimal? CogsbyCc { get; set; }

    public decimal? GpbyCc { get; set; }

    public decimal? DeltaGp { get; set; }

    public decimal? SalesPrice { get; set; }

    public decimal? BatchQt { get; set; }

    public int? SnBabs { get; set; }

    public decimal? AccTotal { get; set; }

    public decimal? AccQty { get; set; }

    public int? ActionType { get; set; }

    public decimal? SbaccTotal { get; set; }

    public decimal? SbaccQty { get; set; }

    public string? BaseType { get; set; }

    public string? Execute { get; set; }

    public decimal? SbcogsAmnt { get; set; }

    public decimal? SbsaleAmnt { get; set; }

    public decimal? SbgrssProf { get; set; }

    public decimal? SbgrPrPerc { get; set; }

    public decimal? GrPrPerc { get; set; }

    public decimal? GppercByCc { get; set; }

    public decimal? DeltaGpln { get; set; }

    public decimal? Applied { get; set; }

    public decimal? SbaccTtAdj { get; set; }

    public string? IsMixed { get; set; }

    public decimal? CogsAmByCc { get; set; }

    public decimal? GrssPrByCc { get; set; }

    public string? LineType { get; set; }

    public string? ChDocType { get; set; }

    public int? ChDocAbs { get; set; }

    public decimal? WasQty { get; set; }

    public decimal? WasCogs { get; set; }

    public decimal? WasSales { get; set; }

    public decimal? WasPrice { get; set; }

    public decimal? WasGrProf { get; set; }

    public int? BaseAbs { get; set; }

    public decimal? WasNewCogs { get; set; }

    public int? ChDocLine { get; set; }
}
