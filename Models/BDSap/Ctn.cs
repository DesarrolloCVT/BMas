using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ctn
{
    public int AbsId { get; set; }

    public string ObjectId { get; set; } = null!;

    public string? EnableAsyN { get; set; }

    public string? EnableTn { get; set; }

    public string? EnablePtn { get; set; }
}
