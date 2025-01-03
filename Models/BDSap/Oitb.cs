﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oitb
{
    public short ItmsGrpCod { get; set; }

    public string ItmsGrpNam { get; set; } = null!;

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? BalInvntAc { get; set; }

    public string? SaleCostAc { get; set; }

    public string? TransferAc { get; set; }

    public string? RevenuesAc { get; set; }

    public string? VarianceAc { get; set; }

    public string? DecreasAc { get; set; }

    public string? IncreasAc { get; set; }

    public string? ReturnAc { get; set; }

    public string? ExpensesAc { get; set; }

    public string? EurevenuAc { get; set; }

    public string? EuexpensAc { get; set; }

    public string? FrRevenuAc { get; set; }

    public string? FrExpensAc { get; set; }

    public string? ExmptIncom { get; set; }

    public short? CycleCode { get; set; }

    public string? Alert { get; set; }

    public string? PriceDifAc { get; set; }

    public string? ExchangeAc { get; set; }

    public string? BalanceAcc { get; set; }

    public string? PurchaseAc { get; set; }

    public string? PareturnAc { get; set; }

    public string? PurchOfsAc { get; set; }

    public string? ShpdGdsAct { get; set; }

    public string? VatRevAct { get; set; }

    public string? DecresGlAc { get; set; }

    public string? IncresGlAc { get; set; }

    public string? InvntSys { get; set; }

    public string? PlaningSys { get; set; }

    public string? PrcrmntMtd { get; set; }

    public short? OrdrIntrvl { get; set; }

    public decimal? OrdrMulti { get; set; }

    public decimal? MinOrdrQty { get; set; }

    public int? LeadTime { get; set; }

    public string? StokRvlAct { get; set; }

    public string? StkOffsAct { get; set; }

    public string? WipAcct { get; set; }

    public string? WipVarAcct { get; set; }

    public string? CostRvlAct { get; set; }

    public string? CstOffsAct { get; set; }

    public string? ExpClrAct { get; set; }

    public string? ExpOfstAct { get; set; }

    public string? Object { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Arcmact { get; set; }

    public string? ArcmfrnAct { get; set; }

    public string? Arcmeuact { get; set; }

    public string? ArcmexpAct { get; set; }

    public string? Apcmact { get; set; }

    public string? ApcmfrnAct { get; set; }

    public string? Apcmeuact { get; set; }

    public string? RevRetAct { get; set; }

    public string? ItemClass { get; set; }

    public int? OsvcCode { get; set; }

    public int? IsvcCode { get; set; }

    public int? ServiceGrp { get; set; }

    public int? Ncmcode { get; set; }

    public string? MatType { get; set; }

    public int? MatGrp { get; set; }

    public string? ProductSrc { get; set; }

    public string? NegStckAct { get; set; }

    public string? StkInTnAct { get; set; }

    public string? PurBalAct { get; set; }

    public string? WhIcenAct { get; set; }

    public string? WhOcenAct { get; set; }

    public string? WipOffset { get; set; }

    public string? StockOffst { get; set; }

    public int? UgpEntry { get; set; }

    public int? IuoMentry { get; set; }

    public int? ToleranDay { get; set; }

    public string? RuleCode { get; set; }

    public string? CompoWh { get; set; }

    public string? FreeChrgSa { get; set; }

    public string? FreeChrgPu { get; set; }

    public string? RawMtrl { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }

    public string? UX4rCodproy { get; set; }

    public string? UX4rCoddim1 { get; set; }

    public string? UX4rCoddim2 { get; set; }

    public string? UX4rCoddim3 { get; set; }

    public string? UX4rCoddim4 { get; set; }

    public string? UX4rCoddim5 { get; set; }

    public string? USigla { get; set; }
}
