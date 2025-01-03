using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class PosTiendacab
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int DocEntry { get; set; }

    public string? Canceled { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public int? UserSign { get; set; }

    public string? Transfered { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UpdateTime { get; set; }

    public string? DataSource { get; set; }

    public string? UDirTienda { get; set; }

    public string? UComTienda { get; set; }

    public string? UCiuTienda { get; set; }

    public string? UFonTienda { get; set; }

    public string? UCorTienda { get; set; }

    public string? USrvTienda { get; set; }

    public string? UBdtienda { get; set; }

    public string? UUsrBdtienda { get; set; }

    public string? UPswBdtienda { get; set; }

    public string? USrvCentral { get; set; }

    public string? UBdcentral { get; set; }

    public string? UUsrBdcentral { get; set; }

    public string? UPswBdcentral { get; set; }

    public string? URutCliTienda { get; set; }

    public string? UNomCliTienda { get; set; }

    public string? UClieModifica { get; set; }

    public string? UCodCtaContraP { get; set; }

    public string? UCodBranch { get; set; }

    public string? UCodCtaCheque { get; set; }

    public string? UCodCtaTransf { get; set; }

    public string? UCodCtaCredito { get; set; }

    public string? UCodCtaLetras { get; set; }

    public string? UCodCtaAjustes { get; set; }

    public string? UCodListaPrec { get; set; }

    public string UOfertasVenta { get; set; } = null!;

    public string UPedidos { get; set; } = null!;

    public string UEntregas { get; set; } = null!;

    public string UDevoluciones { get; set; } = null!;

    public string UAnticipos { get; set; } = null!;

    public string UFacturasCli { get; set; } = null!;

    public string UNccliente { get; set; } = null!;

    public string? UCodCtaContraPsys { get; set; }

    public string? UCodCtaChequeSys { get; set; }

    public string? UCodCtaTransfSys { get; set; }

    public string? UCodCtaCreditoSys { get; set; }

    public string? UCodCtaLetrasSys { get; set; }

    public string? UCodCtaAjustesSys { get; set; }

    public string? UX4rPaistienda { get; set; }

    public string? UX4rEstadotienda { get; set; }

    public string? UX4rTbdtienda { get; set; }

    public string? UX4rTbdcentral { get; set; }

    public string? UX4rProyecto { get; set; }

    public string? UX4rDimension1 { get; set; }

    public string? UX4rDimension2 { get; set; }

    public string? UX4rDimension3 { get; set; }

    public string? UX4rDimension4 { get; set; }

    public string? UX4rDimension5 { get; set; }

    public string? UX4rCodproy { get; set; }

    public string? UX4rCoddim1 { get; set; }

    public string? UX4rCoddim2 { get; set; }

    public string? UX4rCoddim3 { get; set; }

    public string? UX4rCoddim4 { get; set; }

    public string? UX4rCoddim5 { get; set; }

    public string? UX4rPrintpath { get; set; }
}
