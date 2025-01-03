using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwDatosFormatosProdExcel
{
    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string Grupo { get; set; } = null!;

    public string? SubCategoria { get; set; }

    public string? Marca { get; set; }

    public string? UmVendida { get; set; }

    public string UmEmbalaje { get; set; } = null!;

    public decimal? UnidxCaja { get; set; }

    public string EmbalajexUnd { get; set; } = null!;

    public string Ean13 { get; set; } = null!;

    public string Dun14 { get; set; } = null!;

    public string? CodProveedor { get; set; }

    public string? ProveedorPred { get; set; }

    public decimal? Peso { get; set; }

    public int? PalletEstandar { get; set; }

    public int? BasePallet { get; set; }
}
