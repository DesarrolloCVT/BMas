using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sri1
{
    public string? ItemCode { get; set; }

    public int SysSerial { get; set; }

    public int? LineNum { get; set; }

    public int? BaseType { get; set; }

    public int? BaseEntry { get; set; }

    public int? BaseNum { get; set; }

    public int? BaseLinNum { get; set; }

    public DateTime? DocDate { get; set; }

    public string? WhsCode { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public int Direction { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ItemName { get; set; }

    public string DataSource { get; set; } = null!;

    public int? UserSign { get; set; }

    public int? BsDocType { get; set; }

    public int? BsDocEntry { get; set; }

    public int? BsDocLine { get; set; }
}
