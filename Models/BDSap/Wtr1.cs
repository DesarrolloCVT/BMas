﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtr1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? TargetType { get; set; }

    public int? TrgetEntry { get; set; }

    public string? BaseRef { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? LineStatus { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? ShipDate { get; set; }

    public decimal? OpenQty { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? DiscPrcnt { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? OpenSum { get; set; }

    public decimal? OpenSumFc { get; set; }

    public string? VendorNum { get; set; }

    public string? SerialNum { get; set; }

    public string? WhsCode { get; set; }

    public int? SlpCode { get; set; }

    public decimal? Commission { get; set; }

    public string? TreeType { get; set; }

    public string? AcctCode { get; set; }

    public string? TaxStatus { get; set; }

    public decimal? GrossBuyPr { get; set; }

    public decimal? PriceBefDi { get; set; }

    public DateTime? DocDate { get; set; }

    public int? Flags { get; set; }

    public decimal? OpenCreQty { get; set; }

    public string? UseBaseUn { get; set; }

    public string? SubCatNum { get; set; }

    public string? BaseCard { get; set; }

    public decimal? TotalSumSy { get; set; }

    public decimal? OpenSumSys { get; set; }

    public string? InvntSttus { get; set; }

    public string? OcrCode { get; set; }

    public string? Project { get; set; }

    public string? CodeBars { get; set; }

    public decimal? VatPrcnt { get; set; }

    public string? VatGroup { get; set; }

    public decimal? PriceAfVat { get; set; }

    public decimal? Height1 { get; set; }

    public short? Hght1Unit { get; set; }

    public decimal? Height2 { get; set; }

    public short? Hght2Unit { get; set; }

    public decimal? Width1 { get; set; }

    public short? Wdth1Unit { get; set; }

    public decimal? Width2 { get; set; }

    public short? Wdth2Unit { get; set; }

    public decimal? Length1 { get; set; }

    public short? Len1Unit { get; set; }

    public decimal? Length2 { get; set; }

    public short? Len2Unit { get; set; }

    public decimal? Volume { get; set; }

    public short? VolUnit { get; set; }

    public decimal? Weight1 { get; set; }

    public short? Wght1Unit { get; set; }

    public decimal? Weight2 { get; set; }

    public short? Wght2Unit { get; set; }

    public decimal? Factor1 { get; set; }

    public decimal? Factor2 { get; set; }

    public decimal? Factor3 { get; set; }

    public decimal? Factor4 { get; set; }

    public decimal? PackQty { get; set; }

    public string? UpdInvntry { get; set; }

    public int? BaseDocNum { get; set; }

    public string? BaseAtCard { get; set; }

    public string? Sww { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFrgn { get; set; }

    public decimal? VatSumSy { get; set; }

    public int? FinncPriod { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? BlockNum { get; set; }

    public string? ImportLog { get; set; }

    public decimal? DedVatSum { get; set; }

    public decimal? DedVatSumF { get; set; }

    public decimal? DedVatSumS { get; set; }

    public string? IsAqcuistn { get; set; }

    public decimal? DistribSum { get; set; }

    public decimal? DstrbSumFc { get; set; }

    public decimal? DstrbSumSc { get; set; }

    public decimal? GrssProfit { get; set; }

    public decimal? GrssProfSc { get; set; }

    public decimal? GrssProfFc { get; set; }

    public int? VisOrder { get; set; }

    public decimal? Inmprice { get; set; }

    public int? PoTrgNum { get; set; }

    public string? PoTrgEntry { get; set; }

    public string? DropShip { get; set; }

    public int? PoLineNum { get; set; }

    public string? Address { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxType { get; set; }

    public string? OrigItem { get; set; }

    public string? BackOrdr { get; set; }

    public string? FreeTxt { get; set; }

    public string? PickStatus { get; set; }

    public decimal? PickOty { get; set; }

    public int? PickIdNo { get; set; }

    public short? TrnsCode { get; set; }

    public decimal? VatAppld { get; set; }

    public decimal? VatAppldFc { get; set; }

    public decimal? VatAppldSc { get; set; }

    public decimal? BaseQty { get; set; }

    public decimal? BaseOpnQty { get; set; }

    public decimal? VatDscntPr { get; set; }

    public string? WtLiable { get; set; }

    public string? DeferrTax { get; set; }

    public decimal? EquVatPer { get; set; }

    public decimal? EquVatSum { get; set; }

    public decimal? EquVatSumF { get; set; }

    public decimal? EquVatSumS { get; set; }

    public decimal? LineVat { get; set; }

    public decimal? LineVatlF { get; set; }

    public decimal? LineVatS { get; set; }

    public string? UnitMsr { get; set; }

    public decimal? NumPerMsr { get; set; }

    public string? Ceecflag { get; set; }

    public decimal? ToStock { get; set; }

    public decimal? ToDiff { get; set; }

    public decimal? ExciseAmt { get; set; }

    public decimal? TaxPerUnit { get; set; }

    public decimal? TotInclTax { get; set; }

    public string? CountryOrg { get; set; }

    public decimal? StckDstSum { get; set; }

    public decimal? ReleasQtty { get; set; }

    public string? LineType { get; set; }

    public string? TranType { get; set; }

    public string? Text { get; set; }

    public int? OwnerCode { get; set; }

    public decimal? StockPrice { get; set; }

    public string? ConsumeFct { get; set; }

    public decimal? LstByDsSum { get; set; }

    public decimal? StckInmpr { get; set; }

    public decimal? LstBinmpr { get; set; }

    public decimal? StckDstFc { get; set; }

    public decimal? StckDstSc { get; set; }

    public decimal? LstByDsFc { get; set; }

    public decimal? LstByDsSc { get; set; }

    public decimal? StockSum { get; set; }

    public decimal? StockSumFc { get; set; }

    public decimal? StockSumSc { get; set; }

    public decimal? StckSumApp { get; set; }

    public decimal? StckAppFc { get; set; }

    public decimal? StckAppSc { get; set; }

    public string? ShipToCode { get; set; }

    public string? ShipToDesc { get; set; }

    public decimal? StckAppD { get; set; }

    public decimal? StckAppDfc { get; set; }

    public decimal? StckAppDsc { get; set; }

    public string? BasePrice { get; set; }

    public decimal? Gtotal { get; set; }

    public decimal? GtotalFc { get; set; }

    public decimal? GtotalSc { get; set; }

    public string? DistribExp { get; set; }

    public string? DescOw { get; set; }

    public string? DetailsOw { get; set; }

    public short? GrossBase { get; set; }

    public decimal? VatWoDpm { get; set; }

    public decimal? VatWoDpmFc { get; set; }

    public decimal? VatWoDpmSc { get; set; }

    public string? Cfopcode { get; set; }

    public string? Cstcode { get; set; }

    public int? Usage { get; set; }

    public string? TaxOnly { get; set; }

    public string? WtCalced { get; set; }

    public decimal? QtyToShip { get; set; }

    public decimal? DelivrdQty { get; set; }

    public decimal? OrderedQty { get; set; }

    public string? CogsOcrCod { get; set; }

    public int? CiOppLineN { get; set; }

    public string? CogsAcct { get; set; }

    public string? ChgAsmBoMw { get; set; }

    public DateTime? ActDelDate { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public decimal? TaxDistSum { get; set; }

    public decimal? TaxDistSfc { get; set; }

    public decimal? TaxDistSsc { get; set; }

    public string? PostTax { get; set; }

    public string? Excisable { get; set; }

    public decimal? AssblValue { get; set; }

    public int? Rg23apart1 { get; set; }

    public int? Rg23apart2 { get; set; }

    public int? Rg23cpart1 { get; set; }

    public int? Rg23cpart2 { get; set; }

    public string? CogsOcrCo2 { get; set; }

    public string? CogsOcrCo3 { get; set; }

    public string? CogsOcrCo4 { get; set; }

    public string? CogsOcrCo5 { get; set; }

    public string? LnExcised { get; set; }

    public int? LocCode { get; set; }

    public decimal? StockValue { get; set; }

    public decimal? GpttlBasPr { get; set; }

    public string? UnitMsr2 { get; set; }

    public decimal? NumPerMsr2 { get; set; }

    public string? SpecPrice { get; set; }

    public string? CstfIpi { get; set; }

    public string? CstfPis { get; set; }

    public string? CstfCofins { get; set; }

    public string? ExLineNo { get; set; }

    public string? IsSrvCall { get; set; }

    public decimal? PqtreqQty { get; set; }

    public DateTime? PqtreqDate { get; set; }

    public int? PcDocType { get; set; }

    public decimal? PcQuantity { get; set; }

    public string? LinManClsd { get; set; }

    public string? VatGrpSrc { get; set; }

    public string? NoInvtryMv { get; set; }

    public int? ActBaseEnt { get; set; }

    public int? ActBaseLn { get; set; }

    public int? ActBaseNum { get; set; }

    public decimal? OpenRtnQty { get; set; }

    public int? AgrNo { get; set; }

    public int? AgrLnNum { get; set; }

    public string? CredOrigin { get; set; }

    public decimal? Surpluses { get; set; }

    public decimal? DefBreak { get; set; }

    public decimal? Shortages { get; set; }

    public int? UomEntry { get; set; }

    public int? UomEntry2 { get; set; }

    public string? UomCode { get; set; }

    public string? UomCode2 { get; set; }

    public string? FromWhsCod { get; set; }

    public string? NeedQty { get; set; }

    public string? PartRetire { get; set; }

    public decimal? RetireQty { get; set; }

    public decimal? RetireApc { get; set; }

    public decimal? RetirApcfc { get; set; }

    public decimal? RetirApcsc { get; set; }

    public decimal? InvQty { get; set; }

    public decimal? OpenInvQty { get; set; }

    public string? EnSetCost { get; set; }

    public decimal? RetCost { get; set; }

    public int? Incoterms { get; set; }

    public int? TransMod { get; set; }

    public string? LineVendor { get; set; }

    public string? DistribIs { get; set; }

    public decimal? Isdistrb { get; set; }

    public decimal? IsdistrbFc { get; set; }

    public decimal? IsdistrbSc { get; set; }

    public string? IsByPrdct { get; set; }

    public int? ItemType { get; set; }

    public string? PriceEdit { get; set; }

    public int? PrntLnNum { get; set; }

    public string? LinePoPrss { get; set; }

    public string? FreeChrgBp { get; set; }

    public string? TaxRelev { get; set; }

    public string? LegalText { get; set; }

    public string? ThirdParty { get; set; }

    public string? LicTradNum { get; set; }

    public string? InvQtyOnly { get; set; }

    public int? UnencReasn { get; set; }

    public string? ShipFromCo { get; set; }

    public string? ShipFromDe { get; set; }

    public string? FisrtBin { get; set; }

    public string? AllocBinC { get; set; }

    public string? ExpType { get; set; }

    public string? ExpUuid { get; set; }

    public string? ExpOpType { get; set; }

    public string? Diotnat { get; set; }

    public string? Myftype { get; set; }

    public decimal? GpbefDisc { get; set; }

    public short? ReturnRsn { get; set; }

    public short? ReturnAct { get; set; }

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }

    public string? ItmTaxType { get; set; }

    public int? SacEntry { get; set; }

    public int? Ncmcode { get; set; }

    public int? HsnEntry { get; set; }

    public int? OriBabsEnt { get; set; }

    public int? OriBlinNum { get; set; }

    public int? OriBdocTyp { get; set; }

    public string? IsPrscGood { get; set; }

    public string? IsCstmAct { get; set; }

    public string? EncryptIv { get; set; }

    public decimal? ExtTaxRate { get; set; }

    public decimal? ExtTaxSum { get; set; }

    public string? TaxAmtSrc { get; set; }

    public decimal? ExtTaxSumF { get; set; }

    public decimal? ExtTaxSumS { get; set; }

    public int? StdItemId { get; set; }

    public int? CommClass { get; set; }

    public int? VatExEntry { get; set; }

    public short? VatExLn { get; set; }

    public int? NatOfTrans { get; set; }

    public string? IsdtCryImp { get; set; }

    public int? IsdtRgnImp { get; set; }

    public string? IsorCryExp { get; set; }

    public int? IsorRgnExp { get; set; }

    public string? Nvecode { get; set; }

    public string? PoNum { get; set; }

    public int? PoItmNum { get; set; }

    public string? IndEscala { get; set; }

    public int? Cestcode { get; set; }

    public decimal? CtrSealQty { get; set; }

    public string? Cnjpman { get; set; }

    public string? UffiscBene { get; set; }

    public string? Cusplit { get; set; }

    public string? LegalTimd { get; set; }

    public string? LegalTtca { get; set; }

    public string? LegalTw { get; set; }

    public string? LegalTcd { get; set; }

    public string? RevCharge { get; set; }

    public short? ListNum { get; set; }

    public int? UTipoDocRel { get; set; }

    public int? UFolioDocRel { get; set; }

    public string? UMotivoAnula { get; set; }

    public int? UCantRep { get; set; }

    public int? UCantBar { get; set; }

    public string? UItemCodRef { get; set; }

    public string? UExcluir { get; set; }

    public DateTime? UNewduedate { get; set; }

    public string? UNxConcepto { get; set; }

    public decimal? UPriceAfVatbefDi { get; set; }

    public int? UX4rBaseEntry { get; set; }

    public int? UX4rBaseLine { get; set; }

    public string? UIsGrossPrc { get; set; }

    public string? USalUnitMsr { get; set; }

    public int? UX4rDocnumpre { get; set; }
}
