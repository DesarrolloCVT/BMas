using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oqrc
{
    public int AbsEntry { get; set; }

    public byte[]? FileContnt { get; set; }

    public int SrcObjType { get; set; }

    public string SrcObjAbs { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public short? ExpAfter { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTs { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateTs { get; set; }
}
