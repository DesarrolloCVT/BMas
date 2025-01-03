using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Isw3
{
    public int WizAbsEnt { get; set; }

    public int Line { get; set; }

    public string? ItemCode { get; set; }

    public string? RowStatus { get; set; }

    public string? CardCode { get; set; }

    public int? ObjType { get; set; }

    public int? DocNum { get; set; }

    public int? DocLineNum { get; set; }

    public string? RecpType { get; set; }

    public DateTime? DocBillDt { get; set; }

    public decimal? Quantity { get; set; }

    public string? Bpctry { get; set; }

    public string? TaxCodeExt { get; set; }

    public string? NetMassSgn { get; set; }

    public decimal? NetMass { get; set; }

    public string? NetMassUnt { get; set; }

    public string? SupMassSgn { get; set; }

    public decimal? SupplMass { get; set; }

    public string? SupplUnit { get; set; }

    public string? ValueSgn { get; set; }

    public decimal? Value { get; set; }

    public decimal? ValueFc { get; set; }

    public string? Fccurrency { get; set; }

    public string? StatValSgn { get; set; }

    public decimal? StatVal { get; set; }

    public string? ReturnId { get; set; }

    public string? Include { get; set; }

    public string? IsChanged { get; set; }

    public string? DstRegCry { get; set; }

    public string? DstRegSta { get; set; }

    public string? OriRegCry { get; set; }

    public string? OriRegSta { get; set; }

    public string? BpVatregNo { get; set; }

    public string? CtryOrig { get; set; }

    public string? Incoterms { get; set; }

    public string? NatOfTrans { get; set; }

    public string? TransMode { get; set; }

    public string? PortEnEx { get; set; }

    public string? CustProc { get; set; }

    public string? StatProc { get; set; }

    public string? DomFrgId { get; set; }

    public string? ItemType { get; set; }

    public string? CommCode { get; set; }

    public string? SerCode { get; set; }

    public string? SerSupplM { get; set; }

    public string? SerPymMeth { get; set; }

    public DateTime? CorrDate { get; set; }

    public string? CorrSgn { get; set; }

    public int? ReferDoc { get; set; }

    public int? ReferDocNo { get; set; }

    public string? ReferItem { get; set; }

    public int? RefDocLine { get; set; }

    public string? ChgId { get; set; }

    public string? ChgUser { get; set; }

    public DateTime? ChgTimest { get; set; }

    public string? Deleted { get; set; }

    public string? CstSecRc { get; set; }

    public short? CorrMonth { get; set; }

    public short? CorrYear { get; set; }

    public int? CorrDeclNo { get; set; }

    public int? CorRowNo { get; set; }

    public int? DeclRowNo { get; set; }

    public int? CorrType { get; set; }

    public string? CntryPay { get; set; }

    public string? Triangular { get; set; }

    public string? CardName { get; set; }

    public string? StatCode { get; set; }

    public int? DocEntry { get; set; }

    public decimal? NetValue { get; set; }

    public decimal? NetValueFc { get; set; }

    public decimal? Freight { get; set; }

    public decimal? FreighFc { get; set; }

    public decimal? RateFc { get; set; }

    public string? Remarks { get; set; }

    public int? ProtocolN { get; set; }

    public string? DropShip { get; set; }

    public string? WhsZipCode { get; set; }

    public decimal? ValBefDsc { get; set; }
}
