using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogr
{
    public int AbsEntry { get; set; }

    public string? PeriodCat { get; set; }

    public DateTime? FinancYear { get; set; }

    public short? Year { get; set; }

    public string? PeriodName { get; set; }

    public string? SubType { get; set; }

    public int? PeriodNum { get; set; }

    public DateTime? FRefDate { get; set; }

    public DateTime? TRefDate { get; set; }

    public DateTime? FDueDate { get; set; }

    public DateTime? TDueDate { get; set; }

    public DateTime? FTaxDate { get; set; }

    public DateTime? TTaxDate { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? ResCode { get; set; }

    public short? ResGrpCod { get; set; }

    public string? WhsCode { get; set; }

    public short? BpgrpCod { get; set; }

    public string? LicTradNum { get; set; }

    public string? ShipCountr { get; set; }

    public string? ShipState { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? RuleCode { get; set; }

    public string? Glmethod { get; set; }

    public string? Transfered { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ResRevAct { get; set; }

    public string? ResExpAct { get; set; }

    public string? ResSaleAct { get; set; }

    public string? ResPurAct { get; set; }

    public string? ResNinvAct { get; set; }

    public string? ResStdExp1 { get; set; }

    public string? ResStdExp2 { get; set; }

    public string? ResStdExp3 { get; set; }

    public string? ResStdExp4 { get; set; }

    public string? ResStdExp5 { get; set; }

    public string? ResStdExp6 { get; set; }

    public string? ResStdExp7 { get; set; }

    public string? ResStdExp8 { get; set; }

    public string? ResStdExp9 { get; set; }

    public string? ResStdEx10 { get; set; }

    public string? ResWipAct { get; set; }

    public string? ResScrapAc { get; set; }

    public string? WipOffPlAc { get; set; }

    public string? ResOffPlAc { get; set; }

    public string? Active { get; set; }

    public string? CmpPrivate { get; set; }

    public string? VatGroup { get; set; }

    public string? CardCode { get; set; }

    public int? Usage { get; set; }
}
