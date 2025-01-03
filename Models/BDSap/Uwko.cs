using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Uwko
{
    public int OrderNum { get; set; }

    public string? Status { get; set; }

    public string? Canceled { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ProdctDate { get; set; }

    public DateTime? ExpFinishD { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? FinishUser { get; set; }

    public string? CardCode { get; set; }

    public string? CustomName { get; set; }

    public string? NumInCustm { get; set; }

    public decimal? TotalOrder { get; set; }

    public string? TotalCurr { get; set; }

    public short? DocTime { get; set; }

    public string? Memo { get; set; }

    public int SerialNum { get; set; }

    public int? CntctCode { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Transfered { get; set; }

    public short Instance { get; set; }

    public int? Series { get; set; }

    public string? ActWorkCod { get; set; }

    public decimal? ActWorkSum { get; set; }

    public string? JrnlMemo { get; set; }

    public string? DataSource { get; set; }

    public string? ObjType { get; set; }

    public short? UserSign { get; set; }

    public short? PriceList { get; set; }

    public int? FinncPriod { get; set; }

    public decimal? SysRate { get; set; }
}
