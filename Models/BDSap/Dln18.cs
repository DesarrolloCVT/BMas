using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dln18
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjectType { get; set; }

    public int? ExpDocType { get; set; }

    public int? ExpDeclNum { get; set; }

    public DateTime? ExpDeclDat { get; set; }

    public int? ExpNature { get; set; }

    public int? ExpRegNum { get; set; }

    public DateTime? ExpRegDate { get; set; }

    public string? LadBillNum { get; set; }

    public DateTime? LadBillDat { get; set; }

    public DateTime? MerchLeftD { get; set; }

    public int? LadBillTyp { get; set; }

    public string? DrawSreg { get; set; }

    public string? NatureExp { get; set; }

    public decimal? QultExpItm { get; set; }

    public short? NSeqAdic { get; set; }
}
