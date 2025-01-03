using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sra3
{
    public int ActionCode { get; set; }

    public int RecipCode { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public string? Name { get; set; }

    public string? SendInter { get; set; }

    public string? SendEmail { get; set; }

    public string? SendSms { get; set; }

    public string? Email { get; set; }

    public string? Number { get; set; }

    public string? AttachDag { get; set; }

    public string? AttachPdf { get; set; }

    public string? AttachHtml { get; set; }

    public string? AttachXml { get; set; }

    public string? ShowResult { get; set; }
}
