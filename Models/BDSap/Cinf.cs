using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cinf
{
    public int Version { get; set; }

    public string? CompnyName { get; set; }

    public string? Flags { get; set; }

    public int? InfoL1 { get; set; }

    public int? InfoL2 { get; set; }

    public string? InfoA1 { get; set; }

    public string? InfoA2 { get; set; }

    public int? Actstamp { get; set; }

    public int? Admstamp { get; set; }

    public int? Rttstamp { get; set; }

    public int? Cinfstamp { get; set; }

    public string? LawsSet { get; set; }

    public string? EnblVatGrp { get; set; }

    public string? EnblVtgpmn { get; set; }

    public string? VatOosO { get; set; }

    public string? VatOosI { get; set; }

    public string? VatStndO { get; set; }

    public string? VatStndI { get; set; }

    public string? VatExmptO { get; set; }

    public string? VatExmptI { get; set; }

    public string? VatHalfO { get; set; }

    public string? VatHalfI { get; set; }

    public string? VatZrRtO { get; set; }

    public string? VatZrRtI { get; set; }

    public int? MaxActGrps { get; set; }

    public string? EnblDctSrc { get; set; }

    public string? EnblRcn { get; set; }

    public string? EnblCorInv { get; set; }

    public string? EnblCshRep { get; set; }

    public string? EnblIrtrep { get; set; }

    public string? EnblTrnRep { get; set; }

    public string? EnblVpmrep { get; set; }

    public string? EnblActrep { get; set; }

    public string? EnblFtz { get; set; }

    public string? EnblSlfPch { get; set; }

    public string? EnblPchupd { get; set; }

    public string? EnblRsvInv { get; set; }

    public string? EnblRtdnld { get; set; }

    public string? RttdnldAdr { get; set; }

    public string? ZprcCode { get; set; }

    public string? EnblExpns { get; set; }

    public string? EnblRtrRep { get; set; }

    public string? IsEc { get; set; }

    public string? EnblCshDsc { get; set; }

    public string? EnblLostCd { get; set; }

    public int? NumActLvls { get; set; }

    public string? EnblRealRd { get; set; }

    public string? EnblVtgnoD { get; set; }

    public string? EnblGlmanP { get; set; }

    public string? EnblOptVip { get; set; }

    public string? EnblActCrC { get; set; }

    public string? EnblFrnAct { get; set; }

    public string? EnblEcact { get; set; }

    public string? EnblEcrpt { get; set; }

    public string? EnblRound { get; set; }

    public string? EnblPrVatS { get; set; }

    public string? EnblYrTrns { get; set; }

    public string? EnblActTtl { get; set; }

    public string? EnblDocWrn { get; set; }

    public short? ActSegNum { get; set; }

    public string? EnbSgmnAct { get; set; }

    public short? SizeOfSeg0 { get; set; }

    public short? SizeOfSeg1 { get; set; }

    public short? SizeOfSeg2 { get; set; }

    public short? SizeOfSeg3 { get; set; }

    public short? SizeOfSeg4 { get; set; }

    public short? SizeOfSeg5 { get; set; }

    public short? SizeOfSeg6 { get; set; }

    public short? SizeOfSeg7 { get; set; }

    public short? SizeOfSeg8 { get; set; }

    public short? SizeOfSeg9 { get; set; }

    public string? Rprt1099 { get; set; }

    public string? MultiAddss { get; set; }

    public string? EnbDunning { get; set; }

    public string? EnbQtyEdln { get; set; }

    public DateTime? Itw1Date { get; set; }

    public int? Itw1Time { get; set; }

    public int? Itw1Count { get; set; }

    public string? EnbPayRef { get; set; }

    public string? EnblDfrTax { get; set; }

    public string? EnblClsPr { get; set; }

    public string? EnblTaxEl { get; set; }

    public string? EnableBoe { get; set; }

    public string? EnableWht { get; set; }

    public string? EnblEquVat { get; set; }

    public string? EnblFasset { get; set; }

    public string? EnblDoubt { get; set; }

    public string? RateBase { get; set; }

    public string? BoestatClo { get; set; }

    public string? ArdocsInWt { get; set; }

    public string? BisbnkCnt { get; set; }

    public string? BisrbnkCd { get; set; }

    public string? BisrbnkAc { get; set; }

    public string? Bisrbranch { get; set; }

    public string? EnblBpconn { get; set; }

    public string? EnblVatdat { get; set; }

    public string? EnblStAgRp { get; set; }

    public string? EnblCarepo { get; set; }

    public string? EnblMatRev { get; set; }

    public string? EnblMbprec { get; set; }

    public string? CshDscGros { get; set; }

    public string? EnblTaxInv { get; set; }

    public string? EnblCorAct { get; set; }

    public string? EnblRuDip { get; set; }

    public string? EnblCurDec { get; set; }

    public string? EnblPayMtd { get; set; }

    public string? EnblBaseUn { get; set; }

    public string? EnblVatana { get; set; }

    public string? EnblExRenh { get; set; }

    public string? VatgrpCal { get; set; }

    public int? MaxChoose { get; set; }

    public string? EnblInfla { get; set; }

    public string? EnblLawht { get; set; }

    public string? EnblRtwht { get; set; }

    public string? ChkQunty { get; set; }

    public string? SriMngSys { get; set; }

    public string? BtchMngSys { get; set; }

    public string? SriCreatIn { get; set; }

    public string? EnblFolio { get; set; }

    public string? EnblDocSbT { get; set; }

    public string? IepsPayer { get; set; }

    public int? DaysOrdCnc { get; set; }

    public string? EnblLataxS { get; set; }

    public decimal? PercOfAcq { get; set; }

    public decimal? MinBaseDoc { get; set; }

    public string? EnblDpmJdt { get; set; }

    public string? EnblDownP { get; set; }

    public string? EnblNddctC { get; set; }

    public string? DocNmMtd { get; set; }

    public string? DoFilter { get; set; }

    public string? EnblOnPdch { get; set; }

    public string? EnblOnWnCr { get; set; }

    public string? EnblDefInx { get; set; }

    public string? EnblMxComm { get; set; }

    public string? EnblIndxOp { get; set; }

    public string? EnblSbtCvo { get; set; }

    public decimal? MinAmntOap { get; set; }

    public string? CredSumm { get; set; }

    public string? PostdChk { get; set; }

    public string? PostdCred { get; set; }

    public string? CredVend { get; set; }

    public string? WkoStatus { get; set; }

    public string? DispTrByDf { get; set; }

    public string? StampTax { get; set; }

    public decimal? MinAmntAl { get; set; }

    public string? BlockZeroQ { get; set; }

    public string? AutoCrIns { get; set; }

    public string? EnbRepomo { get; set; }

    public string? Rfcvalidat { get; set; }

    public int? MxDcsInPmt { get; set; }

    public string? RelStkNoPr { get; set; }

    public string? CashDisc { get; set; }

    public string? EnableSms { get; set; }

    public string? EnblIndic { get; set; }

    public string? EnbFedTax { get; set; }

    public string? EnblCounty { get; set; }

    public int? Language { get; set; }

    public string? ChkIntgUpd { get; set; }

    public string? ChkIntgCre { get; set; }

    public int? BisBnkAcKy { get; set; }

    public string? EnbZeroDec { get; set; }

    public string? EnbDecWord { get; set; }

    public string? ChkWrdOnly { get; set; }

    public string? EnBnkStmnt { get; set; }

    public string? CalcVatGrp { get; set; }

    public string? TaxSysType { get; set; }

    public string? Esenabled { get; set; }

    public string? RateTotal { get; set; }

    public string? CompanyHis { get; set; }

    public string? EnblAssVal { get; set; }

    public string? CompanySta { get; set; }

    public int? EFrtactLvs { get; set; }

    public string? TaxGrpType { get; set; }

    public string? InstallNo { get; set; }

    public string? IsOldPa { get; set; }

    public string? EnbNegDoc { get; set; }

    public short? Algo { get; set; }

    public string? ArcComp { get; set; }

    public string? UpdatedTf { get; set; }

    public string? Dardbguid { get; set; }

    public string? NegStoLv { get; set; }

    public string? Spnenabled { get; set; }

    public string? PrsWkCntEb { get; set; }

    public string? DashbdEb { get; set; }

    public DateTime? BoxEffDate { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign2 { get; set; }

    public int? SnapShotId { get; set; }

    public string? CreatedBy { get; set; }

    public string? B1sgtEb { get; set; }

    public string? IsHconEnv { get; set; }

    public string? B1buzzEb { get; set; }

    public string? Imceenable { get; set; }

    public string? DkeyId { get; set; }

    public string? ResetDdata { get; set; }

    public string? ConvDifAct { get; set; }

    public DateTime? BasEffDate { get; set; }

    public string? OldFxAss { get; set; }

    public int? MaxRowsCfl { get; set; }

    public string? ColSel { get; set; }

    public string? EnblSpeduf { get; set; }

    public string? DpmAffTot { get; set; }

    public string? AliasUpd { get; set; }

    public short? TrailDays { get; set; }

    public string? TestComp { get; set; }

    public byte[]? DashConf { get; set; }

    public string? SideEnable { get; set; }

    public string? IsPalinit { get; set; }

    public int? Panaver { get; set; }

    public string? ExpEnable { get; set; }

    public DateTime? LastSsrDat { get; set; }

    public string? LastSsrHsh { get; set; }

    public int? B1iTimeOut { get; set; }

    public string? CpRfshEnbl { get; set; }

    public int? CpRfshIntv { get; set; }

    public string? EnbMbfilt { get; set; }

    public string? CompnyGuid { get; set; }

    public int? ShutTime { get; set; }

    public string? Migrated { get; set; }
}
