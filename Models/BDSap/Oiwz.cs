using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oiwz
{
    public int AbsEntry { get; set; }

    public string? WizName { get; set; }

    public DateTime? PostDateTo { get; set; }

    public string? WizType { get; set; }

    public string? IndexCode { get; set; }

    public decimal? IndexRate { get; set; }

    public string? CashAcct { get; set; }

    public decimal? CashFrmBl { get; set; }

    public string? CashCancel { get; set; }

    public string? FromItem { get; set; }

    public string? ToItem { get; set; }

    public short? ItemGroup { get; set; }

    public string? Properties { get; set; }

    public string? RvalMethod { get; set; }

    public short? PriceSour { get; set; }

    public int? TransAbs { get; set; }

    public string? UseDln { get; set; }

    public string? UsePch { get; set; }

    public string? UsePchnoSt { get; set; }

    public string? UseImport { get; set; }

    public decimal? CashDifBal { get; set; }

    public string? CashExecut { get; set; }

    public string? ActType { get; set; }

    public decimal? VarRate { get; set; }

    public string? FilterExe { get; set; }

    public int? CashErrRes { get; set; }

    public string? CshRvToAct { get; set; }

    public string? MarkVar { get; set; }

    public string? ChngPrice { get; set; }

    public string? UseSemestr { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? CshLstRvBl { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? CshCanclD { get; set; }

    public int? Bplid { get; set; }
}
