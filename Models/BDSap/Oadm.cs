using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oadm
{
    public string? CompnyName { get; set; }

    public string? CompnyAddr { get; set; }

    public string? Country { get; set; }

    public string? PrintHeadr { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    public string? EMail { get; set; }

    public string? Manager { get; set; }

    public string? CompType { get; set; }

    public string? MainCurncy { get; set; }

    public string? SysCurrncy { get; set; }

    public string? DispPosDeb { get; set; }

    public short? DefLengthU { get; set; }

    public short? DefWeightU { get; set; }

    public string? DfltVendPm { get; set; }

    public string? DirectRate { get; set; }

    public decimal? MinAmnt347 { get; set; }

    public string? AutoItw { get; set; }

    public string? BankCountr { get; set; }

    public string? TaxIdNum { get; set; }

    public string? RevOffice { get; set; }

    public string? FreeZoneNo { get; set; }

    public string? DdctFileNo { get; set; }

    public string? VatCharge { get; set; }

    public string? PayOutVat { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? DpsitPrcnt { get; set; }

    public decimal? IncomeTax { get; set; }

    public string? VendorDdct { get; set; }

    public string? CustmrDdct { get; set; }

    public decimal? DdctPercnt { get; set; }

    public DateTime? DdctExpire { get; set; }

    public string? DdctOffice { get; set; }

    public int? EurepSqntl { get; set; }

    public int? BoxRptSeq { get; set; }

    public string? Wtliable { get; set; }

    public string? DfltCustPm { get; set; }

    public string? AllowFuPos { get; set; }

    public string? UseProdWip { get; set; }

    public string? CurrPeriod { get; set; }

    public string? XmlPath { get; set; }

    public int? DflBnkKey { get; set; }

    public string? Bsinstled { get; set; }

    public string? UseShpdGd { get; set; }

    public string? UseExtRpt { get; set; }

    public string? ErpPerType { get; set; }

    public string? DfSvatExmp { get; set; }

    public string? DfPvatExmp { get; set; }

    public string? Manager1 { get; set; }

    public string? Manager1F { get; set; }

    public string? Ccmask { get; set; }

    public string? ObligLimit { get; set; }

    public string? CreditLimt { get; set; }

    public string? SalesLimit { get; set; }

    public string? DlnLimit { get; set; }

    public string? OrderLimit { get; set; }

    public string? AddDlnBlnc { get; set; }

    public string? CreditDpst { get; set; }

    public string? MultiLang { get; set; }

    public int? DbVers { get; set; }

    public int? ApplVers { get; set; }

    public string? DflWebSite { get; set; }

    public string? DflFtpsite { get; set; }

    public string? UseTax { get; set; }

    public string? RevisionPo { get; set; }

    public string? Reindex { get; set; }

    public string? DllPath { get; set; }

    public string? TaxIdValid { get; set; }

    public string? PchName { get; set; }

    public string? RpcName { get; set; }

    public string? PdnName { get; set; }

    public string? RpdName { get; set; }

    public string? PorName { get; set; }

    public string? LevelWarn { get; set; }

    public string? CrdCommUse { get; set; }

    public string? ItmCommUse { get; set; }

    public string? SlpCommUse { get; set; }

    public short? DfCustTerm { get; set; }

    public short? DfVendTerm { get; set; }

    public string? SaleProfit { get; set; }

    public short? CostPrcLst { get; set; }

    public string? GrossBySal { get; set; }

    public string? TreePricOn { get; set; }

    public string? AddVat { get; set; }

    public string? BaseFld { get; set; }

    public string? ClosedQuot { get; set; }

    public string? UseCode { get; set; }

    public string? Code1 { get; set; }

    public string? Code2 { get; set; }

    public string? Code3 { get; set; }

    public string? Code4 { get; set; }

    public short? Color { get; set; }

    public short? SumDec { get; set; }

    public short? QtyDec { get; set; }

    public short? PriceDec { get; set; }

    public short? RateDec { get; set; }

    public short? PercentDec { get; set; }

    public short? MeasureDec { get; set; }

    public string? DdAutoRun { get; set; }

    public DateTime? DdNextDue { get; set; }

    public short? DdHour { get; set; }

    public string? CmpnyAddrF { get; set; }

    public string? DflTaxCode { get; set; }

    public string? PrintHdrF { get; set; }

    public string? Phone1F { get; set; }

    public string? Phone2F { get; set; }

    public string? FaxF { get; set; }

    public string? ManagerF { get; set; }

    public string? TimeFormat { get; set; }

    public string? CigCup { get; set; }

    public string? DateFormat { get; set; }

    public string? DateSep { get; set; }

    public string? FcNoBlnc { get; set; }

    public string? ChangeRdr { get; set; }

    public string? MultiCurr { get; set; }

    public string? PickParDlv { get; set; }

    public decimal? MaxTaxIncr { get; set; }

    public short? Isrtype { get; set; }

    public decimal? MaxTaxDecr { get; set; }

    public string? RoundRmrk { get; set; }

    public string? IsrbillerI { get; set; }

    public int? UpdStamp { get; set; }

    public string? SysCnoEdit { get; set; }

    public string? RefDnoEdit { get; set; }

    public string? DfltWhs { get; set; }

    public string? TaxDnoEdit { get; set; }

    public string? DfSvatItem { get; set; }

    public string? DfSvatServ { get; set; }

    public string? DfPvatItem { get; set; }

    public string? DfPvatServ { get; set; }

    public string? DoBudget { get; set; }

    public string? CustIdNum { get; set; }

    public string? BgtBlock { get; set; }

    public string? BgtWarning { get; set; }

    public string? BdgtPordoc { get; set; }

    public string? BdgtAcctng { get; set; }

    public int? BdgtDflt { get; set; }

    public string? ContInvnt { get; set; }

    public string? InvntSystm { get; set; }

    public string? ApplicIfrs { get; set; }

    public short? StartYear { get; set; }

    public short? According { get; set; }

    public string? MltpBrnchs { get; set; }

    public string? EnblSrvTax { get; set; }

    public int? DftRcn { get; set; }

    public string? RoundVat { get; set; }

    public string? BdgtPdndoc { get; set; }

    public string? IrsfileNo { get; set; }

    public string? DeferrTax { get; set; }

    public decimal? DflIntrst { get; set; }

    public short? DfltSlp { get; set; }

    public short? DflCrCard { get; set; }

    public string? DflBnkCode { get; set; }

    public string? DflBnkAcct { get; set; }

    public string? DflBranch { get; set; }

    public string? UsePaSys { get; set; }

    public string? ServUsr { get; set; }

    public string? ServPass { get; set; }

    public string? ParamPath { get; set; }

    public string? ExcelPath { get; set; }

    public string? TaxIdNum2 { get; set; }

    public string? TaxIdNum3 { get; set; }

    public string? DecSep { get; set; }

    public string? ThousSep { get; set; }

    public string? CurOnRight { get; set; }

    public string? WarnByWhs { get; set; }

    public int? DflBnkAcKy { get; set; }

    public string? PriceSys { get; set; }

    public int? DftPvl { get; set; }

    public string? UseDdctTrc { get; set; }

    public string? UseDocWrf { get; set; }

    public string? BtchStatus { get; set; }

    public string? OrderBatch { get; set; }

    public string? Glmethod { get; set; }

    public string? SetSriUniq { get; set; }

    public string? SriUniqFld { get; set; }

    public int? MaxHistory { get; set; }

    public string? TaxRateDet { get; set; }

    public string? RefreshQty { get; set; }

    public string? StockNoBas { get; set; }

    public int? MaxCntRows { get; set; }

    public string? CentPmtInc { get; set; }

    public string? CentPmtOut { get; set; }

    public string? ChCtrApact { get; set; }

    public string? ChCtrAract { get; set; }

    public string? PacusrName { get; set; }

    public string? Pacpasswrd { get; set; }

    public string? CaredType { get; set; }

    public string? Pbsnumber { get; set; }

    public string? PbsgroupNo { get; set; }

    public string? OrgNumber { get; set; }

    public string? ActSep { get; set; }

    public string? DspBokpWin { get; set; }

    public string? ShandleWt { get; set; }

    public string? SdfltWt { get; set; }

    public string? IncresGlAc { get; set; }

    public string? PhandleWt { get; set; }

    public string? PdfltWt { get; set; }

    public string? ExWtliabl { get; set; }

    public string? Free84 { get; set; }

    public string? AllowPostZ { get; set; }

    public decimal? PostDiffR { get; set; }

    public string? EnableRo { get; set; }

    public DateTime? UalLastDel { get; set; }

    public int? UalKeepDay { get; set; }

    public string? NegAmount { get; set; }

    public string? EnbDocOpt { get; set; }

    public string? HldCode { get; set; }

    public string? AlphaDoc { get; set; }

    public string? EdocUrl2 { get; set; }

    public string? EnPriceMod { get; set; }

    public string? TaaSenable { get; set; }

    public string? TaaSuser { get; set; }

    public string? OrderBlock { get; set; }

    public string? RoundMthd { get; set; }

    public string? AdrsFromWh { get; set; }

    public string? OrderParty { get; set; }

    public string? CrtfcateNo { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Ninum { get; set; }

    public string? TaaSpass { get; set; }

    public string? TaaSautUrl { get; set; }

    public string? CfwAsnMust { get; set; }

    public int? CfwInDflt { get; set; }

    public int? CfwOutDflt { get; set; }

    public string? TaaSurl { get; set; }

    public string? TaaSsaleAc { get; set; }

    public string? TaxRegime { get; set; }

    public string? AliasName { get; set; }

    public string? DftJpeline { get; set; }

    public string? RdrConfrmd { get; set; }

    public string? PorConfrmd { get; set; }

    public string? TaaSpurcAc { get; set; }

    public string? AdvImagePr { get; set; }

    public int? ChfAcc { get; set; }

    public string? TaxMethod { get; set; }

    public int? Ceo { get; set; }

    public short? WllPprDsp { get; set; }

    public string? WallPaper { get; set; }

    public string? RndToTdec { get; set; }

    public string? SdfltItwt { get; set; }

    public string? PdfltItwt { get; set; }

    public string? CheckFiles { get; set; }

    public string? DsplyRates { get; set; }

    public string? DfActCurr { get; set; }

    public string? DefTaxVend { get; set; }

    public string? RcrFlag { get; set; }

    public string? RclFlag { get; set; }

    public string? ContactLog { get; set; }

    public string? ShowNewMsg { get; set; }

    public string? OpenCdt { get; set; }

    public string? AutoVat { get; set; }

    public string? ConsumeFct { get; set; }

    public string? ConsumeMtd { get; set; }

    public int? DaysBack { get; set; }

    public int? DaysFwrd { get; set; }

    public string? IsPaprn { get; set; }

    public string? ShowNewTsk { get; set; }

    public string? TaxCodeCst { get; set; }

    public string? TaxCodeVnd { get; set; }

    public string? State { get; set; }

    public int? CharMonth { get; set; }

    public string? Free83 { get; set; }

    public short? ScreenLock { get; set; }

    public string? OpenCredit { get; set; }

    public string? OpenDps { get; set; }

    public string? AltBoepost { get; set; }

    public string? LdiscTotal { get; set; }

    public int Code { get; set; }

    public string? DfltDunTrm { get; set; }

    public string? Profession { get; set; }

    public short? AlertPolFr { get; set; }

    public short? DfltCdp { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public string? DflBcacode { get; set; }

    public string? IgrAllCash { get; set; }

    public string? TaxPayerRf { get; set; }

    public string? EmployerRf { get; set; }

    public string? PstatAutCh { get; set; }

    public short? PstatDelay { get; set; }

    public string? RepBusType { get; set; }

    public string? RepBusOthr { get; set; }

    public string? BrachNum { get; set; }

    public string? BuisnesDsc { get; set; }

    public string? ReptMethod { get; set; }

    public string? AcctMethod { get; set; }

    public string? Bookpitype { get; set; }

    public string? ActSoftNam { get; set; }

    public string? OpnClsRmrk { get; set; }

    public string? TaxRndRule { get; set; }

    public string? NegTax { get; set; }

    public string? ZeroLine { get; set; }

    public string? GbopenFile { get; set; }

    public string? Gbintface { get; set; }

    public short? DfltCdpv { get; set; }

    public decimal? OnHldPert { get; set; }

    public string? WtrndRule { get; set; }

    public decimal? GpprcntSrv { get; set; }

    public string? DspFrznBp { get; set; }

    public string? DspFrznItm { get; set; }

    public decimal? WtaccumAmt { get; set; }

    public string? NewDprcus { get; set; }

    public string? ServNature { get; set; }

    public string? PickLimit { get; set; }

    public decimal? WtaccAmtAr { get; set; }

    public string? UseProdPl { get; set; }

    public short? QueryDec { get; set; }

    public string? ExRtDefTax { get; set; }

    public string? BoletoPath { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? MmlastImpD { get; set; }

    public string? CpyExhRate { get; set; }

    public int? MapService { get; set; }

    public int? Odwfreq { get; set; }

    public string? GtsoutPath { get; set; }

    public string? UseMltDims { get; set; }

    public string? Mdstyle { get; set; }

    public string? GtsinPath { get; set; }

    public string? Gtssep { get; set; }

    public int? GtsdftChk { get; set; }

    public int? GtsdftPye { get; set; }

    public decimal? GtsmaxAmt { get; set; }

    public string? RspOverAmt { get; set; }

    public string? Drblock1 { get; set; }

    public string? Drblock2 { get; set; }

    public string? Drblock3 { get; set; }

    public string? Drblock4 { get; set; }

    public string? Drblock5 { get; set; }

    public string? PrjBlock { get; set; }

    public string? SimReport { get; set; }

    public int? SnapShotId { get; set; }

    public string? BackOrder { get; set; }

    public string? Hqlocation { get; set; }

    public string? DigCrtPath { get; set; }

    public short? DflWts { get; set; }

    public string? EnbApprDi { get; set; }

    public string? ChBpserie { get; set; }

    public string? ChItmSerie { get; set; }

    public int? EtrtaxOffi { get; set; }

    public string? EtrtaxPers { get; set; }

    public int? EdocExpFrm { get; set; }

    public string? Pcn874rtyp { get; set; }

    public string? BtwdecProv { get; set; }

    public string? BtwdcPrvId { get; set; }

    public string? Btwname { get; set; }

    public string? Btwstreet { get; set; }

    public string? Btwcity { get; set; }

    public string? Btwzip { get; set; }

    public string? Btwphone { get; set; }

    public int? Btwob { get; set; }

    public int? Btwicp { get; set; }

    public int? Btwobfmt { get; set; }

    public int? Btwicpfmt { get; set; }

    public string? EtrphoneNo { get; set; }

    public string? EdtestMode { get; set; }

    public string? EdocGenTyp { get; set; }

    public int? EdocRptFmt { get; set; }

    public string? EdocPass { get; set; }

    public string? Edprocess { get; set; }

    public string? Pac { get; set; }

    public string? NotifAlert { get; set; }

    public string? NotifEmail { get; set; }

    public int? EdocUdqcat { get; set; }

    public string? EoutputPth { get; set; }

    public int? EdelDocFrm { get; set; }

    public int? EdocPmnFmt { get; set; }

    public string? EdocUrl1 { get; set; }

    public string? EtrfaxNo { get; set; }

    public string? EtrmgrPhn { get; set; }

    public int? Edformat { get; set; }

    public int? Aidformat { get; set; }

    public string? CrtLineRfq { get; set; }

    public string? DflJet { get; set; }

    public string? OnlyPaidIn { get; set; }

    public string? Pddenabled { get; set; }

    public int? MaxDays4Dd { get; set; }

    public string? AutoAddUoM { get; set; }

    public string? AutoAddPkg { get; set; }

    public string? BinActivat { get; set; }

    public short? IssuePriBy { get; set; }

    public string? InstFixAst { get; set; }

    public string? DeprecCalc { get; set; }

    public string? FixAstMod { get; set; }

    public string? SopPath { get; set; }

    public string? NewAcctDe { get; set; }

    public string? ClnZeroPln { get; set; }

    public string? CmdDisBoth { get; set; }

    public int? CnclMaxDay { get; set; }

    public string? AttachPath { get; set; }

    public string? ConfigPath { get; set; }

    public string? WrkshtPath { get; set; }

    public decimal? IcdifExPe1 { get; set; }

    public decimal? IcdifExPe2 { get; set; }

    public string? ClsZoDiffR { get; set; }

    public string? ClsNoConfi { get; set; }

    public string? Dtwpath { get; set; }

    public string? DfltByEml { get; set; }

    public short? CreditDay1 { get; set; }

    public string? Invobprice { get; set; }

    public string? SplitFbsh { get; set; }

    public string? NotifyRqr { get; set; }

    public string? DeactivFa { get; set; }

    public string? CshDctFa { get; set; }

    public string? SendAlert { get; set; }

    public string? BdgtPrqdoc { get; set; }

    public string? IsReuseNum { get; set; }

    public string? IsReuseNfn { get; set; }

    public string? Siplreport { get; set; }

    public string? Sipldoc { get; set; }

    public string? Siplseting { get; set; }

    public string? PriceProcM { get; set; }

    public string? ChkQtyInv { get; set; }

    public string? EnbAdvAtp { get; set; }

    public string? EnblCase { get; set; }

    public string? EnbSupplC { get; set; }

    public string? MbaonPer { get; set; }

    public string? MbaonAp { get; set; }

    public string? MbaonAr { get; set; }

    public string? ApyBsActSp { get; set; }

    public string? ApyBsActPv { get; set; }

    public string? ApyBsActPl { get; set; }

    public string? IsUpdNstdB { get; set; }

    public string? SnBdfltSb { get; set; }

    public string? OneBoneRec { get; set; }

    public string? ReptCurrcy { get; set; }

    public decimal? IcdifExPe3 { get; set; }

    public string? IncsingToV { get; set; }

    public string? PorCbyInc { get; set; }

    public string? EnbNegPym { get; set; }

    public string? SirenNo { get; set; }

    public string? SepacredId { get; set; }

    public string? InstitCode { get; set; }

    public int? Ecdformat { get; set; }

    public string? ApyDrinPec { get; set; }

    public string? ApyPrinPec { get; set; }

    public string? TaxPyerSta { get; set; }

    public int? MaxInvrptR { get; set; }

    public string? DftResWhs { get; set; }

    public string? AutoResWhs { get; set; }

    public string? InActRpt { get; set; }

    public string? InActMkt { get; set; }

    public string? InActPln { get; set; }

    public string? StartFrom { get; set; }

    public short? Months { get; set; }

    public short? Days { get; set; }

    public string? JeinFatran { get; set; }

    public short? Tplid { get; set; }

    public string? TxtSrch { get; set; }

    public string? ApyIbtoAct { get; set; }

    public string? JeUnGroup { get; set; }

    public string? IgnoreAdde { get; set; }

    public string? EnterAsTab { get; set; }

    public string? MouseOnly { get; set; }

    public string? PrjMngmnt { get; set; }

    public string? ElectrDocs { get; set; }

    public string? DotAsSep { get; set; }

    public string? DoMngMth { get; set; }

    public string? AlwBpnown { get; set; }

    public string? EmptyPkl { get; set; }

    public string? ExcNinvItm { get; set; }

    public short? PayRefCalc { get; set; }

    public string? MultiSched { get; set; }

    public string? CloseWipV { get; set; }

    public decimal? OnHldLimt { get; set; }

    public string? EnbApUpDoc { get; set; }

    public string? EnbApUpDft { get; set; }

    public string? EnPacking { get; set; }

    public string? BlockZeroQ { get; set; }

    public string? NegStoLv { get; set; }

    public string? EnUpdBapln { get; set; }

    public string? BaopPor { get; set; }

    public string? BaopPdn { get; set; }

    public string? BaopAcctng { get; set; }

    public string? AssgnObaap { get; set; }

    public string? AssngObaar { get; set; }

    public string? ApyToNewBp { get; set; }

    public string? PrrConfrmd { get; set; }

    public string? RrrConfrmd { get; set; }

    public int? DflSeries { get; set; }

    public string? EnblLc { get; set; }

    public string? DflAcct { get; set; }

    public string? SmtpServer { get; set; }

    public string? SmtpPort { get; set; }

    public string? SmtpName { get; set; }

    public string? SmtpPasswd { get; set; }

    public string? SmtpEncode { get; set; }

    public string? SmtpAuthen { get; set; }

    public string? TlsEncryp { get; set; }

    public string? HtmlDirect { get; set; }

    public string? IncSubject { get; set; }

    public string? TenLevel { get; set; }

    public short? CreditDay2 { get; set; }

    public int? CdtPrvDays { get; set; }

    public string? AuImpRates { get; set; }

    public string? ValidateBa { get; set; }

    public string? ManRemark { get; set; }

    public string? ManRmkType { get; set; }

    public string? ManRmkAlt { get; set; }

    public string? TermsPath { get; set; }

    public int? EdocWsfrm { get; set; }

    public string? DspBuoM { get; set; }

    public string? EdocSname { get; set; }

    public string? EdocSemail { get; set; }

    public string? CpyRulToTx { get; set; }

    public string? BpNoLock { get; set; }

    public string? SearchUrl { get; set; }

    public string? ExpDocLoc { get; set; }

    public string? TenantId { get; set; }

    public string? IntegUrl { get; set; }

    public string? EnableMtd { get; set; }

    public string? PublicComp { get; set; }

    public string? EnableEwb { get; set; }

    public int? TspEntry { get; set; }

    public int? TspLine { get; set; }

    public string? EwbGenType { get; set; }

    public string? VolumeLic { get; set; }

    public decimal? Threshold { get; set; }

    public string? EnAuthUpt { get; set; }

    public string? DfSvatExG { get; set; }

    public string? DfSvatExL { get; set; }

    public string? EnUpdBpAdr { get; set; }

    public string? PautoDueDt { get; set; }

    public short? PduDtMonth { get; set; }

    public string? DriDownBom { get; set; }

    public string? EnExtTax { get; set; }

    public int? DfDateFct { get; set; }

    public string? DfDateUnit { get; set; }

    public string? EnMutiBp { get; set; }

    public string? AddBptoEc { get; set; }

    public string? EnAutoRsz { get; set; }

    public int? QrminSize { get; set; }

    public int? QrmaxSize { get; set; }

    public int? Qrscale { get; set; }

    public int? QrexpDays { get; set; }

    public string? Qrexpir { get; set; }

    public string? QrcorrLvl { get; set; }

    public string? TaxCatVer { get; set; }

    public string? EffPriDisc { get; set; }

    public string? CpyBaseAtc { get; set; }

    public string? ItmDupBcd { get; set; }

    public string? AllowUpdat { get; set; }

    public string? BlkNegJlin { get; set; }

    public string? EnArwtlnMx { get; set; }

    public string? PoArpayCat { get; set; }

    public string? AplyArexhR { get; set; }

    public string? EnApwtlnMx { get; set; }

    public string? PoAppayCat { get; set; }

    public string? AplyApexhR { get; set; }

    public string? DispCtInBp { get; set; }

    public string? UseDfltPl { get; set; }

    public short? DfltCustPl { get; set; }

    public short? DfltVendPl { get; set; }

    public string? Eorinumber { get; set; }

    public string? SkipRutChk { get; set; }

    public string? EnbUqaudit { get; set; }

    public string? CpyBomAtc { get; set; }

    public string? DnOvrwrAtc { get; set; }

    public string? IsTaforMi { get; set; }

    public string? AutoTaappr { get; set; }

    public string? BlockAtt { get; set; }
}
