using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocpc
{
    public int AbsEntry { get; set; }

    public byte[]? Oldcontent { get; set; }

    public byte[]? DiExpoCont { get; set; }
}
