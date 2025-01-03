using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NuevoBMas.Models.BDLogin;

public partial class DbContextLogin : DbContext
{
    public DbContextLogin()
    {
    }

    public DbContextLogin(DbContextOptions<DbContextLogin> options)
        : base(options)
    {
    }

    public virtual DbSet<AreaDevolucion> AreaDevolucions { get; set; }

    public virtual DbSet<BmasListadoVentasPbi> BmasListadoVentasPbis { get; set; }

    public virtual DbSet<CvtAccesoCamion> CvtAccesoCamions { get; set; }

    public virtual DbSet<CvtActivoFijo> CvtActivoFijos { get; set; }

    public virtual DbSet<CvtAcuerdoComercial> CvtAcuerdoComercials { get; set; }

    public virtual DbSet<CvtAcuerdoComercialDetalle> CvtAcuerdoComercialDetalles { get; set; }

    public virtual DbSet<CvtAfCalculoPeriodo> CvtAfCalculoPeriodos { get; set; }

    public virtual DbSet<CvtAfIndiceReajustabilidad> CvtAfIndiceReajustabilidads { get; set; }

    public virtual DbSet<CvtAgendaSalida> CvtAgendaSalidas { get; set; }

    public virtual DbSet<CvtAgendamiento> CvtAgendamientos { get; set; }

    public virtual DbSet<CvtAgendamientoAcesso> CvtAgendamientoAcessos { get; set; }

    public virtual DbSet<CvtAgendamientoLinea> CvtAgendamientoLineas { get; set; }

    public virtual DbSet<CvtAnalisisCostoDiario> CvtAnalisisCostoDiarios { get; set; }

    public virtual DbSet<CvtAreaHigiene> CvtAreaHigienes { get; set; }

    public virtual DbSet<CvtAreaNoConformidad> CvtAreaNoConformidads { get; set; }

    public virtual DbSet<CvtAreaTrabajo> CvtAreaTrabajos { get; set; }

    public virtual DbSet<CvtArmadoCaja> CvtArmadoCajas { get; set; }

    public virtual DbSet<CvtArmador> CvtArmadors { get; set; }

    public virtual DbSet<CvtArticulo> CvtArticulos { get; set; }

    public virtual DbSet<CvtArticuloDocumento> CvtArticuloDocumentos { get; set; }

    public virtual DbSet<CvtAseoDiarioProduccion> CvtAseoDiarioProduccions { get; set; }

    public virtual DbSet<CvtAsignacionFoliosCheque> CvtAsignacionFoliosCheques { get; set; }

    public virtual DbSet<CvtAsignacionRutum> CvtAsignacionRuta { get; set; }

    public virtual DbSet<CvtAsistenciaJbd> CvtAsistenciaJbds { get; set; }

    public virtual DbSet<CvtAsistenciaRelojControl> CvtAsistenciaRelojControls { get; set; }

    public virtual DbSet<CvtAsistencium> CvtAsistencia { get; set; }

    public virtual DbSet<CvtAspectoPregunta> CvtAspectoPreguntas { get; set; }

    public virtual DbSet<CvtAuditoriaRecepcione> CvtAuditoriaRecepciones { get; set; }

    public virtual DbSet<CvtBitacoraProyecto> CvtBitacoraProyectos { get; set; }

    public virtual DbSet<CvtBulto> CvtBultos { get; set; }

    public virtual DbSet<CvtCaProveedoresNacionale> CvtCaProveedoresNacionales { get; set; }

    public virtual DbSet<CvtCabeceraInventario> CvtCabeceraInventarios { get; set; }

    public virtual DbSet<CvtCamionCarga> CvtCamionCargas { get; set; }

    public virtual DbSet<CvtCamionCargaDet> CvtCamionCargaDets { get; set; }

    public virtual DbSet<CvtCapacidadUbicacionesWm> CvtCapacidadUbicacionesWms { get; set; }

    public virtual DbSet<CvtCategoriaDetencione> CvtCategoriaDetenciones { get; set; }

    public virtual DbSet<CvtCategoriaGastoCamion> CvtCategoriaGastoCamions { get; set; }

    public virtual DbSet<CvtCategoriaHallazgoMe> CvtCategoriaHallazgoMes { get; set; }

    public virtual DbSet<CvtCfgEstructuraLotesCab> CvtCfgEstructuraLotesCabs { get; set; }

    public virtual DbSet<CvtCfgEstructuraLotesDatum> CvtCfgEstructuraLotesData { get; set; }

    public virtual DbSet<CvtCfgEstructuraLotesDet> CvtCfgEstructuraLotesDets { get; set; }

    public virtual DbSet<CvtCheckListArmadoPedido> CvtCheckListArmadoPedidos { get; set; }

    public virtual DbSet<CvtChecklistGrua> CvtChecklistGruas { get; set; }

    public virtual DbSet<CvtChequeMontoSeparado> CvtChequeMontoSeparados { get; set; }

    public virtual DbSet<CvtCmbGrupoProductoCompraImpVistum> CvtCmbGrupoProductoCompraImpVista { get; set; }

    public virtual DbSet<CvtCmbProductosCompraImpVistum> CvtCmbProductosCompraImpVista { get; set; }

    public virtual DbSet<CvtCmbProveedorCompraImpVistum> CvtCmbProveedorCompraImpVista { get; set; }

    public virtual DbSet<CvtCobranzaCvtBma> CvtCobranzaCvtBmas { get; set; }

    public virtual DbSet<CvtComisionVendedor> CvtComisionVendedors { get; set; }

    public virtual DbSet<CvtComparativoVenta> CvtComparativoVentas { get; set; }

    public virtual DbSet<CvtCompromisoKit> CvtCompromisoKits { get; set; }

    public virtual DbSet<CvtCompromisoKitdetalle> CvtCompromisoKitdetalles { get; set; }

    public virtual DbSet<CvtConfGrupoArticulo> CvtConfGrupoArticulos { get; set; }

    public virtual DbSet<CvtContenedorCarga> CvtContenedorCargas { get; set; }

    public virtual DbSet<CvtContenedorCargaDet> CvtContenedorCargaDets { get; set; }

    public virtual DbSet<CvtContenedorCargaDetPalletUnico> CvtContenedorCargaDetPalletUnicos { get; set; }

    public virtual DbSet<CvtContenedore> CvtContenedores { get; set; }

    public virtual DbSet<CvtContorlEnvasadoPtPuestaEnMarchaLinea> CvtContorlEnvasadoPtPuestaEnMarchaLineas { get; set; }

    public virtual DbSet<CvtControlAcceso> CvtControlAccesos { get; set; }

    public virtual DbSet<CvtControlAccesoCamion> CvtControlAccesoCamions { get; set; }

    public virtual DbSet<CvtControlAccesoChofer> CvtControlAccesoChofers { get; set; }

    public virtual DbSet<CvtControlAccesoVisitum> CvtControlAccesoVisita { get; set; }

    public virtual DbSet<CvtControlBodega> CvtControlBodegas { get; set; }

    public virtual DbSet<CvtControlEnvasadoPt> CvtControlEnvasadoPts { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtAseoDiario> CvtControlEnvasadoPtAseoDiarios { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtControlPesoLinea> CvtControlEnvasadoPtControlPesoLineas { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtDetalle> CvtControlEnvasadoPtDetalles { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtMotivoMerma> CvtControlEnvasadoPtMotivoMermas { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtPuestaEnMarchaEnvasadora> CvtControlEnvasadoPtPuestaEnMarchaEnvasadoras { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtPuestaEnMarchaMaquina> CvtControlEnvasadoPtPuestaEnMarchaMaquinas { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtPuestaEnMarchaMonitoreo> CvtControlEnvasadoPtPuestaEnMarchaMonitoreos { get; set; }

    public virtual DbSet<CvtControlEnvasadoPtUsoCintaImpresion> CvtControlEnvasadoPtUsoCintaImpresions { get; set; }

    public virtual DbSet<CvtControlFosfina> CvtControlFosfinas { get; set; }

    public virtual DbSet<CvtControlHigene> CvtControlHigenes { get; set; }

    public virtual DbSet<CvtControlLineasPacking> CvtControlLineasPackings { get; set; }

    public virtual DbSet<CvtControlPesoPallet> CvtControlPesoPallets { get; set; }

    public virtual DbSet<CvtControlPesoProductoPalletizado> CvtControlPesoProductoPalletizados { get; set; }

    public virtual DbSet<CvtControlPesoProductoPalletizadoDetalle> CvtControlPesoProductoPalletizadoDetalles { get; set; }

    public virtual DbSet<CvtControlPesoPt> CvtControlPesoPts { get; set; }

    public virtual DbSet<CvtCostoKmtransporte> CvtCostoKmtransportes { get; set; }

    public virtual DbSet<CvtCostoPorCamion> CvtCostoPorCamions { get; set; }

    public virtual DbSet<CvtDescripcionDeCamione> CvtDescripcionDeCamiones { get; set; }

    public virtual DbSet<CvtDescripcionVehiculo> CvtDescripcionVehiculos { get; set; }

    public virtual DbSet<CvtDesechosporgrupo> CvtDesechosporgrupos { get; set; }

    public virtual DbSet<CvtDetalleCostosImportacion> CvtDetalleCostosImportacions { get; set; }

    public virtual DbSet<CvtDetalleGastosCamion> CvtDetalleGastosCamions { get; set; }

    public virtual DbSet<CvtDetalleInventario> CvtDetalleInventarios { get; set; }

    public virtual DbSet<CvtDetalleMovimientoMantencion> CvtDetalleMovimientoMantencions { get; set; }

    public virtual DbSet<CvtDetalleNoConformidad> CvtDetalleNoConformidads { get; set; }

    public virtual DbSet<CvtDetalleRapel> CvtDetalleRapels { get; set; }

    public virtual DbSet<CvtDetencion> CvtDetencions { get; set; }

    public virtual DbSet<CvtDocControlAcceso> CvtDocControlAccesos { get; set; }

    public virtual DbSet<CvtEficienciaEnvasadoPbi> CvtEficienciaEnvasadoPbis { get; set; }

    public virtual DbSet<CvtElemento> CvtElementos { get; set; }

    public virtual DbSet<CvtEmpleadoSueldoBase> CvtEmpleadoSueldoBases { get; set; }

    public virtual DbSet<CvtEmpresasNegocio> CvtEmpresasNegocios { get; set; }

    public virtual DbSet<CvtEntidad> CvtEntidads { get; set; }

    public virtual DbSet<CvtEntradaInsumo> CvtEntradaInsumos { get; set; }

    public virtual DbSet<CvtEntradaInsumosDetalle> CvtEntradaInsumosDetalles { get; set; }

    public virtual DbSet<CvtEquipo> CvtEquipos { get; set; }

    public virtual DbSet<CvtEstadisticaGasto> CvtEstadisticaGastos { get; set; }

    public virtual DbSet<CvtEstadoActividad> CvtEstadoActividads { get; set; }

    public virtual DbSet<CvtEstadosProcesoIntegra> CvtEstadosProcesoIntegras { get; set; }

    public virtual DbSet<CvtEtiquetaFilm> CvtEtiquetaFilms { get; set; }

    public virtual DbSet<CvtExpedicionesTransformada> CvtExpedicionesTransformadas { get; set; }

    public virtual DbSet<CvtFilmBobina> CvtFilmBobinas { get; set; }

    public virtual DbSet<CvtFilmDevolucion> CvtFilmDevolucions { get; set; }

    public virtual DbSet<CvtFilmDevolucionDetalle> CvtFilmDevolucionDetalles { get; set; }

    public virtual DbSet<CvtFilmExpedicion> CvtFilmExpedicions { get; set; }

    public virtual DbSet<CvtFilmExpedicionDetalle> CvtFilmExpedicionDetalles { get; set; }

    public virtual DbSet<CvtFilmRecepcion> CvtFilmRecepcions { get; set; }

    public virtual DbSet<CvtFilmRepaletizado> CvtFilmRepaletizados { get; set; }

    public virtual DbSet<CvtFilmSolicitudTransferenciaDetalle> CvtFilmSolicitudTransferenciaDetalles { get; set; }

    public virtual DbSet<CvtFilmSolicitudTransferencium> CvtFilmSolicitudTransferencia { get; set; }

    public virtual DbSet<CvtFilmTransferenciaDetalle> CvtFilmTransferenciaDetalles { get; set; }

    public virtual DbSet<CvtFilmTransferencium> CvtFilmTransferencia { get; set; }

    public virtual DbSet<CvtGestionExternosBono> CvtGestionExternosBonos { get; set; }

    public virtual DbSet<CvtGestionExternosBonoJdb> CvtGestionExternosBonoJdbs { get; set; }

    public virtual DbSet<CvtGrua> CvtGruas { get; set; }

    public virtual DbSet<CvtHomologacionMonedaBancoCentral> CvtHomologacionMonedaBancoCentrals { get; set; }

    public virtual DbSet<CvtHorariosSalida> CvtHorariosSalidas { get; set; }

    public virtual DbSet<CvtHorasExtra> CvtHorasExtras { get; set; }

    public virtual DbSet<CvtImpresoraServ> CvtImpresoraServs { get; set; }

    public virtual DbSet<CvtInfAdjuntosInventarioEquipo> CvtInfAdjuntosInventarioEquipos { get; set; }

    public virtual DbSet<CvtInfAlarma> CvtInfAlarmas { get; set; }

    public virtual DbSet<CvtInfAlarmasDetalle> CvtInfAlarmasDetalles { get; set; }

    public virtual DbSet<CvtInfAlarmasHikvision> CvtInfAlarmasHikvisions { get; set; }

    public virtual DbSet<CvtInfBajadaEquipo> CvtInfBajadaEquipos { get; set; }

    public virtual DbSet<CvtInfComputador> CvtInfComputadors { get; set; }

    public virtual DbSet<CvtInfConexionRemotum> CvtInfConexionRemota { get; set; }

    public virtual DbSet<CvtInfCorreo> CvtInfCorreos { get; set; }

    public virtual DbSet<CvtInfEntregaInsumosImpresora> CvtInfEntregaInsumosImpresoras { get; set; }

    public virtual DbSet<CvtInfEntregaPeriferico> CvtInfEntregaPerifericos { get; set; }

    public virtual DbSet<CvtInfEntregaPerifericosDetalle> CvtInfEntregaPerifericosDetalles { get; set; }

    public virtual DbSet<CvtInfEqRed> CvtInfEqReds { get; set; }

    public virtual DbSet<CvtInfEqRespaldoEnergium> CvtInfEqRespaldoEnergia { get; set; }

    public virtual DbSet<CvtInfEqWireless> CvtInfEqWirelesses { get; set; }

    public virtual DbSet<CvtInfEquiposMovile> CvtInfEquiposMoviles { get; set; }

    public virtual DbSet<CvtInfFormEntregaCelulare> CvtInfFormEntregaCelulares { get; set; }

    public virtual DbSet<CvtInfImpresora> CvtInfImpresoras { get; set; }

    public virtual DbSet<CvtInfLineasMovile> CvtInfLineasMoviles { get; set; }

    public virtual DbSet<CvtInfMantencionDescripcion> CvtInfMantencionDescripcions { get; set; }

    public virtual DbSet<CvtInfMantencionEncabezado> CvtInfMantencionEncabezados { get; set; }

    public virtual DbSet<CvtInfMantencionRepuesto> CvtInfMantencionRepuestos { get; set; }

    public virtual DbSet<CvtInfMantencionTipo> CvtInfMantencionTipos { get; set; }

    public virtual DbSet<CvtInfMarca> CvtInfMarcas { get; set; }

    public virtual DbSet<CvtInfMonitore> CvtInfMonitores { get; set; }

    public virtual DbSet<CvtInfOtroEq> CvtInfOtroEqs { get; set; }

    public virtual DbSet<CvtInfPeriferico> CvtInfPerifericos { get; set; }

    public virtual DbSet<CvtInfPlanesMovile> CvtInfPlanesMoviles { get; set; }

    public virtual DbSet<CvtInfRadioFrecuencium> CvtInfRadioFrecuencia { get; set; }

    public virtual DbSet<CvtInfServidor> CvtInfServidors { get; set; }

    public virtual DbSet<CvtInfSistemaOperativo> CvtInfSistemaOperativos { get; set; }

    public virtual DbSet<CvtInfTelefoniaFija> CvtInfTelefoniaFijas { get; set; }

    public virtual DbSet<CvtInfTipoDispositivo> CvtInfTipoDispositivos { get; set; }

    public virtual DbSet<CvtInfToner> CvtInfToners { get; set; }

    public virtual DbSet<CvtInfVideoVigilancium> CvtInfVideoVigilancia { get; set; }

    public virtual DbSet<CvtInspeccionPtArroz> CvtInspeccionPtArrozs { get; set; }

    public virtual DbSet<CvtInspeccionPtArrozDetalle> CvtInspeccionPtArrozDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtArveja> CvtInspeccionPtArvejas { get; set; }

    public virtual DbSet<CvtInspeccionPtArvejaDetalle> CvtInspeccionPtArvejaDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtAzucar> CvtInspeccionPtAzucars { get; set; }

    public virtual DbSet<CvtInspeccionPtAzucarDetalle> CvtInspeccionPtAzucarDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtGarbanzo> CvtInspeccionPtGarbanzos { get; set; }

    public virtual DbSet<CvtInspeccionPtGarbanzoDetalle> CvtInspeccionPtGarbanzoDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtLenteja> CvtInspeccionPtLentejas { get; set; }

    public virtual DbSet<CvtInspeccionPtLentejaDetalle> CvtInspeccionPtLentejaDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtPoroto> CvtInspeccionPtPorotos { get; set; }

    public virtual DbSet<CvtInspeccionPtPorotoNegro> CvtInspeccionPtPorotoNegros { get; set; }

    public virtual DbSet<CvtInspeccionPtPorotoNegroDetalle> CvtInspeccionPtPorotoNegroDetalles { get; set; }

    public virtual DbSet<CvtInspeccionPtPorotosDetalle> CvtInspeccionPtPorotosDetalles { get; set; }

    public virtual DbSet<CvtInspeccionVisualMalla> CvtInspeccionVisualMallas { get; set; }

    public virtual DbSet<CvtInspeccionVisualSaco> CvtInspeccionVisualSacos { get; set; }

    public virtual DbSet<CvtInventarioEstadoDet> CvtInventarioEstadoDets { get; set; }

    public virtual DbSet<CvtInventarioEstadoProducto> CvtInventarioEstadoProductos { get; set; }

    public virtual DbSet<CvtInventarioPbi> CvtInventarioPbis { get; set; }

    public virtual DbSet<CvtLaboresArchivo> CvtLaboresArchivos { get; set; }

    public virtual DbSet<CvtLaboresExterna> CvtLaboresExternas { get; set; }

    public virtual DbSet<CvtLaboresTurno> CvtLaboresTurnos { get; set; }

    public virtual DbSet<CvtLaboresTurnoDetalle> CvtLaboresTurnoDetalles { get; set; }

    public virtual DbSet<CvtLaboresTurnoRecepcione> CvtLaboresTurnoRecepciones { get; set; }

    public virtual DbSet<CvtLibroNovedade> CvtLibroNovedades { get; set; }

    public virtual DbSet<CvtLineasProduccion> CvtLineasProduccions { get; set; }

    public virtual DbSet<CvtListadoClientesPbi> CvtListadoClientesPbis { get; set; }

    public virtual DbSet<CvtListadoCobranzaPbi> CvtListadoCobranzaPbis { get; set; }

    public virtual DbSet<CvtListadoDesechosporgrupopbi> CvtListadoDesechosporgrupopbis { get; set; }

    public virtual DbSet<CvtListadoOfDetencion> CvtListadoOfDetencions { get; set; }

    public virtual DbSet<CvtListadoProductosPbi> CvtListadoProductosPbis { get; set; }

    public virtual DbSet<CvtListadoRegionesPbi> CvtListadoRegionesPbis { get; set; }

    public virtual DbSet<CvtListadoVendedoresPbi> CvtListadoVendedoresPbis { get; set; }

    public virtual DbSet<CvtListadoVentasPbi> CvtListadoVentasPbis { get; set; }

    public virtual DbSet<CvtLogErrorInforme> CvtLogErrorInformes { get; set; }

    public virtual DbSet<CvtLogPrecioEntrega> CvtLogPrecioEntregas { get; set; }

    public virtual DbSet<CvtLogRegistroPrecioEntrega> CvtLogRegistroPrecioEntregas { get; set; }

    public virtual DbSet<CvtLogSistema> CvtLogSistemas { get; set; }

    public virtual DbSet<CvtLogUtilidade> CvtLogUtilidades { get; set; }

    public virtual DbSet<CvtLogtrx> CvtLogtrxes { get; set; }

    public virtual DbSet<CvtLotesBloqueadosSap> CvtLotesBloqueadosSaps { get; set; }

    public virtual DbSet<CvtLotesDefinidosPorTrx> CvtLotesDefinidosPorTrxes { get; set; }

    public virtual DbSet<CvtMailingInforme> CvtMailingInformes { get; set; }

    public virtual DbSet<CvtMaquinaComponente> CvtMaquinaComponentes { get; set; }

    public virtual DbSet<CvtMenu> CvtMenus { get; set; }

    public virtual DbSet<CvtMenuXamarin> CvtMenuXamarins { get; set; }

    public virtual DbSet<CvtMenusXperfil> CvtMenusXperfils { get; set; }

    public virtual DbSet<CvtMezclaProductoUbicacion> CvtMezclaProductoUbicacions { get; set; }

    public virtual DbSet<CvtMonitoreoDetectorMetalesDo> CvtMonitoreoDetectorMetalesDos { get; set; }

    public virtual DbSet<CvtMonitoreoDetectorMetalesUno> CvtMonitoreoDetectorMetalesUnos { get; set; }

    public virtual DbSet<CvtMotivoDentecion> CvtMotivoDentecions { get; set; }

    public virtual DbSet<CvtMotivoDevolucion> CvtMotivoDevolucions { get; set; }

    public virtual DbSet<CvtMovimientoMantencion> CvtMovimientoMantencions { get; set; }

    public virtual DbSet<CvtNoConformidade> CvtNoConformidades { get; set; }

    public virtual DbSet<CvtNotaMargen> CvtNotaMargens { get; set; }

    public virtual DbSet<CvtNotificacione> CvtNotificaciones { get; set; }

    public virtual DbSet<CvtNotificacionesUsuario> CvtNotificacionesUsuarios { get; set; }

    public virtual DbSet<CvtObjeto> CvtObjetos { get; set; }

    public virtual DbSet<CvtOcabiertasEerr> CvtOcabiertasEerrs { get; set; }

    public virtual DbSet<CvtOrdenDeVenta> CvtOrdenDeVentas { get; set; }

    public virtual DbSet<CvtOrderAsignacion> CvtOrderAsignacions { get; set; }

    public virtual DbSet<CvtParamReporteTrazabilidad> CvtParamReporteTrazabilidads { get; set; }

    public virtual DbSet<CvtParametrosproduccion> CvtParametrosproduccions { get; set; }

    public virtual DbSet<CvtPeonetaControlAcceso> CvtPeonetaControlAccesos { get; set; }

    public virtual DbSet<CvtPerfilUsuario> CvtPerfilUsuarios { get; set; }

    public virtual DbSet<CvtPeriodo> CvtPeriodos { get; set; }

    public virtual DbSet<CvtPermisoTrabajoSeguro> CvtPermisoTrabajoSeguros { get; set; }

    public virtual DbSet<CvtPermisoTrabajoSeguroAst> CvtPermisoTrabajoSeguroAsts { get; set; }

    public virtual DbSet<CvtPermisoTrabajoSeguroPt> CvtPermisoTrabajoSeguroPts { get; set; }

    public virtual DbSet<CvtPermisosSistInterno> CvtPermisosSistInternos { get; set; }

    public virtual DbSet<CvtPersonal> CvtPersonals { get; set; }

    public virtual DbSet<CvtPlanMantencionEncabezado> CvtPlanMantencionEncabezados { get; set; }

    public virtual DbSet<CvtPlanMantencionHerramientum> CvtPlanMantencionHerramienta { get; set; }

    public virtual DbSet<CvtPlanMantencionMaquina> CvtPlanMantencionMaquinas { get; set; }

    public virtual DbSet<CvtPlanMantencionParte> CvtPlanMantencionPartes { get; set; }

    public virtual DbSet<CvtPlanMantencionPieza> CvtPlanMantencionPiezas { get; set; }

    public virtual DbSet<CvtPlanMantencionRepuesto> CvtPlanMantencionRepuestos { get; set; }

    public virtual DbSet<CvtPlanMantencionRrhh> CvtPlanMantencionRrhhs { get; set; }

    public virtual DbSet<CvtPlanificacionMantencion> CvtPlanificacionMantencions { get; set; }

    public virtual DbSet<CvtPlanillaInsumo> CvtPlanillaInsumos { get; set; }

    public virtual DbSet<CvtPlanillaInsumosDetalle> CvtPlanillaInsumosDetalles { get; set; }

    public virtual DbSet<CvtPorcentajeRapel> CvtPorcentajeRapels { get; set; }

    public virtual DbSet<CvtPosicionesConExcesoBulto> CvtPosicionesConExcesoBultos { get; set; }

    public virtual DbSet<CvtPreRecepcion> CvtPreRecepcions { get; set; }

    public virtual DbSet<CvtPreguntaEncuestum> CvtPreguntaEncuesta { get; set; }

    public virtual DbSet<CvtPreparaPedidoBodega> CvtPreparaPedidoBodegas { get; set; }

    public virtual DbSet<CvtPresupuestoCanalVenta> CvtPresupuestoCanalVentas { get; set; }

    public virtual DbSet<CvtPresupuestoCliente> CvtPresupuestoClientes { get; set; }

    public virtual DbSet<CvtPresupuestoDetalle> CvtPresupuestoDetalles { get; set; }

    public virtual DbSet<CvtPresupuestoInformeVendedorAño> CvtPresupuestoInformeVendedorAños { get; set; }

    public virtual DbSet<CvtPresupuestoVendedor> CvtPresupuestoVendedors { get; set; }

    public virtual DbSet<CvtPresupuestoVenta> CvtPresupuestoVentas { get; set; }

    public virtual DbSet<CvtPrivilegioPerfil> CvtPrivilegioPerfils { get; set; }

    public virtual DbSet<CvtPrivilegiosPerfilXamarin> CvtPrivilegiosPerfilXamarins { get; set; }

    public virtual DbSet<CvtProcesoAdicional> CvtProcesoAdicionals { get; set; }

    public virtual DbSet<CvtProcesoAdicionalDetalle> CvtProcesoAdicionalDetalles { get; set; }

    public virtual DbSet<CvtProdPorcRapel> CvtProdPorcRapels { get; set; }

    public virtual DbSet<CvtProductoBloqueado> CvtProductoBloqueados { get; set; }

    public virtual DbSet<CvtProductoBloqueadoDetalle> CvtProductoBloqueadoDetalles { get; set; }

    public virtual DbSet<CvtProductoTipoBloqueo> CvtProductoTipoBloqueos { get; set; }

    public virtual DbSet<CvtRechazosDetertorMetale> CvtRechazosDetertorMetales { get; set; }

    public virtual DbSet<CvtReclamo> CvtReclamos { get; set; }

    public virtual DbSet<CvtReclamoArchivo> CvtReclamoArchivos { get; set; }

    public virtual DbSet<CvtReclamoDestinatario> CvtReclamoDestinatarios { get; set; }

    public virtual DbSet<CvtReclamoDetalleProd> CvtReclamoDetalleProds { get; set; }

    public virtual DbSet<CvtRecurso> CvtRecursos { get; set; }

    public virtual DbSet<CvtRecursoMantencion> CvtRecursoMantencions { get; set; }

    public virtual DbSet<CvtRegEstadoCamionesCruzado> CvtRegEstadoCamionesCruzados { get; set; }

    public virtual DbSet<CvtRegion> CvtRegions { get; set; }

    public virtual DbSet<CvtRegistroAmonestacion> CvtRegistroAmonestacions { get; set; }

    public virtual DbSet<CvtRegistroAmonestacionPersona> CvtRegistroAmonestacionPersonas { get; set; }

    public virtual DbSet<CvtRegistroCamion> CvtRegistroCamions { get; set; }

    public virtual DbSet<CvtRegistroCargaCombustible> CvtRegistroCargaCombustibles { get; set; }

    public virtual DbSet<CvtRegistroCargaCombustibleJefatura> CvtRegistroCargaCombustibleJefaturas { get; set; }

    public virtual DbSet<CvtRegistroCargaUrea> CvtRegistroCargaUreas { get; set; }

    public virtual DbSet<CvtRegistroCompraUrea> CvtRegistroCompraUreas { get; set; }

    public virtual DbSet<CvtRegistroFallaGrua> CvtRegistroFallaGruas { get; set; }

    public virtual DbSet<CvtRegistroFumigacion> CvtRegistroFumigacions { get; set; }

    public virtual DbSet<CvtRegistroHallazgoMateriaExtraña> CvtRegistroHallazgoMateriaExtrañas { get; set; }

    public virtual DbSet<CvtRegistroHigienePlantum> CvtRegistroHigienePlanta { get; set; }

    public virtual DbSet<CvtRegistroIncidenciaMovistar> CvtRegistroIncidenciaMovistars { get; set; }

    public virtual DbSet<CvtRegistroOdometro> CvtRegistroOdometros { get; set; }

    public virtual DbSet<CvtRegistroPatronTestigo> CvtRegistroPatronTestigos { get; set; }

    public virtual DbSet<CvtRegistroRechazoPncSubCatNc> CvtRegistroRechazoPncSubCatNcs { get; set; }

    public virtual DbSet<CvtRegistroRechazoProductoNoConforme> CvtRegistroRechazoProductoNoConformes { get; set; }

    public virtual DbSet<CvtRegistroRevisionCamionFactura> CvtRegistroRevisionCamionFacturas { get; set; }

    public virtual DbSet<CvtRegistroRevisionCamione> CvtRegistroRevisionCamiones { get; set; }

    public virtual DbSet<CvtRegistroSaturacionPatrone> CvtRegistroSaturacionPatrones { get; set; }

    public virtual DbSet<CvtRegistroSaturacionPatronesAntiguo> CvtRegistroSaturacionPatronesAntiguos { get; set; }

    public virtual DbSet<CvtRegistroTarea> CvtRegistroTareas { get; set; }

    public virtual DbSet<CvtRegistroVerificacionBolsa> CvtRegistroVerificacionBolsas { get; set; }

    public virtual DbSet<CvtRegistroVerificacionBolsasDetalle> CvtRegistroVerificacionBolsasDetalles { get; set; }

    public virtual DbSet<CvtRelacionGrupoFamilium> CvtRelacionGrupoFamilia { get; set; }

    public virtual DbSet<CvtRendicionCosto> CvtRendicionCostos { get; set; }

    public virtual DbSet<CvtRendicionCostosDetalle> CvtRendicionCostosDetalles { get; set; }

    public virtual DbSet<CvtReporteTrazabilidad> CvtReporteTrazabilidads { get; set; }

    public virtual DbSet<CvtReservaStockPallet> CvtReservaStockPallets { get; set; }

    public virtual DbSet<CvtReservaStockPedidoUbicacion> CvtReservaStockPedidoUbicacions { get; set; }

    public virtual DbSet<CvtRespuestaEncuestum> CvtRespuestaEncuesta { get; set; }

    public virtual DbSet<CvtRevisionExtintor> CvtRevisionExtintors { get; set; }

    public virtual DbSet<CvtRevisionExtintorDetalle> CvtRevisionExtintorDetalles { get; set; }

    public virtual DbSet<CvtRevisionExtintorEntorno> CvtRevisionExtintorEntornos { get; set; }

    public virtual DbSet<CvtRondaCheckPoint> CvtRondaCheckPoints { get; set; }

    public virtual DbSet<CvtRondaRegistro> CvtRondaRegistros { get; set; }

    public virtual DbSet<CvtRptVentasDiaria> CvtRptVentasDiarias { get; set; }

    public virtual DbSet<CvtRptetiquetaTipoPallet> CvtRptetiquetaTipoPallets { get; set; }

    public virtual DbSet<CvtRptetiquetum> CvtRptetiqueta { get; set; }

    public virtual DbSet<CvtRutaArchivoNoConformidad> CvtRutaArchivoNoConformidads { get; set; }

    public virtual DbSet<CvtRutaCamion> CvtRutaCamions { get; set; }

    public virtual DbSet<CvtRutaCertificadoFumigacion> CvtRutaCertificadoFumigacions { get; set; }

    public virtual DbSet<CvtSalasenvasado> CvtSalasenvasados { get; set; }

    public virtual DbSet<CvtSalidaInsumo> CvtSalidaInsumos { get; set; }

    public virtual DbSet<CvtSalidaInsumosDetalle> CvtSalidaInsumosDetalles { get; set; }

    public virtual DbSet<CvtSapcompany> CvtSapcompanies { get; set; }

    public virtual DbSet<CvtSeguro> CvtSeguros { get; set; }

    public virtual DbSet<CvtSeguroDetalle> CvtSeguroDetalles { get; set; }

    public virtual DbSet<CvtSeguroEmpresaRelacionadum> CvtSeguroEmpresaRelacionada { get; set; }

    public virtual DbSet<CvtSeguroMateriaAseguradum> CvtSeguroMateriaAsegurada { get; set; }

    public virtual DbSet<CvtSeguroTipo> CvtSeguroTipos { get; set; }

    public virtual DbSet<CvtSistemasInterno> CvtSistemasInternos { get; set; }

    public virtual DbSet<CvtSiteUsuario> CvtSiteUsuarios { get; set; }

    public virtual DbSet<CvtSolicitudCompra> CvtSolicitudCompras { get; set; }

    public virtual DbSet<CvtSolicitudCompraDetalle> CvtSolicitudCompraDetalles { get; set; }

    public virtual DbSet<CvtStock> CvtStocks { get; set; }

    public virtual DbSet<CvtStockAperturaMe> CvtStockAperturaMes { get; set; }

    public virtual DbSet<CvtStockBma> CvtStockBmas { get; set; }

    public virtual DbSet<CvtSubMenu> CvtSubMenus { get; set; }

    public virtual DbSet<CvtSupervisore> CvtSupervisores { get; set; }

    public virtual DbSet<CvtTablaPrueba> CvtTablaPruebas { get; set; }

    public virtual DbSet<CvtTarea> CvtTareas { get; set; }

    public virtual DbSet<CvtTarifasExterno> CvtTarifasExternos { get; set; }

    public virtual DbSet<CvtTblConsumoOf> CvtTblConsumoOfs { get; set; }

    public virtual DbSet<CvtTestWsintranet> CvtTestWsintranets { get; set; }

    public virtual DbSet<CvtTfallaGrua> CvtTfallaGruas { get; set; }

    public virtual DbSet<CvtTicket> CvtTickets { get; set; }

    public virtual DbSet<CvtTicketAdjuntoRespuestum> CvtTicketAdjuntoRespuesta { get; set; }

    public virtual DbSet<CvtTicketsArchivoAdjunto> CvtTicketsArchivoAdjuntos { get; set; }

    public virtual DbSet<CvtTicketsCategorium> CvtTicketsCategoria { get; set; }

    public virtual DbSet<CvtTicketsRespuestum> CvtTicketsRespuesta { get; set; }

    public virtual DbSet<CvtTicketsTipoProblema> CvtTicketsTipoProblemas { get; set; }

    public virtual DbSet<CvtTiempobajadapedidopbi> CvtTiempobajadapedidopbis { get; set; }

    public virtual DbSet<CvtTipoCarroceriaCamion> CvtTipoCarroceriaCamions { get; set; }

    public virtual DbSet<CvtTipoHallazgoMe> CvtTipoHallazgoMes { get; set; }

    public virtual DbSet<CvtTipoMantencion> CvtTipoMantencions { get; set; }

    public virtual DbSet<CvtTipoServicioAdicional> CvtTipoServicioAdicionals { get; set; }

    public virtual DbSet<CvtTipoZonaHigiene> CvtTipoZonaHigienes { get; set; }

    public virtual DbSet<CvtTmppedidosSeleccionado> CvtTmppedidosSeleccionados { get; set; }

    public virtual DbSet<CvtToneladasMovida> CvtToneladasMovidas { get; set; }

    public virtual DbSet<CvtTransferAsignacion> CvtTransferAsignacions { get; set; }

    public virtual DbSet<CvtTransferenciaRechazo> CvtTransferenciaRechazos { get; set; }

    public virtual DbSet<CvtTransferenciaTiempoCierre> CvtTransferenciaTiempoCierres { get; set; }

    public virtual DbSet<CvtTransformacion> CvtTransformacions { get; set; }

    public virtual DbSet<CvtTransformacionAjustadum> CvtTransformacionAjustada { get; set; }

    public virtual DbSet<CvtTransformacionDetalle> CvtTransformacionDetalles { get; set; }

    public virtual DbSet<CvtTransporteMantencion> CvtTransporteMantencions { get; set; }

    public virtual DbSet<CvtTransporteMantencionRepuesto> CvtTransporteMantencionRepuestos { get; set; }

    public virtual DbSet<CvtTratoPorArea> CvtTratoPorAreas { get; set; }

    public virtual DbSet<CvtTrazabilidadSecuenciaEmisionRpt> CvtTrazabilidadSecuenciaEmisionRpts { get; set; }

    public virtual DbSet<CvtUbicacionDefecto> CvtUbicacionDefectos { get; set; }

    public virtual DbSet<CvtUsuario> CvtUsuarios { get; set; }

    public virtual DbSet<CvtVentasDatosProducto> CvtVentasDatosProductos { get; set; }

    public virtual DbSet<CvtVentasFlete> CvtVentasFletes { get; set; }

    public virtual DbSet<CvtViewStockwmsProdBodega> CvtViewStockwmsProdBodegas { get; set; }

    public virtual DbSet<CvtViewStockwmsProdBodegaLote> CvtViewStockwmsProdBodegaLotes { get; set; }

    public virtual DbSet<CvtViewTransformacionDetalle> CvtViewTransformacionDetalles { get; set; }

    public virtual DbSet<CvtViewTransformacionDetalleEntradaLotesSap> CvtViewTransformacionDetalleEntradaLotesSaps { get; set; }

    public virtual DbSet<CvtViewTransformacionDetalleEntradaSap> CvtViewTransformacionDetalleEntradaSaps { get; set; }

    public virtual DbSet<CvtViewTransformacionDetalleSalLotesSap> CvtViewTransformacionDetalleSalLotesSaps { get; set; }

    public virtual DbSet<CvtViewTransformacionDetalleSalidaSap> CvtViewTransformacionDetalleSalidaSaps { get; set; }

    public virtual DbSet<CvtVtaperCabPedido> CvtVtaperCabPedidos { get; set; }

    public virtual DbSet<CvtVtaperDetPedido> CvtVtaperDetPedidos { get; set; }

    public virtual DbSet<CvtVwAsignacionRutaAgendaRecurso> CvtVwAsignacionRutaAgendaRecursos { get; set; }

    public virtual DbSet<CvtVwAsignacionRutaAgendum> CvtVwAsignacionRutaAgenda { get; set; }

    public virtual DbSet<CvtVwAsistenciaCompletum> CvtVwAsistenciaCompleta { get; set; }

    public virtual DbSet<CvtVwAsistenciaCvt> CvtVwAsistenciaCvts { get; set; }

    public virtual DbSet<CvtVwAsistenciaJdb> CvtVwAsistenciaJdbs { get; set; }

    public virtual DbSet<CvtVwAuditoriaRecepcion> CvtVwAuditoriaRecepcions { get; set; }

    public virtual DbSet<CvtVwCalculoHorasExtra> CvtVwCalculoHorasExtras { get; set; }

    public virtual DbSet<CvtVwCantPalletRecepCv201> CvtVwCantPalletRecepCv201s { get; set; }

    public virtual DbSet<CvtVwCheckListArmadoPedido> CvtVwCheckListArmadoPedidos { get; set; }

    public virtual DbSet<CvtVwControlBodega> CvtVwControlBodegas { get; set; }

    public virtual DbSet<CvtVwControlEstimadoFilm> CvtVwControlEstimadoFilms { get; set; }

    public virtual DbSet<CvtVwDetalleLineasMovilesxPlan> CvtVwDetalleLineasMovilesxPlans { get; set; }

    public virtual DbSet<CvtVwDetalleProductoBloqueado> CvtVwDetalleProductoBloqueados { get; set; }

    public virtual DbSet<CvtVwDevolucionFilmPbi> CvtVwDevolucionFilmPbis { get; set; }

    public virtual DbSet<CvtVwDevolucionPbi> CvtVwDevolucionPbis { get; set; }

    public virtual DbSet<CvtVwDevolucionesKpi> CvtVwDevolucionesKpis { get; set; }

    public virtual DbSet<CvtVwDevolucionesKpiMotivo> CvtVwDevolucionesKpiMotivos { get; set; }

    public virtual DbSet<CvtVwDevolucionesKpiProduccionPropium> CvtVwDevolucionesKpiProduccionPropia { get; set; }

    public virtual DbSet<CvtVwDevolucionesPbi> CvtVwDevolucionesPbis { get; set; }

    public virtual DbSet<CvtVwDevolucionesVentasKpi> CvtVwDevolucionesVentasKpis { get; set; }

    public virtual DbSet<CvtVwDiferenciasDuplicado> CvtVwDiferenciasDuplicados { get; set; }

    public virtual DbSet<CvtVwDuplicadosInventario> CvtVwDuplicadosInventarios { get; set; }

    public virtual DbSet<CvtVwEncuestasDetalle> CvtVwEncuestasDetalles { get; set; }

    public virtual DbSet<CvtVwEncuestasResumenAspecto> CvtVwEncuestasResumenAspectos { get; set; }

    public virtual DbSet<CvtVwEncuestasResumenPregunta> CvtVwEncuestasResumenPreguntas { get; set; }

    public virtual DbSet<CvtVwExpedicionFilmPbi> CvtVwExpedicionFilmPbis { get; set; }

    public virtual DbSet<CvtVwExpedicionesDetallePbi> CvtVwExpedicionesDetallePbis { get; set; }

    public virtual DbSet<CvtVwExpedicionesPbi> CvtVwExpedicionesPbis { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBenv> CvtVwFilmtransferidoBenvs { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBenvlote> CvtVwFilmtransferidoBenvlotes { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBkit> CvtVwFilmtransferidoBkits { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBkitlote> CvtVwFilmtransferidoBkitlotes { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBmerma> CvtVwFilmtransferidoBmermas { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBmermaLote> CvtVwFilmtransferidoBmermaLotes { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBpt> CvtVwFilmtransferidoBpts { get; set; }

    public virtual DbSet<CvtVwFilmtransferidoBptlote> CvtVwFilmtransferidoBptlotes { get; set; }

    public virtual DbSet<CvtVwFiltroDetProdBloqueado> CvtVwFiltroDetProdBloqueados { get; set; }

    public virtual DbSet<CvtVwFiltroTransferencium> CvtVwFiltroTransferencia { get; set; }

    public virtual DbSet<CvtVwFoliosPedidosAsignacion> CvtVwFoliosPedidosAsignacions { get; set; }

    public virtual DbSet<CvtVwFoliosTransferenciasAsignacion> CvtVwFoliosTransferenciasAsignacions { get; set; }

    public virtual DbSet<CvtVwFormularioEntregaEquipo> CvtVwFormularioEntregaEquipos { get; set; }

    public virtual DbSet<CvtVwGastoCamionesPbi> CvtVwGastoCamionesPbis { get; set; }

    public virtual DbSet<CvtVwHallazgo> CvtVwHallazgos { get; set; }

    public virtual DbSet<CvtVwInfCodigosActivo> CvtVwInfCodigosActivos { get; set; }

    public virtual DbSet<CvtVwInfMantencionDatosEquipo> CvtVwInfMantencionDatosEquipos { get; set; }

    public virtual DbSet<CvtVwInformeDetencione> CvtVwInformeDetenciones { get; set; }

    public virtual DbSet<CvtVwInformeValorizadoTratosxAsistencium> CvtVwInformeValorizadoTratosxAsistencia { get; set; }

    public virtual DbSet<CvtVwInventarioCantidadDiferente> CvtVwInventarioCantidadDiferentes { get; set; }

    public virtual DbSet<CvtVwInventarioCantidadDiferenteInf> CvtVwInventarioCantidadDiferenteInfs { get; set; }

    public virtual DbSet<CvtVwInventarioLoteDiferente> CvtVwInventarioLoteDiferentes { get; set; }

    public virtual DbSet<CvtVwInventarioPalletInventariadosEstadoDespachado> CvtVwInventarioPalletInventariadosEstadoDespachados { get; set; }

    public virtual DbSet<CvtVwInventarioPalletVivosNoInventariado> CvtVwInventarioPalletVivosNoInventariados { get; set; }

    public virtual DbSet<CvtVwInventarioProductoDiferente> CvtVwInventarioProductoDiferentes { get; set; }

    public virtual DbSet<CvtVwInventarioResumenUsuarioProducto> CvtVwInventarioResumenUsuarioProductos { get; set; }

    public virtual DbSet<CvtVwInventarioSiteDiferente> CvtVwInventarioSiteDiferentes { get; set; }

    public virtual DbSet<CvtVwInventarioSumCantRepal> CvtVwInventarioSumCantRepals { get; set; }

    public virtual DbSet<CvtVwInventariorRestaCantRepal> CvtVwInventariorRestaCantRepals { get; set; }

    public virtual DbSet<CvtVwLeeCuentaExistenciasxProducto> CvtVwLeeCuentaExistenciasxProductos { get; set; }

    public virtual DbSet<CvtVwListadosEquiposTipo> CvtVwListadosEquiposTipos { get; set; }

    public virtual DbSet<CvtVwLogRegistro> CvtVwLogRegistros { get; set; }

    public virtual DbSet<CvtVwOperadorPuestaMarchaPt> CvtVwOperadorPuestaMarchaPts { get; set; }

    public virtual DbSet<CvtVwPackageArticle> CvtVwPackageArticles { get; set; }

    public virtual DbSet<CvtVwPalletProducidosEnvasado> CvtVwPalletProducidosEnvasados { get; set; }

    public virtual DbSet<CvtVwPalletProducidosKit> CvtVwPalletProducidosKits { get; set; }

    public virtual DbSet<CvtVwPalletTransferidosDesdeMerma> CvtVwPalletTransferidosDesdeMermas { get; set; }

    public virtual DbSet<CvtVwPalletTransferidosDesdeMermaContenedora> CvtVwPalletTransferidosDesdeMermaContenedoras { get; set; }

    public virtual DbSet<CvtVwPalletVendidoGrupoPorducto> CvtVwPalletVendidoGrupoPorductos { get; set; }

    public virtual DbSet<CvtVwPedidoDetalleOrdenCarga> CvtVwPedidoDetalleOrdenCargas { get; set; }

    public virtual DbSet<CvtVwPedidoOrdenCarga> CvtVwPedidoOrdenCargas { get; set; }

    public virtual DbSet<CvtVwPedidoOrdenCargaListadoPendiente> CvtVwPedidoOrdenCargaListadoPendientes { get; set; }

    public virtual DbSet<CvtVwPedidosDespacho> CvtVwPedidosDespachos { get; set; }

    public virtual DbSet<CvtVwPersonasTorniquete> CvtVwPersonasTorniquetes { get; set; }

    public virtual DbSet<CvtVwPorcentajePalletProducidosEnvasado> CvtVwPorcentajePalletProducidosEnvasados { get; set; }

    public virtual DbSet<CvtVwPorcentajePalletProducidosKit> CvtVwPorcentajePalletProducidosKits { get; set; }

    public virtual DbSet<CvtVwPorcentajePalletTransferidosDesdeMerma> CvtVwPorcentajePalletTransferidosDesdeMermas { get; set; }

    public virtual DbSet<CvtVwPorcentajePalletTransferidosDesdeMermaContenedora> CvtVwPorcentajePalletTransferidosDesdeMermaContenedoras { get; set; }

    public virtual DbSet<CvtVwPorcentajePalletVendidosPorGrupo> CvtVwPorcentajePalletVendidosPorGrupos { get; set; }

    public virtual DbSet<CvtVwProduccionpbi> CvtVwProduccionpbis { get; set; }

    public virtual DbSet<CvtVwProductoAzucar> CvtVwProductoAzucars { get; set; }

    public virtual DbSet<CvtVwProductoGarbanzo> CvtVwProductoGarbanzos { get; set; }

    public virtual DbSet<CvtVwProductoLenteja> CvtVwProductoLentejas { get; set; }

    public virtual DbSet<CvtVwProductoPoroto> CvtVwProductoPorotos { get; set; }

    public virtual DbSet<CvtVwProductosArroz> CvtVwProductosArrozs { get; set; }

    public virtual DbSet<CvtVwProdutoArveja> CvtVwProdutoArvejas { get; set; }

    public virtual DbSet<CvtVwProdutoPorotosNegro> CvtVwProdutoPorotosNegros { get; set; }

    public virtual DbSet<CvtVwRamonestacionPersona> CvtVwRamonestacionPersonas { get; set; }

    public virtual DbSet<CvtVwRecepcionFilmPbi> CvtVwRecepcionFilmPbis { get; set; }

    public virtual DbSet<CvtVwRecepcionPbi> CvtVwRecepcionPbis { get; set; }

    public virtual DbSet<CvtVwRechazoPncPbi> CvtVwRechazoPncPbis { get; set; }

    public virtual DbSet<CvtVwRegistroAmonestacion> CvtVwRegistroAmonestacions { get; set; }

    public virtual DbSet<CvtVwReimpresionEtiqueta> CvtVwReimpresionEtiquetas { get; set; }

    public virtual DbSet<CvtVwRepInsperccionvisualsaco> CvtVwRepInsperccionvisualsacos { get; set; }

    public virtual DbSet<CvtVwRepInsperccionvisualsacosAccionCorrectiva> CvtVwRepInsperccionvisualsacosAccionCorrectivas { get; set; }

    public virtual DbSet<CvtVwReporInspeccionArroz> CvtVwReporInspeccionArrozs { get; set; }

    public virtual DbSet<CvtVwReportesTrazabalidadCalidad> CvtVwReportesTrazabalidadCalidads { get; set; }

    public virtual DbSet<CvtVwResumenCamionesFecha> CvtVwResumenCamionesFechas { get; set; }

    public virtual DbSet<CvtVwResumenConsumoCombustiblePorMe> CvtVwResumenConsumoCombustiblePorMes { get; set; }

    public virtual DbSet<CvtVwResumenConsumoCombustiblePorPropietario> CvtVwResumenConsumoCombustiblePorPropietarios { get; set; }

    public virtual DbSet<CvtVwResumenConsumoFilm> CvtVwResumenConsumoFilms { get; set; }

    public virtual DbSet<CvtVwResumenConsumoFilmCv100> CvtVwResumenConsumoFilmCv100s { get; set; }

    public virtual DbSet<CvtVwResumenConsumoFilmCv200> CvtVwResumenConsumoFilmCv200s { get; set; }

    public virtual DbSet<CvtVwResumenConsumoFilmCv300> CvtVwResumenConsumoFilmCv300s { get; set; }

    public virtual DbSet<CvtVwResumenConsumoFilmCv301> CvtVwResumenConsumoFilmCv301s { get; set; }

    public virtual DbSet<CvtVwResumenDetencione> CvtVwResumenDetenciones { get; set; }

    public virtual DbSet<CvtVwResumenDetencionesCategorium> CvtVwResumenDetencionesCategoria { get; set; }

    public virtual DbSet<CvtVwResumenMensualCamion> CvtVwResumenMensualCamions { get; set; }

    public virtual DbSet<CvtVwResumenMensualCategoriaCamion> CvtVwResumenMensualCategoriaCamions { get; set; }

    public virtual DbSet<CvtVwResumenMensualGastosCamion> CvtVwResumenMensualGastosCamions { get; set; }

    public virtual DbSet<CvtVwResumenProduccion> CvtVwResumenProduccions { get; set; }

    public virtual DbSet<CvtVwResumenTotalGastoCamionPorDetalle> CvtVwResumenTotalGastoCamionPorDetalles { get; set; }

    public virtual DbSet<CvtVwRotacionBodegaRecuperacion> CvtVwRotacionBodegaRecuperacions { get; set; }

    public virtual DbSet<CvtVwRotacionInventarioPbi> CvtVwRotacionInventarioPbis { get; set; }

    public virtual DbSet<CvtVwRptDatosequipo> CvtVwRptDatosequipos { get; set; }

    public virtual DbSet<CvtVwRptMantencioninformatica> CvtVwRptMantencioninformaticas { get; set; }

    public virtual DbSet<CvtVwSolicitudTransferenciaPbi> CvtVwSolicitudTransferenciaPbis { get; set; }

    public virtual DbSet<CvtVwStockDisponibleBajadaPedido> CvtVwStockDisponibleBajadaPedidos { get; set; }

    public virtual DbSet<CvtVwTotalDetencionesOf> CvtVwTotalDetencionesOfs { get; set; }

    public virtual DbSet<CvtVwTotalPalletVendidoGrupoPorducto> CvtVwTotalPalletVendidoGrupoPorductos { get; set; }

    public virtual DbSet<CvtVwTranferSaplote> CvtVwTranferSaplotes { get; set; }

    public virtual DbSet<CvtVwTranferenciaSap> CvtVwTranferenciaSaps { get; set; }

    public virtual DbSet<CvtVwTransferenciaCv410> CvtVwTransferenciaCv410s { get; set; }

    public virtual DbSet<CvtVwTransferenciaFilmPbi> CvtVwTransferenciaFilmPbis { get; set; }

    public virtual DbSet<CvtVwTransferenciasDetalle> CvtVwTransferenciasDetalles { get; set; }

    public virtual DbSet<CvtVwTransferenciasRechazada> CvtVwTransferenciasRechazadas { get; set; }

    public virtual DbSet<CvtVwTransformacionesPbi> CvtVwTransformacionesPbis { get; set; }

    public virtual DbSet<CvtVwTrazaBalanceMasaAnalizaLotesMp> CvtVwTrazaBalanceMasaAnalizaLotesMps { get; set; }

    public virtual DbSet<CvtVwTrazaBalanceMasaAnalizaLotesPt> CvtVwTrazaBalanceMasaAnalizaLotesPts { get; set; }

    public virtual DbSet<CvtVwTrazaBalanceMasaAnalizaLotesRep> CvtVwTrazaBalanceMasaAnalizaLotesReps { get; set; }

    public virtual DbSet<CvtZonaHigiene> CvtZonaHigienes { get; set; }

    public virtual DbSet<CvtviewPalletsRecSinPosicionar> CvtviewPalletsRecSinPosicionars { get; set; }

    public virtual DbSet<CvtviewProduccionOfabierta> CvtviewProduccionOfabiertas { get; set; }

    public virtual DbSet<CvtviewTransaccionesWm> CvtviewTransaccionesWms { get; set; }

    public virtual DbSet<DatoVersionesAppxam> DatoVersionesAppxams { get; set; }

    public virtual DbSet<DimFecha> DimFechas { get; set; }

    public virtual DbSet<EstadisticaVenta> EstadisticaVentas { get; set; }

    public virtual DbSet<FallasGruaPbi> FallasGruaPbis { get; set; }

    public virtual DbSet<ImpresionEtiqueta> ImpresionEtiquetas { get; set; }

    public virtual DbSet<ItemsClasificado> ItemsClasificados { get; set; }

    public virtual DbSet<LogSistemaCvt> LogSistemaCvts { get; set; }

    public virtual DbSet<MmetroLogUltimoPrecioCompra> MmetroLogUltimoPrecioCompras { get; set; }

    public virtual DbSet<MmetroUltimoPrecioCompra> MmetroUltimoPrecioCompras { get; set; }

    public virtual DbSet<OfModificada> OfModificadas { get; set; }

    public virtual DbSet<PresupuestoVentasCantidad> PresupuestoVentasCantidads { get; set; }

    public virtual DbSet<PresupuestoVentasMonedum> PresupuestoVentasMoneda { get; set; }

    public virtual DbSet<RegistrosJornadaPractica> RegistrosJornadaPracticas { get; set; }

    public virtual DbSet<SmmMailUsuariosMayoristum> SmmMailUsuariosMayorista { get; set; }

    public virtual DbSet<TmpBalanceDeMasaMp> TmpBalanceDeMasaMps { get; set; }

    public virtual DbSet<TmpTrazaConsumiblesOf> TmpTrazaConsumiblesOfs { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<ViewResumenEstadisticasVenta> ViewResumenEstadisticasVentas { get; set; }

    public virtual DbSet<VistaInventarioOctubre2017> VistaInventarioOctubre2017s { get; set; }

    public virtual DbSet<VwArchivosEnvTicket> VwArchivosEnvTickets { get; set; }

    public virtual DbSet<VwAreaTrabajo> VwAreaTrabajos { get; set; }

    public virtual DbSet<VwBobinasRegistradasEnvasado> VwBobinasRegistradasEnvasados { get; set; }

    public virtual DbSet<VwCantBobinasTransferencium> VwCantBobinasTransferencia { get; set; }

    public virtual DbSet<VwCorreosRechazoTranferencium> VwCorreosRechazoTranferencia { get; set; }

    public virtual DbSet<VwCvtAgendamantencionEncabezado> VwCvtAgendamantencionEncabezados { get; set; }

    public virtual DbSet<VwCvtAgendamantencionEncabezadoTest> VwCvtAgendamantencionEncabezadoTests { get; set; }

    public virtual DbSet<VwCvtLogtranstraePesoTotalProd2> VwCvtLogtranstraePesoTotalProd2s { get; set; }

    public virtual DbSet<VwCvtMaquinasPartesComponente> VwCvtMaquinasPartesComponentes { get; set; }

    public virtual DbSet<VwCvtPersonalControlPt> VwCvtPersonalControlPts { get; set; }

    public virtual DbSet<VwCvtStockLotesWmsSapxBodegaVsinventarioTest2> VwCvtStockLotesWmsSapxBodegaVsinventarioTest2s { get; set; }

    public virtual DbSet<VwDatosBobinasFilmProd> VwDatosBobinasFilmProds { get; set; }

    public virtual DbSet<VwDatosRptControlPesoProductoPaletizado> VwDatosRptControlPesoProductoPaletizados { get; set; }

    public virtual DbSet<VwDetalleRecepcionFilm> VwDetalleRecepcionFilms { get; set; }

    public virtual DbSet<VwDetalleRecepcionFilmLote> VwDetalleRecepcionFilmLotes { get; set; }

    public virtual DbSet<VwDevolDetalleExportFilm> VwDevolDetalleExportFilms { get; set; }

    public virtual DbSet<VwDevolucionDetailSyncFilm> VwDevolucionDetailSyncFilms { get; set; }

    public virtual DbSet<VwDevolucionDetailSyncLoteFilm> VwDevolucionDetailSyncLoteFilms { get; set; }

    public virtual DbSet<VwExcelResumenTicket> VwExcelResumenTickets { get; set; }

    public virtual DbSet<VwExpedicionFilmDetalle> VwExpedicionFilmDetalles { get; set; }

    public virtual DbSet<VwExpedicionFilmDetalleLote> VwExpedicionFilmDetalleLotes { get; set; }

    public virtual DbSet<VwFamiliaProd> VwFamiliaProds { get; set; }

    public virtual DbSet<VwFilmConReserva> VwFilmConReservas { get; set; }

    public virtual DbSet<VwFilmTransferidoOf> VwFilmTransferidoOfs { get; set; }

    public virtual DbSet<VwFiltroTransferenciaFilm> VwFiltroTransferenciaFilms { get; set; }

    public virtual DbSet<VwFoliosInventario> VwFoliosInventarios { get; set; }

    public virtual DbSet<VwFullPersonalTorniquete> VwFullPersonalTorniquetes { get; set; }

    public virtual DbSet<VwFullstockCv200> VwFullstockCv200s { get; set; }

    public virtual DbSet<VwFullstockCvtSmm> VwFullstockCvtSmms { get; set; }

    public virtual DbSet<VwGrupoProductosAnalisisCompra> VwGrupoProductosAnalisisCompras { get; set; }

    public virtual DbSet<VwGrupoProveedorAnalisisCompra> VwGrupoProveedorAnalisisCompras { get; set; }

    public virtual DbSet<VwInfReportEntregaPeriferico> VwInfReportEntregaPerifericos { get; set; }

    public virtual DbSet<VwInfStockFilm> VwInfStockFilms { get; set; }

    public virtual DbSet<VwListaUsuariosVerificadore> VwListaUsuariosVerificadores { get; set; }

    public virtual DbSet<VwMaxcantidadregistrosticket> VwMaxcantidadregistrostickets { get; set; }

    public virtual DbSet<VwMenuxamarin> VwMenuxamarins { get; set; }

    public virtual DbSet<VwOperadorVsUsuario> VwOperadorVsUsuarios { get; set; }

    public virtual DbSet<VwPermisoTrabajoSeguroTotalAst> VwPermisoTrabajoSeguroTotalAsts { get; set; }

    public virtual DbSet<VwPersonal> VwPersonals { get; set; }

    public virtual DbSet<VwPersonalDesvinculadoTorniquete> VwPersonalDesvinculadoTorniquetes { get; set; }

    public virtual DbSet<VwPesonetoinicial> VwPesonetoinicials { get; set; }

    public virtual DbSet<VwPrcComisionVendedor> VwPrcComisionVendedors { get; set; }

    public virtual DbSet<VwProductoInvenarioFilm> VwProductoInvenarioFilms { get; set; }

    public virtual DbSet<VwProductosFilm> VwProductosFilms { get; set; }

    public virtual DbSet<VwRegCompraUreaUltimoPrecioLitro> VwRegCompraUreaUltimoPrecioLitros { get; set; }

    public virtual DbSet<VwRegistroPrecEntrEjec> VwRegistroPrecEntrEjecs { get; set; }

    public virtual DbSet<VwRepInspPtarroz> VwRepInspPtarrozs { get; set; }

    public virtual DbSet<VwRepInspPtazucar> VwRepInspPtazucars { get; set; }

    public virtual DbSet<VwRepInspPtlegunbre> VwRepInspPtlegunbres { get; set; }

    public virtual DbSet<VwRepInspvisualSaco> VwRepInspvisualSacos { get; set; }

    public virtual DbSet<VwRepMonitDetecmetale> VwRepMonitDetecmetales { get; set; }

    public virtual DbSet<VwReporControlEnvasadoptCab> VwReporControlEnvasadoptCabs { get; set; }

    public virtual DbSet<VwReportFilmEnfardadora> VwReportFilmEnfardadoras { get; set; }

    public virtual DbSet<VwReportFilmImpreso> VwReportFilmImpresos { get; set; }

    public virtual DbSet<VwReportInspeccionArveja> VwReportInspeccionArvejas { get; set; }

    public virtual DbSet<VwReportInspeccionAzucar> VwReportInspeccionAzucars { get; set; }

    public virtual DbSet<VwReportInspeccionGarbanzo> VwReportInspeccionGarbanzos { get; set; }

    public virtual DbSet<VwReportInspeccionLenteja> VwReportInspeccionLentejas { get; set; }

    public virtual DbSet<VwReportInspeccionPoroto> VwReportInspeccionPorotos { get; set; }

    public virtual DbSet<VwReportInspeccionPorotoNegro> VwReportInspeccionPorotoNegros { get; set; }

    public virtual DbSet<VwReportTotalFilmEnfardadora> VwReportTotalFilmEnfardadoras { get; set; }

    public virtual DbSet<VwReportTotalFilmImpreso> VwReportTotalFilmImpresos { get; set; }

    public virtual DbSet<VwResumenReclamoCab> VwResumenReclamoCabs { get; set; }

    public virtual DbSet<VwResumenReclamoLote> VwResumenReclamoLotes { get; set; }

    public virtual DbSet<VwResumenTarea> VwResumenTareas { get; set; }

    public virtual DbSet<VwRptTrazabilidadFilm> VwRptTrazabilidadFilms { get; set; }

    public virtual DbSet<VwTestResultSumaPickingList> VwTestResultSumaPickingLists { get; set; }

    public virtual DbSet<VwTipoComisionVendedor> VwTipoComisionVendedors { get; set; }

    public virtual DbSet<VwTipoPalletXamarin> VwTipoPalletXamarins { get; set; }

    public virtual DbSet<VwTranferSaplotesFilm> VwTranferSaplotesFilms { get; set; }

    public virtual DbSet<VwTranferenciaSapFilm> VwTranferenciaSapFilms { get; set; }

    public virtual DbSet<VwTransferenciaDetalleFilm> VwTransferenciaDetalleFilms { get; set; }

    public virtual DbSet<VwTrazaBusquedaFilm> VwTrazaBusquedaFilms { get; set; }

    public virtual DbSet<VwUsuariosActivosCvt> VwUsuariosActivosCvts { get; set; }

    public virtual DbSet<VwUsuariosXamarin> VwUsuariosXamarins { get; set; }

    public virtual DbSet<VwVencimientosProyectadosCvt> VwVencimientosProyectadosCvts { get; set; }

    public virtual DbSet<VwXamarinPackage> VwXamarinPackages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.0.20.3;Database=CVT_DESAINT;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP850_CI_AS");

        modelBuilder.Entity<AreaDevolucion>(entity =>
        {
            entity.ToTable("AreaDevolucion");

            entity.Property(e => e.AreaDevolucionId).HasColumnName("AreaDevolucion_Id");
            entity.Property(e => e.AreaNombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BmasListadoVentasPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BMAS_LIstadoVentasPBI");

            entity.Property(e => e.Canal).HasMaxLength(32);
            entity.Property(e => e.Cantidad).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.CodCliente).HasMaxLength(15);
            entity.Property(e => e.CodDireccion).HasMaxLength(50);
            entity.Property(e => e.CodigoArticulo).HasMaxLength(50);
            entity.Property(e => e.Comentario).HasMaxLength(50);
            entity.Property(e => e.CompConta).HasColumnName("Comp_Conta");
            entity.Property(e => e.Comuna).HasMaxLength(100);
            entity.Property(e => e.Costo).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.CostoTotal).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Direccion).HasMaxLength(254);
            entity.Property(e => e.EmbalajePorUm)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("EmbalajePorUM");
            entity.Property(e => e.EmpresaRelacionada).HasMaxLength(40);
            entity.Property(e => e.FCont)
                .HasColumnType("datetime")
                .HasColumnName("F_Cont");
            entity.Property(e => e.FVenc)
                .HasColumnType("datetime")
                .HasColumnName("F_Venc");
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.GrupoCliente).HasMaxLength(100);
            entity.Property(e => e.GrupoVenta).HasMaxLength(40);
            entity.Property(e => e.Indicador).HasMaxLength(50);
            entity.Property(e => e.Marca).HasMaxLength(100);
            entity.Property(e => e.MargeRc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MargeRC");
            entity.Property(e => e.MargenBruto).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.MargenReal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.NotaBruta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotaRc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NotaRC");
            entity.Property(e => e.NotaReal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NumDocRef)
                .HasMaxLength(18)
                .HasColumnName("NumDocREF");
            entity.Property(e => e.NumInterno).HasColumnName("Num_Interno");
            entity.Property(e => e.NumRegion)
                .HasMaxLength(3)
                .HasColumnName("Num_Region");
            entity.Property(e => e.PcrComision)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("Pcr_Comision");
            entity.Property(e => e.PesoTotal).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.PrcRAcuerdo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Acuerdo");
            entity.Property(e => e.PrcRCentra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Centra");
            entity.Property(e => e.PrcRDaymon)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Daymon");
            entity.Property(e => e.PrcRFcrappel)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_FCRappel");
            entity.Property(e => e.PrcRLogAuto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_LogAuto");
            entity.Property(e => e.PrcRMermaCero)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_MermaCero");
            entity.Property(e => e.PrcRPlataforma)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Plataforma");
            entity.Property(e => e.PrcRRepoInt)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_RepoInt");
            entity.Property(e => e.PrcRapel)
                .HasColumnType("decimal(25, 6)")
                .HasColumnName("Prc_Rapel");
            entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Tipo)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoComision)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocRef).HasMaxLength(100);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoMarca)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TotalComision).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalLinea).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.TotalRAcuerdo)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Acuerdo");
            entity.Property(e => e.TotalRCentra)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Centra");
            entity.Property(e => e.TotalRDaymon)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Daymon");
            entity.Property(e => e.TotalRFcrappel)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_FCRappel");
            entity.Property(e => e.TotalRLogAuto)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_LogAuto");
            entity.Property(e => e.TotalRMermaCero)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_MermaCero");
            entity.Property(e => e.TotalRPlataforma)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Plataforma");
            entity.Property(e => e.TotalRRepoInt)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_RepoInt");
            entity.Property(e => e.TotalRapel).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalSinRapel)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Total_SinRapel");
            entity.Property(e => e.Transporte).HasMaxLength(50);
            entity.Property(e => e.UmEmbalaje)
                .HasMaxLength(30)
                .HasColumnName("Um_Embalaje");
            entity.Property(e => e.UmVendida)
                .HasMaxLength(100)
                .HasColumnName("UM_Vendida");
            entity.Property(e => e.UnidadesVendidas).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.UtilidadBruta).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.UtilidadRc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("UtilidadRC");
            entity.Property(e => e.UtilidadReal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ValorProductoTransporte).HasColumnType("numeric(38, 14)");
            entity.Property(e => e.Vendedor).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtAccesoCamion>(entity =>
        {
            entity.HasKey(e => e.IdCamion);

            entity.ToTable("CVT_AccesoCamion");

            entity.Property(e => e.IdCamion).HasColumnName("Id_Camion");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PermisoCirculacion).HasColumnName("Permiso_circulacion");
            entity.Property(e => e.RevisionTecnica).HasColumnName("Revision_Tecnica");
        });

        modelBuilder.Entity<CvtActivoFijo>(entity =>
        {
            entity.HasKey(e => e.IdActivo);

            entity.ToTable("CVT_ActivoFIjo");

            entity.Property(e => e.IdActivo).HasColumnName("ID_Activo");
            entity.Property(e => e.Beneficio33bis).HasColumnName("Beneficio_33BIS");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.Cmac)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CMAC");
            entity.Property(e => e.Cmda)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CMDA");
            entity.Property(e => e.Cmej)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CMEJ");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cuenta_Contable");
            entity.Property(e => e.Depac)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DEPAC");
            entity.Property(e => e.Depej)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DEPEJ");
            entity.Property(e => e.Dvision)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompra).HasColumnName("Fecha_Compra");
            entity.Property(e => e.LugarFisico)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Lugar_Fisico");
            entity.Property(e => e.MontoBeneficio33bis)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Monto_Beneficio_33BIS");
            entity.Property(e => e.NFactura).HasColumnName("N_Factura");
            entity.Property(e => e.NombreActivo)
                .IsUnicode(false)
                .HasColumnName("Nombre_Activo");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidAdministrativa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Unid_Administrativa");
            entity.Property(e => e.ValorCompraNeto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Valor_Compra_Neto");
            entity.Property(e => e.ValorFinalActivo)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Valor_Final_Activo");
            entity.Property(e => e.VidaUtilMeses).HasColumnName("Vida_Util_Meses");
            entity.Property(e => e.VidaUtilRestante)
                .HasComputedColumnSql("([Vida_Util_Meses]-[Vida_Util_Transcurrida])", false)
                .HasColumnName("Vida_Util_Restante");
            entity.Property(e => e.VidaUtilTranscurrida).HasColumnName("Vida_Util_Transcurrida");
        });

        modelBuilder.Entity<CvtAcuerdoComercial>(entity =>
        {
            entity.HasKey(e => e.IdAcuerdoComercial);

            entity.ToTable("CVT_Acuerdo_Comercial");

            entity.Property(e => e.IdAcuerdoComercial).HasColumnName("Id_AcuerdoComercial");
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Proveedor");
            entity.Property(e => e.DescuestoProveedor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Descuesto_Proveedor");
            entity.Property(e => e.TipoAcuerdo).HasColumnName("Tipo_Acuerdo");
        });

        modelBuilder.Entity<CvtAcuerdoComercialDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetAcuerdoComercial);

            entity.ToTable("CVT_Acuerdo_Comercial_Detalle");

            entity.Property(e => e.IdDetAcuerdoComercial).HasColumnName("Id_detAcuerdoComercial");
            entity.Property(e => e.Centralizado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechDesde).HasColumnType("datetime");
            entity.Property(e => e.FechHasta).HasColumnType("datetime");
            entity.Property(e => e.IdAcuerdoComercial).HasColumnName("Id_AcuerdoComercial");
            entity.Property(e => e.Merma).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProntoPago).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rapel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Retiro).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SellInt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Sell_Int");
            entity.Property(e => e.SellOut)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Sell_Out");
            entity.Property(e => e.TotalAcuerdo)
                .HasComputedColumnSql("(((((([Sell_Int]+[Sell_Out])+[Rapel])+[Merma])+[Retiro])+[Centralizado])+[ProntoPago])", false)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("Total_Acuerdo");
        });

        modelBuilder.Entity<CvtAfCalculoPeriodo>(entity =>
        {
            entity.HasKey(e => new { e.Año, e.Mes, e.IdActivo });

            entity.ToTable("CVT_AF_CalculoPeriodo");

            entity.Property(e => e.IdActivo)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_Activo");
            entity.Property(e => e.Beneficio33bis).HasColumnName("Beneficio_33BIS");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.CmEje)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CM_EJE");
            entity.Property(e => e.CmEjeAprox)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CM_EJE_Aprox");
            entity.Property(e => e.Cmac)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CMAC");
            entity.Property(e => e.Cmda)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CMDA");
            entity.Property(e => e.CmdaAprox)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("CMDA_Aprox");
            entity.Property(e => e.Cmej)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CMEJ");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cuenta_Contable");
            entity.Property(e => e.Depac)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DEPAC");
            entity.Property(e => e.Depej)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DEPEJ");
            entity.Property(e => e.DepresiacionEje)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Depresiacion_Eje");
            entity.Property(e => e.DepresiacionEjeAprox)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Depresiacion_Eje_APROX");
            entity.Property(e => e.Dvision)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Factor).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.FechaCompra).HasColumnName("Fecha_Compra");
            entity.Property(e => e.LugarFisico)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Lugar_Fisico");
            entity.Property(e => e.MontoADepreciar)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Monto_a_Depreciar");
            entity.Property(e => e.MontoADepreciarAprox)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Monto_a_Depreciar_APROX");
            entity.Property(e => e.MontoBeneficio33bis)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Monto_Beneficio_33BIS");
            entity.Property(e => e.NFactura)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("N_Factura");
            entity.Property(e => e.NombreActivo)
                .IsUnicode(false)
                .HasColumnName("Nombre_Activo");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidAdministrativa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Unid_Administrativa");
            entity.Property(e => e.ValorCompraNeto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Valor_Compra_Neto");
            entity.Property(e => e.ValorFinalActivoAnt)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Valor_Final_Activo_ANT");
            entity.Property(e => e.ValorFinalActivoNuevo)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Valor_Final_Activo_Nuevo");
            entity.Property(e => e.ValorParaCm)
                .HasColumnType("decimal(20, 0)")
                .HasColumnName("valor_para_CM");
            entity.Property(e => e.VidaUtilMeses).HasColumnName("Vida_Util_Meses");
            entity.Property(e => e.VidaUtilRestante).HasColumnName("Vida_Util_Restante");
            entity.Property(e => e.VidaUtilTranscurrida).HasColumnName("Vida_Util_Transcurrida");
        });

        modelBuilder.Entity<CvtAfIndiceReajustabilidad>(entity =>
        {
            entity.HasKey(e => new { e.Ano, e.Mes });

            entity.ToTable("CVT_AF_Indice_Reajustabilidad");

            entity.Property(e => e.Periodo).HasComputedColumnSql("(CONVERT([date],concat('01-',[Mes],'-',[Ano]),(103)))", false);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtAgendaSalida>(entity =>
        {
            entity.HasKey(e => e.IdAgenda)
                .HasName("CVT_AgendaSalidas_PK")
                .IsClustered(false);

            entity.ToTable("CVT_AgendaSalidas", tb => tb.HasTrigger("CVT_AgendaSalidasUPDATE"));

            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtAgendamiento>(entity =>
        {
            entity.HasKey(e => e.AgendamientoId);

            entity.ToTable("CVT_Agendamiento");

            entity.Property(e => e.Asunto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CantidadPlanificada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadProducida).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.EstadoOf).HasColumnName("Estado_OF");
            entity.Property(e => e.FechaLimite).HasColumnType("datetime");
            entity.Property(e => e.Inicio).HasColumnType("datetime");
            entity.Property(e => e.OfDocEntry).HasColumnName("OF_DocEntry");
            entity.Property(e => e.ProductoCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Termino).HasColumnType("datetime");
            entity.Property(e => e.TipoProduccion).HasColumnName("Tipo_Produccion");
        });

        modelBuilder.Entity<CvtAgendamientoAcesso>(entity =>
        {
            entity.HasKey(e => e.AgendamientoAccesoId);

            entity.ToTable("CVT_AgendamientoAcesso");

            entity.Property(e => e.AgendamientoAccesoId).HasColumnName("AgendamientoAcceso_Id");
            entity.Property(e => e.Asunto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NdocumentoOrigen).HasColumnName("NDocumentoOrigen");
            entity.Property(e => e.Norden).HasColumnName("NOrden");
            entity.Property(e => e.Notas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAgendamiento)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumentoOrigen)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAgendamientoLinea>(entity =>
        {
            entity.HasKey(e => new { e.AgendamientoId, e.LineaId });

            entity.ToTable("CVT_AgendamientoLinea");

            entity.Property(e => e.AgendamientoId).HasColumnName("Agendamiento_Id");
        });

        modelBuilder.Entity<CvtAnalisisCostoDiario>(entity =>
        {
            entity.HasKey(e => new { e.ItemCode, e.Fecha })
                .HasName("CVT_AnalisisCostoDia_PK")
                .IsClustered(false);

            entity.ToTable("CVT_AnalisisCostoDiario");

            entity.Property(e => e.ItemCode).HasMaxLength(40);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.AvgPriceDia).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.FechaInsert).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.WhsCode).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtAreaHigiene>(entity =>
        {
            entity.HasKey(e => e.IdAreaHigiene);

            entity.ToTable("CVT_AreaHigiene");

            entity.Property(e => e.IdAreaHigiene).HasColumnName("Id_AreaHigiene");
            entity.Property(e => e.AreaHigiene)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAreaNoConformidad>(entity =>
        {
            entity.HasKey(e => e.IdAreaNoConformidad);

            entity.ToTable("CVT_AreaNoConformidad");

            entity.Property(e => e.IdAreaNoConformidad).HasColumnName("id_AreaNoConformidad");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAreaTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdArea);

            entity.ToTable("CVT_AreaTrabajo");

            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TcolacionDia).HasColumnName("TColacionDia");
            entity.Property(e => e.TcolacionNoche).HasColumnName("TColacionNoche");
        });

        modelBuilder.Entity<CvtArmadoCaja>(entity =>
        {
            entity.HasKey(e => e.ArmadoId);

            entity.ToTable("CVT_ArmadoCajas");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NumeroTarja)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtArmador>(entity =>
        {
            entity.HasKey(e => e.ArmadorId);

            entity.ToTable("CVT_Armador");

            entity.Property(e => e.NombreArmador)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Runarmador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RUNArmador");
        });

        modelBuilder.Entity<CvtArticulo>(entity =>
        {
            entity.HasKey(e => e.ArticuloId).HasName("PK_CVT_ArticuloMantencion");

            entity.ToTable("CVT_Articulo");

            entity.Property(e => e.ArticuloId).HasColumnName("Articulo_Id");
            entity.Property(e => e.AriticuloUbicacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Ariticulo_Ubicacion");
            entity.Property(e => e.ArticuloCodigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Articulo_Codigo");
            entity.Property(e => e.ArticuloNombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Articulo_Nombre");
            entity.Property(e => e.ArticuloProveedor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Articulo_Proveedor");
            entity.Property(e => e.ArticuloStock).HasColumnName("Articulo_Stock");
            entity.Property(e => e.ArticuloStockMin).HasColumnName("Articulo_StockMin");
            entity.Property(e => e.TipoArticulo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tipo_Articulo");
        });

        modelBuilder.Entity<CvtArticuloDocumento>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("PK_CVT_ArticuloDocumento_1");

            entity.ToTable("CVT_ArticuloDocumento");

            entity.Property(e => e.DocId).HasColumnName("Doc_Id");
            entity.Property(e => e.ArticuloId).HasColumnName("Articulo_Id");
            entity.Property(e => e.DocFecha)
                .HasColumnType("datetime")
                .HasColumnName("Doc_Fecha");
            entity.Property(e => e.DocNumero)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Doc_Numero");
            entity.Property(e => e.DocPrecio).HasColumnName("Doc_Precio");
            entity.Property(e => e.DocStock).HasColumnName("Doc_Stock");
        });

        modelBuilder.Entity<CvtAseoDiarioProduccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_ASEO_DIARIO_PRODUCCION");

            entity.Property(e => e.AseoddiarioId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ASEODDIARIO_ID");
            entity.Property(e => e.BarridoPisoSala).HasColumnName("BARRIDO_PISO_SALA");
            entity.Property(e => e.FechaVerificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VERIFICACION");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.SacosBarridoAmarradosPesados).HasColumnName("SACOS_BARRIDO_AMARRADOS_PESADOS");
            entity.Property(e => e.SacosReenvasadoAmarradosPesados).HasColumnName("SACOS_REENVASADO_AMARRADOS_PESADOS");
            entity.Property(e => e.SoplarMaquina).HasColumnName("SOPLAR_MAQUINA");
            entity.Property(e => e.Verificador).HasColumnName("VERIFICADOR");
        });

        modelBuilder.Entity<CvtAsignacionFoliosCheque>(entity =>
        {
            entity.HasKey(e => e.NInternoSap);

            entity.ToTable("CVT_AsignacionFoliosCheques");

            entity.Property(e => e.NInternoSap)
                .ValueGeneratedNever()
                .HasColumnName("N_Interno_SAP");
            entity.Property(e => e.FolioAsignado).HasColumnName("Folio_Asignado");
            entity.Property(e => e.FolioCorrecto).HasColumnName("Folio_Correcto");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAsignacionRutum>(entity =>
        {
            entity.HasKey(e => e.AsignacionId);

            entity.ToTable("CVT_AsignacionRuta");

            entity.Property(e => e.AsignacionId).HasColumnName("Asignacion_ID");
            entity.Property(e => e.CamionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Camion_ID");
            entity.Property(e => e.Carro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Chofer)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Observacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtAsistenciaJbd>(entity =>
        {
            entity.HasKey(e => e.AsistenciaId);

            entity.ToTable("CVT_Asistencia_JBD");

            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[ObtieneEmpresaTrabajador]([Id_Personal]))", false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.HoraEntrada).HasColumnName("Hora_Entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_Salida");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MinutosTrabajados)
                .HasComputedColumnSql("([dbo].[TotalTiempoAsistenciaJBD]([Asistencia_Id]))", false)
                .HasColumnName("Minutos_Trabajados");
            entity.Property(e => e.TotalHorasTrabajadas)
                .HasComputedColumnSql("([dbo].[TotalHorasTrabajadasJBD]([Asistencia_Id]))", false)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMinTrabajados).HasComputedColumnSql("([dbo].[TotalMinutosTrabajadosJBD]([Asistencia_Id],[Id_Area]))", false);
            entity.Property(e => e.TotalPagoxHoras).HasComputedColumnSql("([dbo].[TotalPagoxHorasJBD]([Asistencia_Id],[Id_Labores]))", false);
        });

        modelBuilder.Entity<CvtAsistenciaRelojControl>(entity =>
        {
            entity.HasKey(e => e.IdAsistencia);

            entity.ToTable("CVT_AsistenciaRelojControl");

            entity.Property(e => e.IdAsistencia).HasColumnName("Id_Asistencia");
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.HeSalida).HasColumnName("HE_Salida");
            entity.Property(e => e.HoraInicio).HasColumnName("Hora_Inicio");
            entity.Property(e => e.HoraTermino).HasColumnName("Hora_Termino");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAsistencium>(entity =>
        {
            entity.HasKey(e => e.AsistenciaId);

            entity.ToTable("CVT_Asistencia");

            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[ObtieneEmpresaTrabajador]([Id_Personal]))", false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.HoraEntrada).HasColumnName("Hora_Entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_Salida");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MinutosTrabajados)
                .HasComputedColumnSql("([dbo].[TotalTiempoAsistencia]([Asistencia_Id]))", false)
                .HasColumnName("Minutos_Trabajados");
            entity.Property(e => e.TotalHorasTrabajadas)
                .HasComputedColumnSql("([dbo].[TotalHorasTrabajadas]([Asistencia_Id]))", false)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMinTrabajados).HasComputedColumnSql("([dbo].[TotalMinutosTrabajados]([Asistencia_Id],[Id_Area]))", false);
            entity.Property(e => e.TotalPagoxHoras).HasComputedColumnSql("([dbo].[TotalPagoxHoras]([Asistencia_Id],[Id_Labores]))", false);
        });

        modelBuilder.Entity<CvtAspectoPregunta>(entity =>
        {
            entity.HasKey(e => e.IdAspectoPregunta);

            entity.ToTable("CVT_AspectoPreguntas");

            entity.Property(e => e.IdAspectoPregunta).HasColumnName("Id_AspectoPregunta");
            entity.Property(e => e.Aspecto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtAuditoriaRecepcione>(entity =>
        {
            entity.HasKey(e => e.IdAuditoria);

            entity.ToTable("CVT_AuditoriaRecepciones");

            entity.Property(e => e.IdAuditoria).HasColumnName("Id_Auditoria");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAuditoria)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Auditoria");
            entity.Property(e => e.GrueroAsignado1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gruero_Asignado_1");
            entity.Property(e => e.GrueroAsignado2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gruero_Asignado_2");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtBitacoraProyecto>(entity =>
        {
            entity.HasKey(e => e.IdBitacora);

            entity.ToTable("CVT_BitacoraProyectos");

            entity.Property(e => e.IdBitacora).HasColumnName("Id_Bitacora");
            entity.Property(e => e.Detalle).IsUnicode(false);
            entity.Property(e => e.FechaInicial)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Inicial");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Termino");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.Proyecto).IsUnicode(false);
            entity.Property(e => e.Responsable).IsUnicode(false);
        });

        modelBuilder.Entity<CvtBulto>(entity =>
        {
            entity.HasKey(e => e.IdBulto)
                .HasName("CVT_Bultos_PK")
                .IsClustered(false);

            entity.ToTable("CVT_Bultos", tb => tb.HasTrigger("CVT_BultosUPDATE"));

            entity.Property(e => e.AltoMaximo)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Alto_Maximo");
            entity.Property(e => e.AnchoMaximo)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Ancho_Maximo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.LargoMaximo)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Largo_Maximo");
            entity.Property(e => e.Peso).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtCaProveedoresNacionale>(entity =>
        {
            entity.HasKey(e => e.CaPnId);

            entity.ToTable("CVT_CA_ProveedoresNacionales");

            entity.Property(e => e.CaPnId).HasColumnName("CA_PN_ID");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCabeceraInventario>(entity =>
        {
            entity.HasKey(e => e.InventarioId);

            entity.ToTable("CVT_CabeceraInventario");

            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdUsuarioEncargado).HasColumnName("Id_UsuarioEncargado");
        });

        modelBuilder.Entity<CvtCamionCarga>(entity =>
        {
            entity.HasKey(e => e.IdCamionCarga)
                .HasName("CVT_CamionCarga_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CamionCarga", tb => tb.HasTrigger("CVT_CamionCargaUPDATE"));

            entity.Property(e => e.DescripcionRuta)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaDespacho)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Obs1)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.Obs2)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.ObsEntrega)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
            entity.Property(e => e.PatenteCarro)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
        });

        modelBuilder.Entity<CvtCamionCargaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdCamionCarga, e.IdContenedorCarga })
                .HasName("CVT_CamCargaDet_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CamionCargaDet", tb => tb.HasTrigger("CVT_CamionCargaDetUPDATE"));

            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.ObsCarga)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtCapacidadUbicacionesWm>(entity =>
        {
            entity.HasKey(e => new { e.SiteId, e.LayoutId })
                .HasName("CVT_CapUbica_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CapacidadUbicacionesWMS");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_id");
            entity.Property(e => e.BodegaSap)
                .HasMaxLength(10)
                .HasDefaultValue(" ")
                .HasColumnName("BodegaSAP");
            entity.Property(e => e.CantPallets).HasColumnName("Cant_Pallets");
        });

        modelBuilder.Entity<CvtCategoriaDetencione>(entity =>
        {
            entity.HasKey(e => e.CategoriaId);

            entity.ToTable("CVT_CategoriaDetenciones");

            entity.Property(e => e.CategoriaId).HasColumnName("Categoria_Id");
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
        });

        modelBuilder.Entity<CvtCategoriaGastoCamion>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaGasto).HasName("PK_CVT_CategoriaGasto");

            entity.ToTable("CVT_CategoriaGastoCamion");

            entity.Property(e => e.IdCategoriaGasto).HasColumnName("Id_CategoriaGasto");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCategoriaHallazgoMe>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaHallazgo);

            entity.ToTable("CVT_CategoriaHallazgoME");

            entity.Property(e => e.IdCategoriaHallazgo).HasColumnName("Id_CategoriaHallazgo");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCfgEstructuraLotesCab>(entity =>
        {
            entity.HasKey(e => e.IdCodificacion)
                .HasName("CVT_CfgEstCab_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CfgEstructuraLotesCab");

            entity.Property(e => e.CodEjemplo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.DescripcionAmplia)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.NombreCodificacion)
                .HasMaxLength(150)
                .HasDefaultValue(" ");
            entity.Property(e => e.Separador)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.VigenciaFin)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("Vigencia_Fin");
            entity.Property(e => e.VigenciaIni)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("Vigencia_Ini");
        });

        modelBuilder.Entity<CvtCfgEstructuraLotesDatum>(entity =>
        {
            entity.HasKey(e => new { e.IdDiccionario, e.IdCodItemDetalle })
                .HasName("CVT_CfgEstData_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CfgEstructuraLotesData");

            entity.Property(e => e.CodItemDetalle)
                .HasMaxLength(10)
                .HasDefaultValue(" ");
            entity.Property(e => e.DescDiccionario)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.DescItemDetalle)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.RefCampoSap)
                .HasMaxLength(10)
                .HasDefaultValue(" ")
                .HasColumnName("RefCampoSAP");
            entity.Property(e => e.RefTablaSap)
                .HasMaxLength(10)
                .HasDefaultValue(" ")
                .HasColumnName("RefTablaSAP");
            entity.Property(e => e.RefValorCampoSap)
                .HasMaxLength(100)
                .HasDefaultValue(" ")
                .HasColumnName("RefValorCampoSAP");
        });

        modelBuilder.Entity<CvtCfgEstructuraLotesDet>(entity =>
        {
            entity.HasKey(e => new { e.IdCodificacion, e.IdCodDetPosicion })
                .HasName("CVT_CfgEstDet_PK")
                .IsClustered(false);

            entity.ToTable("CVT_CfgEstructuraLotesDet");

            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(150)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtCheckListArmadoPedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId);

            entity.ToTable("CVT_CheckList_ArmadoPedido");

            entity.Property(e => e.PedidoId)
                .ValueGeneratedNever()
                .HasColumnName("Pedido_Id");
            entity.Property(e => e.Dun14).HasColumnName("DUN14");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fefo).HasColumnName("FEFO");
            entity.Property(e => e.LugarArmado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observasiones).IsUnicode(false);
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
        });

        modelBuilder.Entity<CvtChecklistGrua>(entity =>
        {
            entity.HasKey(e => e.RegistroChecklistGruaId);

            entity.ToTable("CVT_Checklist_Grua");

            entity.Property(e => e.RegistroChecklistGruaId).HasColumnName("RegistroChecklistGrua_Id");
            entity.Property(e => e.AlarmaRetroceso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Alarma_Retroceso");
            entity.Property(e => e.AreaTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Area_Trabajo");
            entity.Property(e => e.BalizaPertiga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Baliza_Pertiga");
            entity.Property(e => e.CadenasTorre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cadenas_Torre");
            entity.Property(e => e.CinturonSeguridad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cinturon_Seguridad");
            entity.Property(e => e.EscaleraAccesoPasamanos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Escalera_Acceso_Pasamanos");
            entity.Property(e => e.EspejoRetrovisor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Espejo_Retrovisor");
            entity.Property(e => e.EstadoAsiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Asiento");
            entity.Property(e => e.EstadoBateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Bateria");
            entity.Property(e => e.EstadoBocina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Bocina");
            entity.Property(e => e.EstadoDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Direccion");
            entity.Property(e => e.EstadoExtintor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Extintor");
            entity.Property(e => e.EstadoLuces)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Luces");
            entity.Property(e => e.EstadoMotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Motor");
            entity.Property(e => e.EstadoNeumaticos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Neumaticos");
            entity.Property(e => e.EstadoTableroDatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Tablero_Datos");
            entity.Property(e => e.EstadoTransmision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_Transmision");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FlexiblePoleaRodamiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Flexible_Polea_Rodamiento");
            entity.Property(e => e.FugaAguaAceite)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fuga_Agua_Aceite");
            entity.Property(e => e.Horometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LlantasTuercas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Llantas_Tuercas");
            entity.Property(e => e.NumeroGrua)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Grua");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PuntoBloqueo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Punto_Bloqueo");
            entity.Property(e => e.SeguroUnaHorquilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Seguro_Una_Horquilla");
            entity.Property(e => e.SoporteCilindro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Soporte_Cilindro");
            entity.Property(e => e.TipoMaquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Maquina");
            entity.Property(e => e.Turno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnasHorquilla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Unas_Horquilla");
            entity.Property(e => e.UsuarioResponsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Responsable");
        });

        modelBuilder.Entity<CvtChequeMontoSeparado>(entity =>
        {
            entity.HasKey(e => e.CheckKey)
                .HasName("CVT_ChkMtoSep_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ChequeMontoSeparado");

            entity.Property(e => e.Centena)
                .HasMaxLength(1)
                .HasDefaultValue("");
            entity.Property(e => e.CentenaMil)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Centena_Mil");
            entity.Property(e => e.CentenaMillon)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Centena_Millon");
            entity.Property(e => e.Decena)
                .HasMaxLength(1)
                .HasDefaultValue("");
            entity.Property(e => e.DecenaMil)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Decena_Mil");
            entity.Property(e => e.DecenaMillon)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Decena_Millon");
            entity.Property(e => e.Unidad)
                .HasMaxLength(1)
                .HasDefaultValue("");
            entity.Property(e => e.UnidadBillon)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Unidad_Billon");
            entity.Property(e => e.UnidadMil)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Unidad_Mil");
            entity.Property(e => e.UnidadMillon)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Unidad_Millon");
        });

        modelBuilder.Entity<CvtCmbGrupoProductoCompraImpVistum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_CmbGrupoProductoCompraImp_Vista");

            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtCmbProductosCompraImpVistum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_CmbProductosCompraImp_Vista");

            entity.Property(e => e.DescProducto).HasMaxLength(100);
            entity.Property(e => e.ItemCode).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtCmbProveedorCompraImpVistum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_CmbProveedorCompraImp_Vista");

            entity.Property(e => e.CardCode).HasMaxLength(15);
            entity.Property(e => e.CardName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtCobranzaCvtBma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_Cobranza_CVT_BMAS");

            entity.Property(e => e.Abonos).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.CiudadPbi).HasMaxLength(104);
            entity.Property(e => e.CodProveedor).HasMaxLength(15);
            entity.Property(e => e.Comuna).HasMaxLength(100);
            entity.Property(e => e.ComunaPbi).HasMaxLength(104);
            entity.Property(e => e.CondicionPago).HasMaxLength(100);
            entity.Property(e => e.DocRelacionado).HasMaxLength(18);
            entity.Property(e => e.Empresa)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaCon).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.GrpEmpresa).HasMaxLength(40);
            entity.Property(e => e.GrupProveedor).HasMaxLength(100);
            entity.Property(e => e.GrupoVencimiento)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.GrupoVenta).HasMaxLength(40);
            entity.Property(e => e.LineaCreditoUf)
                .HasMaxLength(15)
                .HasColumnName("LineaCreditoUF");
            entity.Property(e => e.ListaNegra)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Nota).HasColumnType("numeric(22, 4)");
            entity.Property(e => e.NumRegion)
                .HasMaxLength(3)
                .HasColumnName("Num_Region");
            entity.Property(e => e.Oc)
                .HasMaxLength(100)
                .HasColumnName("OC");
            entity.Property(e => e.Pendiente).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.SeguroFecha).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.Uf)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("UF");
            entity.Property(e => e.Vendedor).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtComisionVendedor>(entity =>
        {
            entity.HasKey(e => e.ItemCode).HasName("PK_CVT_ComisionVendedor_1");

            entity.ToTable("CVT_ComisionVendedor");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoComision)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtComparativoVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_Comparativo_Ventas");

            entity.Property(e => e.Canal)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Clp)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CLP");
            entity.Property(e => e.ClpSrapel)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CLP_SRapel");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CostoTotal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Costo_Total");
            entity.Property(e => e.Grupo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Perdiodo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.PrcRentabilidad)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Prc_Rentabilidad");
            entity.Property(e => e.Producto).IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Vendedor)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCompromisoKit>(entity =>
        {
            entity.HasKey(e => e.CkitId);

            entity.ToTable("CVT_CompromisoKIT");

            entity.Property(e => e.CkitId).HasColumnName("CKIT_ID");
            entity.Property(e => e.ClienteNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCompromisoKitdetalle>(entity =>
        {
            entity.HasKey(e => e.CkitdetId);

            entity.ToTable("CVT_CompromisoKITDetalle");

            entity.Property(e => e.CkitdetId).HasColumnName("CKITDET_ID");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CkitId).HasColumnName("CKIT_ID");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEMCODE");
        });

        modelBuilder.Entity<CvtConfGrupoArticulo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.ToTable("CVT_ConfGrupoArticulos");

            entity.Property(e => e.IdGrupo)
                .ValueGeneratedNever()
                .HasColumnName("Id_Grupo");
            entity.Property(e => e.CtaAjuste)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaAjuste");
            entity.Property(e => e.CtaDesecho)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaDesecho");
            entity.Property(e => e.CtaFaltante)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaFaltante");
            entity.Property(e => e.CtaHurto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaHurto");
            entity.Property(e => e.CtaMuestra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaMuestra");
            entity.Property(e => e.CtaTransformacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaTransformacion");
        });

        modelBuilder.Entity<CvtContenedorCarga>(entity =>
        {
            entity.HasKey(e => e.IdContenedorCarga)
                .HasName("CVT_ContCarga_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ContenedorCarga", tb => tb.HasTrigger("CVT_ContenedorCargaUPDATE"));

            entity.Property(e => e.CantPedidoSap)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantPedidoSAP");
            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CantidadProdAltura).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CantidadProdBase).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.ObsEntrega)
                .HasMaxLength(150)
                .HasDefaultValue(" ");
            entity.Property(e => e.ObsIndUsoPallet)
                .HasMaxLength(150)
                .HasDefaultValue(" ");
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.VolTotalPallets).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtContenedorCargaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdContenedorCarga, e.IdContCargaDet })
                .HasName("CVT_ContCargaDet_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ContenedorCargaDet", tb => tb.HasTrigger("CVT_ContenedorCargaDetUPDATE"));

            entity.Property(e => e.CantPedidoSap)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantPedidoSAP");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.EstadoCarga).HasComment("Indica si producto está confirmado o dentro del pallet");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.VolTotalPallets).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtContenedorCargaDetPalletUnico>(entity =>
        {
            entity.HasKey(e => new { e.IdContenedorCarga, e.IdContCargaDet })
                .HasName("CVT_ContCargaDetPalleUnic_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ContenedorCargaDetPalletUnico");

            entity.Property(e => e.CantPedidoSap)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantPedidoSAP");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.VolTotalPallets).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtContenedore>(entity =>
        {
            entity.HasKey(e => e.IdContenedor)
                .HasName("CVT_Cont_PK")
                .IsClustered(false);

            entity.ToTable("CVT_Contenedores", tb => tb.HasTrigger("CVT_ContenedoresDELETE"));

            entity.Property(e => e.Alto).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Ancho).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Largo).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Material)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Peso).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Tipo).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<CvtContorlEnvasadoPtPuestaEnMarchaLinea>(entity =>
        {
            entity.HasKey(e => e.IdPuestaEnMarchaLinea);

            entity.ToTable("CVT_ContorlEnvasadoPT_PuestaEnMarchaLinea");

            entity.Property(e => e.IdPuestaEnMarchaLinea).HasColumnName("ID_PuestaEnMarchaLinea");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.TieneFilmAmano).HasColumnName("TieneFilmAMano");
        });

        modelBuilder.Entity<CvtControlAcceso>(entity =>
        {
            entity.HasKey(e => e.AccesoCamionId);

            entity.ToTable("CVT_ControlAcceso");

            entity.Property(e => e.AccesoCamionId).HasColumnName("AccesoCamion_Id");
            entity.Property(e => e.Chofer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.IdCamion).HasColumnName("Id_Camion");
            entity.Property(e => e.IdChofer).HasColumnName("Id_Chofer");
            entity.Property(e => e.Patente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatenteRampla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Patente_Rampla");
        });

        modelBuilder.Entity<CvtControlAccesoCamion>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("CVT_ControlAccesoCamion");

            entity.Property(e => e.IdRegistro).HasColumnName("Id_registro");
            entity.Property(e => e.ChoferId).HasColumnName("Chofer_Id");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Salida");
            entity.Property(e => e.NumDocumento).HasColumnName("Num_Documento");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PatenteRampla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Patente_Rampla");
            entity.Property(e => e.Referencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento).HasColumnName("Tipo_Documento");
            entity.Property(e => e.TipoTransporte).HasColumnName("Tipo_Transporte");
        });

        modelBuilder.Entity<CvtControlAccesoChofer>(entity =>
        {
            entity.HasKey(e => e.IdChofer);

            entity.ToTable("CVT_ControlAccesoChofer");

            entity.Property(e => e.IdChofer).HasColumnName("Id_Chofer");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Run)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RUN");
        });

        modelBuilder.Entity<CvtControlAccesoVisitum>(entity =>
        {
            entity.HasKey(e => e.VisitaId);

            entity.ToTable("CVT_ControlAcceso_Visita");

            entity.Property(e => e.VisitaId).HasColumnName("Visita_Id");
            entity.Property(e => e.Empleado).HasMaxLength(30);
            entity.Property(e => e.Empresa)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Epp).HasColumnName("EPP");
            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntarjeta).HasColumnName("NTarjeta");
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Run)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RUN");
        });

        modelBuilder.Entity<CvtControlBodega>(entity =>
        {
            entity.HasKey(e => e.ControlId);

            entity.ToTable("CVT_ControlBodega");

            entity.Property(e => e.ControlId).HasColumnName("Control_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaJustificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Justificacion");
            entity.Property(e => e.Justificacion).IsUnicode(false);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.LoteDestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Destino");
            entity.Property(e => e.LoteOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Origen");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageIdDestino).HasColumnName("Package_Id_Destino");
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
            entity.Property(e => e.StaffIdJustificacion).HasColumnName("Staff_Id_Justificacion");
            entity.Property(e => e.TipoControl).HasColumnName("Tipo_Control");
        });

        modelBuilder.Entity<CvtControlEnvasadoPt>(entity =>
        {
            entity.HasKey(e => e.IdControlEnvPt);

            entity.ToTable("CVT_ControlEnvasadoPT");

            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaValidacion).HasColumnType("datetime");
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.Marca).IsUnicode(false);
            entity.Property(e => e.MateriaPrima).IsUnicode(false);
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Origen1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlEnvasadoPtAseoDiario>(entity =>
        {
            entity.HasKey(e => e.IdAseoDiarioPt);

            entity.ToTable("CVT_ControlEnvasadoPT_AseoDiario");

            entity.Property(e => e.IdAseoDiarioPt).HasColumnName("id_AseoDiarioPT");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Observaciones).IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlEnvasadoPtControlPesoLinea>(entity =>
        {
            entity.HasKey(e => e.IdControlEnvasadoPtContPeso);

            entity.ToTable("CVT_ControlEnvasadoPT_ControlPesoLinea");

            entity.Property(e => e.IdControlEnvasadoPtContPeso).HasColumnName("Id_ControlEnvasadoPT_ContPeso");
            entity.Property(e => e.CodBarraBolsa).HasColumnName("Cod_Barra_Bolsa");
            entity.Property(e => e.CodBarraContenedora).HasColumnName("Cod_Barra_Contenedora");
            entity.Property(e => e.FechaElaboracion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Elaboracion");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
        });

        modelBuilder.Entity<CvtControlEnvasadoPtDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleControlEnvPt).HasName("PK_CVT_ControlEnvPT_Detalle");

            entity.ToTable("CVT_ControlEnvasadoPT_Detalle");

            entity.Property(e => e.IdDetalleControlEnvPt).HasColumnName("ID_DetalleControlEnvPT");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.OrigenMerma).IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlEnvasadoPtMotivoMerma>(entity =>
        {
            entity.HasKey(e => e.IdMotivo);

            entity.ToTable("CVT_ControlEnvasadoPT_MotivoMerma");

            entity.Property(e => e.IdMotivo).HasColumnName("id_Motivo");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlEnvasadoPtPuestaEnMarchaEnvasadora>(entity =>
        {
            entity.HasKey(e => e.IdPuestaEnMarchaEnvasadora);

            entity.ToTable("CVT_ControlEnvasadoPT_PuestaEnMarchaEnvasadora");

            entity.Property(e => e.IdPuestaEnMarchaEnvasadora).HasColumnName("ID_PuestaEnMarchaEnvasadora");
            entity.Property(e => e.EquipoMonitoreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Equipo_Monitoreo");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
        });

        modelBuilder.Entity<CvtControlEnvasadoPtPuestaEnMarchaMaquina>(entity =>
        {
            entity.HasKey(e => e.IdMonPuestaMarchaMaq);

            entity.ToTable("CVT_ControlEnvasadoPT_PuestaEnMarchaMaquina");

            entity.Property(e => e.IdMonPuestaMarchaMaq).HasColumnName("Id_MonPuestaMarcha_Maq");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.LineaOperativa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TermoEnfardadora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TermoEnfardadoraLimpiezaCab)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tto1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTO1");
            entity.Property(e => e.Tto1limPiezaCabezal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTO1LimPiezaCabezal");
            entity.Property(e => e.Tto2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTO2");
            entity.Property(e => e.Tto2limPiezaCabezal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTO2LimPiezaCabezal");
        });

        modelBuilder.Entity<CvtControlEnvasadoPtPuestaEnMarchaMonitoreo>(entity =>
        {
            entity.HasKey(e => e.IdPuestaEnMarchaMonitoreo);

            entity.ToTable("CVT_ControlEnvasadoPT_PuestaEnMarchaMonitoreo");

            entity.Property(e => e.IdPuestaEnMarchaMonitoreo).HasColumnName("ID_PuestaEnMarchaMonitoreo");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.GolpesMin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Golpes_Min");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Observacion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Turno)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlEnvasadoPtUsoCintaImpresion>(entity =>
        {
            entity.HasKey(e => e.IdUsoCintaImp);

            entity.ToTable("CVT_ControlEnvasadoPT_UsoCintaImpresion");

            entity.Property(e => e.IdUsoCintaImp).HasColumnName("ID_UsoCintaImp");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Lote).IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlFosfina>(entity =>
        {
            entity.HasKey(e => e.IdControlFosfina);

            entity.ToTable("CVT_CONTROL_FOSFINA");

            entity.Property(e => e.A1A2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("A1_A2");
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaFumigacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFumigacion).HasColumnType("datetime");
            entity.Property(e => e.FechaReg).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MayorPpm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MayorPPM");
        });

        modelBuilder.Entity<CvtControlHigene>(entity =>
        {
            entity.HasKey(e => e.IdControlHigene);

            entity.ToTable("CVT_ControlHigene");

            entity.Property(e => e.IdControlHigene).HasColumnName("Id_ControlHigene");
            entity.Property(e => e.AccionCorrectiva)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Accion_Correctiva");
            entity.Property(e => e.AfeitadoPeloCorto).HasColumnName("Afeitado_PeloCorto");
            entity.Property(e => e.Año).HasComputedColumnSql("(datepart(year,[Fecha]))", false);
            entity.Property(e => e.EstadoUniforme).HasColumnName("Estado_Uniforme");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HeridaExpuesta).HasColumnName("Herida_Expuesta");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdMonitor).HasColumnName("Id_Monitor");
            entity.Property(e => e.IdPersona).HasColumnName("Id_Persona");
            entity.Property(e => e.LimpiezaUniforme).HasColumnName("Limpieza_Uniforme");
            entity.Property(e => e.Mes).HasComputedColumnSql("(datepart(month,[Fecha]))", false);
            entity.Property(e => e.PorcentajeCumplimiento)
                .HasComputedColumnSql("(((((((([Limpieza_Uniforme]+[Afeitado_PeloCorto])+[Uñas])+[Joyas])+[Higene])+[Herida_Expuesta])/(6))*(100))/(7))", false)
                .HasColumnName("Porcentaje_Cumplimiento");
            entity.Property(e => e.Promedio).HasComputedColumnSql("(((((([Limpieza_Uniforme]+[Afeitado_PeloCorto])+[Uñas])+[Joyas])+[Higene])+[Herida_Expuesta])/(6))", false);
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("Tipo_Contrato");
        });

        modelBuilder.Entity<CvtControlLineasPacking>(entity =>
        {
            entity.HasKey(e => e.ControlLineaId);

            entity.ToTable("CVT_ControlLineasPacking");

            entity.Property(e => e.ControlLineaId).HasColumnName("ControlLinea_Id");
            entity.Property(e => e.CantCajas).HasComputedColumnSql("([CantPallets70]*(70)+[CantPallets30]*(30))", false);
            entity.Property(e => e.CintaAdhesiva)
                .HasComputedColumnSql("(([CantPallets70]*(70)+[CantPallets30]*(30))*(0.6))", false)
                .HasColumnType("numeric(12, 1)");
            entity.Property(e => e.Corchetes).HasComputedColumnSql("(([CantPallets70]*(70)+[CantPallets30]*(30))*(4))", false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FilmPaletizado)
                .HasComputedColumnSql("(([CantPallets70]+[CantPallets30])*(0.8))", false)
                .HasColumnType("numeric(12, 1)");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Pallets).HasComputedColumnSql("([CantPallets70]+[CantPallets30])", false);
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
        });

        modelBuilder.Entity<CvtControlPesoPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ControlPesoPallet");

            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.DosificadoPromedioContenedora).HasColumnType("decimal(30, 14)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nlinea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLinea");
            entity.Property(e => e.PesoAproximadoMp)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("PesoAproximadoMP");
            entity.Property(e => e.PesoIdeal).HasColumnType("numeric(30, 6)");
            entity.Property(e => e.PesoPallet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PesoPromedioFilm).HasColumnName("PesoPromedioFILM");
            entity.Property(e => e.PesoUm)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("PesoUM");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.Sscc).HasColumnName("SSCC");
        });

        modelBuilder.Entity<CvtControlPesoProductoPalletizado>(entity =>
        {
            entity.HasKey(e => e.IdContrPesoPallet);

            entity.ToTable("CVT_ControlPeso_ProductoPalletizado");

            entity.Property(e => e.IdContrPesoPallet).HasColumnName("Id_ContrPesoPallet");
            entity.Property(e => e.CodProducto).IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdEtiquetadora).HasColumnName("Id_Etiquetadora");
            entity.Property(e => e.IdUsuarioVerificador).HasColumnName("Id_UsuarioVerificador");
            entity.Property(e => e.Lote).IsUnicode(false);
        });

        modelBuilder.Entity<CvtControlPesoProductoPalletizadoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetControlPesoPallet);

            entity.ToTable("CVT_ControlPeso_ProductoPalletizado_Detalle");

            entity.Property(e => e.IdDetControlPesoPallet).HasColumnName("Id_DetControlPesoPallet");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.IdContrPesoPallet).HasColumnName("Id_ContrPesoPallet");
            entity.Property(e => e.Merma).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Nlinea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLinea");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.PesoPallet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.SaldoPallet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Sscc).HasColumnName("SSCC");
        });

        modelBuilder.Entity<CvtControlPesoPt>(entity =>
        {
            entity.HasKey(e => e.IdControlPesoPt);

            entity.ToTable("CVT_ControlPesoPT");

            entity.Property(e => e.IdControlPesoPt).HasColumnName("Id_ControlPesoPT");
            entity.Property(e => e.Correccion).IsUnicode(false);
            entity.Property(e => e.HoraAnalisis).HasColumnName("Hora_analisis");
            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.Idproveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDProveedor");
            entity.Property(e => e.Of).HasColumnName("OF");
        });

        modelBuilder.Entity<CvtCostoKmtransporte>(entity =>
        {
            entity.HasKey(e => e.TipoTransporte);

            entity.ToTable("CVT_CostoKMTransporte");

            entity.Property(e => e.TipoTransporte).ValueGeneratedNever();
            entity.Property(e => e.SiglaTransporte)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtCostoPorCamion>(entity =>
        {
            entity.HasKey(e => e.IdCostoCamion);

            entity.ToTable("CVT_CostoPorCamion");

            entity.Property(e => e.IdCostoCamion).HasColumnName("Id_CostoCamion");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.IdGastoCamion).HasColumnName("Id_GastoCamion");
            entity.Property(e => e.Nrendicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NRendicion");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtDescripcionDeCamione>(entity =>
        {
            entity.HasKey(e => e.Patente);

            entity.ToTable("CVT_DescripcionDeCamiones");

            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Año)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdTipoCarroceria).HasColumnName("Id_TipoCarroceria");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCorto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtDescripcionVehiculo>(entity =>
        {
            entity.HasKey(e => e.Patente);

            entity.ToTable("CVT_DescripcionVehiculo");

            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca).IsUnicode(false);
        });

        modelBuilder.Entity<CvtDesechosporgrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_DESECHOSPORGRUPO");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Dia).HasColumnName("dia");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Producto).HasMaxLength(200);
        });

        modelBuilder.Entity<CvtDetalleCostosImportacion>(entity =>
        {
            entity.HasKey(e => new { e.Oc, e.CodigoPrecioEntrega });

            entity.ToTable("CVT_DetalleCostosImportacion");

            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.CodigoPrecioEntrega)
                .HasMaxLength(2)
                .HasColumnName("Codigo_PrecioEntrega");
            entity.Property(e => e.DetalleCostoImportacionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DetalleCostoImportacion_Id");
            entity.Property(e => e.Imputacion)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Obs)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_OBSCosteoOC]([OC],[Codigo_PrecioEntrega]))", false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtDetalleGastosCamion>(entity =>
        {
            entity.HasKey(e => e.IdGastoCamion);

            entity.ToTable("CVT_DetalleGastosCamion");

            entity.Property(e => e.IdGastoCamion).HasColumnName("Id_GastoCamion");
            entity.Property(e => e.DetalleGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdCategoriaGasto).HasColumnName("Id_CategoriaGasto");
            entity.Property(e => e.Item).IsUnicode(false);
        });

        modelBuilder.Entity<CvtDetalleInventario>(entity =>
        {
            entity.HasKey(e => e.InventarioDetId);

            entity.ToTable("CVT_DetalleInventario");

            entity.Property(e => e.InventarioDetId).HasColumnName("InventarioDet_Id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadPallet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fproduccion)
                .HasColumnType("datetime")
                .HasColumnName("FProduccion");
            entity.Property(e => e.Fvencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FVencimiento");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtDetalleMovimientoMantencion>(entity =>
        {
            entity.HasKey(e => e.MovimientoDetalleId);

            entity.ToTable("CVT_DetalleMovimientoMantencion");

            entity.Property(e => e.MovimientoDetalleId).HasColumnName("MovimientoDetalle_Id");
            entity.Property(e => e.ArticuloId).HasColumnName("Articulo_Id");
            entity.Property(e => e.MovimientoId).HasColumnName("Movimiento_Id");
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtDetalleNoConformidad>(entity =>
        {
            entity.HasKey(e => e.IdDetalleNoConformidad);

            entity.ToTable("CVT_DetalleNoConformidad");

            entity.Property(e => e.IdDetalleNoConformidad).HasColumnName("Id_DetalleNoConformidad");
            entity.Property(e => e.CausaOrigen).IsUnicode(false);
            entity.Property(e => e.DecEficaciaAccion).IsUnicode(false);
            entity.Property(e => e.DecSupervisionEjecucion).IsUnicode(false);
            entity.Property(e => e.DescAccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.DescAccionInmediata).IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechEvaluacionEficaciaAccion).HasColumnType("datetime");
            entity.Property(e => e.FechPlazoAccionCorrectiva).HasColumnType("datetime");
            entity.Property(e => e.FechPlazoAccionInmediata).HasColumnType("datetime");
            entity.Property(e => e.FechSupervisionEjecucion).HasColumnType("datetime");
            entity.Property(e => e.IdNoConformidad).HasColumnName("Id_NoConformidad");
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtDetalleRapel>(entity =>
        {
            entity.HasKey(e => new { e.CodCliente, e.CodProducto, e.FechaInicio, e.Sucursal });

            entity.ToTable("CVT_DetalleRapel");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Acuerdo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Centralizacion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Daymon).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.LogAuto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Log_Auto");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MermaCero)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Merma_Cero");
            entity.Property(e => e.Plataforma).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Rappel).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RepoInt).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalRapel)
                .HasComputedColumnSql("(((((((isnull([Centralizacion],(0))+isnull([RepoInt],(0)))+isnull([Daymon],(0)))+isnull([Log_Auto],(0)))+isnull([Merma_Cero],(0)))+isnull([Rappel],(0)))+isnull([Plataforma],(0)))+isnull([Acuerdo],(0)))", false)
                .HasColumnType("decimal(25, 6)");
        });

        modelBuilder.Entity<CvtDetencion>(entity =>
        {
            entity.HasKey(e => e.DetencionId);

            entity.ToTable("CVT_Detencion");

            entity.Property(e => e.DetencionId).HasColumnName("Detencion_Id");
            entity.Property(e => e.CategoriaId).HasColumnName("Categoria_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.FechConfirma).HasColumnType("datetime");
            entity.Property(e => e.HrInicio)
                .HasPrecision(4)
                .HasColumnName("Hr_Inicio");
            entity.Property(e => e.HrTermino)
                .HasPrecision(4)
                .HasColumnName("Hr_Termino");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Motivo_Cod");
            entity.Property(e => e.OfId).HasColumnName("OF_Id");
            entity.Property(e => e.TotalMinutosDetencion).HasComputedColumnSql("([dbo].[TotalTiempoDetencion]([Detencion_Id]))", false);
        });

        modelBuilder.Entity<CvtDocControlAcceso>(entity =>
        {
            entity.HasKey(e => e.DocControlAccesoId).HasName("PK_DocControlAcceso");

            entity.ToTable("CVT_DocControlAcceso");

            entity.Property(e => e.DocControlAccesoId).HasColumnName("DocControlAcceso_Id");
            entity.Property(e => e.Comentario)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ControlAccesoId).HasColumnName("ControlAcceso_Id");
            entity.Property(e => e.Extencion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Mime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtEficienciaEnvasadoPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_EficienciaEnvasadoPBI");

            entity.Property(e => e.Abocador).HasMaxLength(20);
            entity.Property(e => e.Calidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.DetNoPlanificada).HasColumnName("Det_NoPlanificada");
            entity.Property(e => e.DetPlanificada).HasColumnName("Det_Planificada");
            entity.Property(e => e.DetSinCategorizar).HasColumnName("Det_SinCategorizar");
            entity.Property(e => e.DetTotal).HasColumnName("Det_Total");
            entity.Property(e => e.Disponibilidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.GolpesReales)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Linea).HasMaxLength(20);
            entity.Property(e => e.Oee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OEE");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.Pnc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("PNC");
            entity.Property(e => e.ProduccionEsperada).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.Rendimiento).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtElemento>(entity =>
        {
            entity.HasKey(e => e.IdElemento);

            entity.ToTable("CVT_Elemento");

            entity.Property(e => e.IdElemento).HasColumnName("ID_Elemento");
            entity.Property(e => e.Elemento)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtEmpleadoSueldoBase>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId);

            entity.ToTable("CVT_EmpleadoSueldoBase");

            entity.Property(e => e.EmpleadoId)
                .HasMaxLength(50)
                .HasColumnName("Empleado_Id");
            entity.Property(e => e.SueldoBase).HasColumnName("Sueldo_Base");
        });

        modelBuilder.Entity<CvtEmpresasNegocio>(entity =>
        {
            entity.HasKey(e => e.RutEmpresa);

            entity.ToTable("CVT_EmpresasNegocio");

            entity.Property(e => e.RutEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpresa).IsUnicode(false);
        });

        modelBuilder.Entity<CvtEntidad>(entity =>
        {
            entity.HasKey(e => e.EntidadId);

            entity.ToTable("CVT_Entidad");

            entity.Property(e => e.EntidadId).HasColumnName("Entidad_Id");
            entity.Property(e => e.EntidadNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entidad_Nombre");
        });

        modelBuilder.Entity<CvtEntradaInsumo>(entity =>
        {
            entity.HasKey(e => e.EntradaInsumosId);

            entity.ToTable("CVT_EntradaInsumos");

            entity.Property(e => e.EntradaInsumosId).HasColumnName("EntradaInsumos_ID");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtEntradaInsumosDetalle>(entity =>
        {
            entity.HasKey(e => e.EntradaInsumosDetalleId);

            entity.ToTable("CVT_EntradaInsumosDetalle");

            entity.Property(e => e.EntradaInsumosDetalleId).HasColumnName("EntradaInsumosDetalle_ID");
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CantRecepcionar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CardCode).HasMaxLength(50);
            entity.Property(e => e.CardName).HasMaxLength(500);
            entity.Property(e => e.Dscription).HasMaxLength(500);
            entity.Property(e => e.EntradaInsumosId).HasColumnName("EntradaInsumos_ID");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.OpenQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtEquipo>(entity =>
        {
            entity.HasKey(e => e.IpEquipo);

            entity.ToTable("CVT_Equipo");

            entity.Property(e => e.IpEquipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IP_Equipo");
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Equipo");
        });

        modelBuilder.Entity<CvtEstadisticaGasto>(entity =>
        {
            entity.ToTable("CVT_Estadistica_Gastos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Area)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Ccosto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CCosto");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CodCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Cuenta");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GastoItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gasto_Item");
            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtEstadoActividad>(entity =>
        {
            entity.HasKey(e => e.EstadoActividadId);

            entity.ToTable("CVT_EstadoActividad");

            entity.Property(e => e.EstadoActividadId).HasColumnName("EstadoActividad_Id");
            entity.Property(e => e.EstadoActividadNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EstadoActividad_Nombre");
        });

        modelBuilder.Entity<CvtEstadosProcesoIntegra>(entity =>
        {
            entity.HasKey(e => e.TipoProceso);

            entity.ToTable("CVT_EstadosProcesoIntegra");

            entity.Property(e => e.Estado).HasDefaultValue(0);
        });

        modelBuilder.Entity<CvtEtiquetaFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ETIQUETA_FILM");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
        });

        modelBuilder.Entity<CvtExpedicionesTransformada>(entity =>
        {
            entity.HasKey(e => e.ExpedicionId);

            entity.ToTable("CVT_ExpedicionesTransformadas");

            entity.Property(e => e.ExpedicionId)
                .ValueGeneratedNever()
                .HasColumnName("Expedicion_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtFilmBobina>(entity =>
        {
            entity.HasKey(e => e.Nbobina).HasName("PK_CVT_FILM_RECEPCION_DETALLE");

            entity.ToTable("CVT_FILM_BOBINA");

            entity.Property(e => e.Nbobina)
                .ValueGeneratedNever()
                .HasColumnName("NBobina");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBajada).HasColumnType("datetime");
            entity.Property(e => e.FechaProduc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Produc");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Venc");
            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoBrutoInicial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto)
                .HasComputedColumnSql("([PesoBruto]-[PesoCono])", false)
                .HasColumnType("decimal(19, 4)");
            entity.Property(e => e.PesoNetoInicial)
                .HasComputedColumnSql("([PesoBrutoInicial]-[PesoCono])", false)
                .HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reserve_Quantity");
        });

        modelBuilder.Entity<CvtFilmDevolucion>(entity =>
        {
            entity.HasKey(e => e.IdDevoFilm);

            entity.ToTable("CVT_FILM_DEVOLUCION");

            entity.Property(e => e.IdDevoFilm).HasColumnName("id_DevoFilm");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.IdBodega).HasColumnName("idBodega");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtFilmDevolucionDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetDevolFilm);

            entity.ToTable("CVT_FILM_DEVOLUCION_DETALLE");

            entity.Property(e => e.IdDetDevolFilm).HasColumnName("Id_detDevolFilm");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto).IsUnicode(false);
            entity.Property(e => e.IdDevoFilm).HasColumnName("id_DevoFilm");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CvtFilmExpedicion>(entity =>
        {
            entity.HasKey(e => e.ExpFilmId);

            entity.ToTable("CVT_FILM_EXPEDICION");

            entity.Property(e => e.ExpFilmId).HasColumnName("ExpFilm_id");
            entity.Property(e => e.ExpFilmDateIn)
                .HasColumnType("datetime")
                .HasColumnName("ExpFilm_DateIn");
            entity.Property(e => e.ExpFilmDateOut)
                .HasColumnType("datetime")
                .HasColumnName("ExpFilm_DateOut");
            entity.Property(e => e.ExpFilmMotivo).HasColumnName("ExpFilm_Motivo");
            entity.Property(e => e.ExpFilmNote)
                .IsUnicode(false)
                .HasColumnName("ExpFilm_Note");
            entity.Property(e => e.ExpFilmNumDocSap).HasColumnName("ExpFilm_NumDocSap");
            entity.Property(e => e.ExpFilmStatus).HasColumnName("ExpFilm_Status");
            entity.Property(e => e.ExpFilmTipoDocSap).HasColumnName("ExpFilm_TipoDocSap");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
        });

        modelBuilder.Entity<CvtFilmExpedicionDetalle>(entity =>
        {
            entity.HasKey(e => new { e.SiteId, e.ExpFilmId, e.Nbobina });

            entity.ToTable("CVT_FILM_EXPEDICION_DETALLE");

            entity.Property(e => e.SiteId).HasColumnName("Site_id");
            entity.Property(e => e.ExpFilmId).HasColumnName("ExpFilm_id");
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.ExpFilmEstado).HasColumnName("ExpFilm_Estado");
            entity.Property(e => e.ExpFilmFechConfirm)
                .HasColumnType("datetime")
                .HasColumnName("ExpFilm_Fech_Confirm");
            entity.Property(e => e.ExpFilmLote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExpFilm_Lote");
            entity.Property(e => e.ExpFilmQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ExpFilm_Quantity");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
        });

        modelBuilder.Entity<CvtFilmRecepcion>(entity =>
        {
            entity.HasKey(e => e.FolioRecepFilm);

            entity.ToTable("CVT_FILM_RECEPCION");

            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.BodegaRecep).HasColumnName("Bodega_Recep");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.DocumentoSap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentoSAP");
            entity.Property(e => e.FechaRecep).HasColumnType("datetime");
            entity.Property(e => e.NumeroDocSap).HasColumnName("NumeroDocSAp");
            entity.Property(e => e.Proveedor).IsUnicode(false);
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtFilmRepaletizado>(entity =>
        {
            entity.HasKey(e => e.IdRepaletizado);

            entity.ToTable("CVT_FILM_REPALETIZADO");

            entity.Property(e => e.IdRepaletizado).HasColumnName("id_Repaletizado");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRepaletizado).HasColumnType("datetime");
            entity.Property(e => e.IdBodega).HasColumnName("idBodega");
            entity.Property(e => e.NbobinaDestino).HasColumnName("NBobinaDestino");
            entity.Property(e => e.NbobinaOrigen).HasColumnName("NBobinaOrigen");
            entity.Property(e => e.PesoBrutoOrigen).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoBrutoPickeado).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CvtFilmSolicitudTransferenciaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetSolicitud);

            entity.ToTable("CVT_FILM_SOLICITUD_TRANSFERENCIA_DETALLE");

            entity.Property(e => e.IdDetSolicitud).HasColumnName("Id_DetSolicitud");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            entity.Property(e => e.KilosAproximados)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("kilosAproximados");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtFilmSolicitudTransferencium>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.ToTable("CVT_FILM_SOLICITUD_TRANSFERENCIA");

            entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.NumeroOf).HasColumnName("NumeroOF");
        });

        modelBuilder.Entity<CvtFilmTransferenciaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetTranferencia);

            entity.ToTable("CVT_FILM_TRANSFERENCIA_DETALLE");

            entity.Property(e => e.IdDetTranferencia).HasColumnName("Id_DetTranferencia");
            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CvtFilmTransferencium>(entity =>
        {
            entity.HasKey(e => e.IdTransferenciaFilm);

            entity.ToTable("CVT_FILM_TRANSFERENCIA");

            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");
            entity.Property(e => e.FechaTransferencia).HasColumnType("datetime");
            entity.Property(e => e.Nsolicitud).HasColumnName("NSolicitud");
            entity.Property(e => e.NumeroOf).HasColumnName("NumeroOF");
        });

        modelBuilder.Entity<CvtGestionExternosBono>(entity =>
        {
            entity.ToTable("CVT_GestionExternosBono");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.MotivoBono)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Trabajador).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtGestionExternosBonoJdb>(entity =>
        {
            entity.ToTable("CVT_GestionExternosBono_JDB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.MotivoBono)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Trabajador).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtGrua>(entity =>
        {
            entity.HasKey(e => e.GruaId);

            entity.ToTable("CVT_Gruas");

            entity.Property(e => e.GruaId).HasColumnName("Grua_Id");
            entity.Property(e => e.GruaDescripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Grua_Descripcion");
            entity.Property(e => e.GruaNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Grua_Numero");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtHomologacionMonedaBancoCentral>(entity =>
        {
            entity.HasKey(e => e.MonedaCode);

            entity.ToTable("CVT_Homologacion_Moneda_BancoCentral");

            entity.Property(e => e.MonedaCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Moneda_Code");
            entity.Property(e => e.SerieBancoCentral)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Serie_BancoCentral");
        });

        modelBuilder.Entity<CvtHorariosSalida>(entity =>
        {
            entity.HasKey(e => e.IdCfgHorarios)
                .HasName("CVT_HorariosSalidas_PK")
                .IsClustered(false);

            entity.ToTable("CVT_HorariosSalidas", tb => tb.HasTrigger("CVT_HorariosSalidasUPDATE"));

            entity.Property(e => e.DescHorario)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.HorarioMax)
                .HasMaxLength(50)
                .HasDefaultValue(" ");
            entity.Property(e => e.HorarioMin)
                .HasMaxLength(50)
                .HasDefaultValue(" ");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtHorasExtra>(entity =>
        {
            entity.HasKey(e => e.ExcesoHeId);

            entity.ToTable("CVT_HorasExtras");

            entity.Property(e => e.ExcesoHeId).HasColumnName("ExcesoHE_Id");
            entity.Property(e => e.EmpleadoId)
                .HasMaxLength(50)
                .HasColumnName("Empleado_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.He100).HasColumnName("HE_100");
            entity.Property(e => e.Horas).HasPrecision(4);
        });

        modelBuilder.Entity<CvtImpresoraServ>(entity =>
        {
            entity.HasKey(e => e.IdImpresora);

            entity.ToTable("CVT_ImpresoraServ");

            entity.Property(e => e.IdImpresora).HasColumnName("Id_Impresora");
            entity.Property(e => e.NombreImp).IsUnicode(false);
            entity.Property(e => e.NombreVista).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfAdjuntosInventarioEquipo>(entity =>
        {
            entity.HasKey(e => e.IdAdjunto);

            entity.ToTable("CVT_INF_AdjuntosInventarioEquipos");

            entity.Property(e => e.IdAdjunto).HasColumnName("id_Adjunto");
            entity.Property(e => e.CodInventario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtencionArchivo).IsUnicode(false);
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.RutaArchivo).IsUnicode(false);
            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfAlarma>(entity =>
        {
            entity.HasKey(e => e.IdContrato);

            entity.ToTable("CVT_INF_Alarmas");

            entity.Property(e => e.IdContrato).ValueGeneratedNever();
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.CserviciosAdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CServiciosADT");
            entity.Property(e => e.Monitoreo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioMaestro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfAlarmasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetAlarma).HasName("PK_CVT_INF_AlarmaDetalle");

            entity.ToTable("CVT_INF_AlarmasDetalle");

            entity.Property(e => e.IdDetAlarma).HasColumnName("id_detAlarma");
            entity.Property(e => e.LugarUbicacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NombreSensor)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfAlarmasHikvision>(entity =>
        {
            entity.ToTable("CVT_INF_AlarmasHikvision");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccesoIp)
                .HasMaxLength(255)
                .HasColumnName("AccesoIP");
            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.Codificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.Firmware).HasMaxLength(255);
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.Serie).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(255);
            entity.Property(e => e.UbicacionFisica).HasMaxLength(255);
            entity.Property(e => e.Usuario).HasMaxLength(255);
            entity.Property(e => e.Zona).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtInfBajadaEquipo>(entity =>
        {
            entity.HasKey(e => e.CodActivo);

            entity.ToTable("CVT_INF_Bajada_Equipos");

            entity.Property(e => e.CodActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dpto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBajada).HasColumnType("datetime");
            entity.Property(e => e.Licencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotivoBaja)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nserie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NSerie");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.ResponsableTi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ResponsableTI");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfComputador>(entity =>
        {
            entity.ToTable("CVT_INF_Computador");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaUOficina).HasColumnName("Area u Oficina");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.CodLicencia).IsUnicode(false);
            entity.Property(e => e.DireccionIp)
                .HasMaxLength(255)
                .HasColumnName("Direccion IP");
            entity.Property(e => e.DireccionMac)
                .HasMaxLength(255)
                .HasColumnName("Direccion MAC");
            entity.Property(e => e.Disco).HasMaxLength(255);
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(255)
                .HasColumnName("Nombre Equipo");
            entity.Property(e => e.Procesador).HasMaxLength(255);
            entity.Property(e => e.Ram)
                .HasMaxLength(255)
                .HasColumnName("RAM");
            entity.Property(e => e.SistemaOperativo).HasColumnName("Sistema Operativo");
        });

        modelBuilder.Entity<CvtInfConexionRemotum>(entity =>
        {
            entity.HasKey(e => e.IdConRemota);

            entity.ToTable("CVT_INF_ConexionRemota");

            entity.Property(e => e.IdConRemota).HasColumnName("id_ConRemota");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.IdArea).HasColumnName("id_Area");
            entity.Property(e => e.IdTemViewer)
                .IsUnicode(false)
                .HasColumnName("id_TemViewer");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.UsuarioDominio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Dominio");
        });

        modelBuilder.Entity<CvtInfCorreo>(entity =>
        {
            entity.HasKey(e => e.IdCorreo);

            entity.ToTable("CVT_INF_Correos");

            entity.Property(e => e.IdCorreo).HasColumnName("Id_Correo");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Cuenta).IsUnicode(false);
            entity.Property(e => e.DominioCorreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dominioCorreo");
            entity.Property(e => e.IdArea).HasColumnName("id_Area");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<CvtInfEntregaInsumosImpresora>(entity =>
        {
            entity.HasKey(e => e.IdEntInsImp);

            entity.ToTable("CVT_INF_EntregaInsumosImpresora");

            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.FechaInstalacion).HasColumnType("datetime");
            entity.Property(e => e.Hhimpresora)
                .IsUnicode(false)
                .HasColumnName("HHimpresora");
            entity.Property(e => e.IdActivoF)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_ActivoF");
            entity.Property(e => e.IdToner).HasColumnName("id_Toner");
        });

        modelBuilder.Entity<CvtInfEntregaPeriferico>(entity =>
        {
            entity.HasKey(e => e.IdEntPeriferico);

            entity.ToTable("CVT_INF_EntregaPerifericos");

            entity.Property(e => e.IdEntPeriferico).HasColumnName("Id_EntPeriferico");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.RunUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfEntregaPerifericosDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetPeri);

            entity.ToTable("CVT_INF_EntregaPerifericos_Detalle");

            entity.Property(e => e.IdDetPeri).HasColumnName("idDetPeri");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.IdEntPeriferico).HasColumnName("Id_EntPeriferico");
        });

        modelBuilder.Entity<CvtInfEqRed>(entity =>
        {
            entity.ToTable("CVT_INF_EqRED");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Dns)
                .HasMaxLength(255)
                .HasColumnName("DNS");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Compra");
            entity.Property(e => e.Firmware).HasMaxLength(255);
            entity.Property(e => e.Gateway)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("IP");
            entity.Property(e => e.IpPublica)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IP Publica");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.MascaraSubred)
                .HasMaxLength(255)
                .HasColumnName("Mascara Subred");
            entity.Property(e => e.Modelo)
                .HasMaxLength(255)
                .HasColumnName("Modelo ");
            entity.Property(e => e.Puertos)
                .HasMaxLength(255)
                .HasColumnName("Puertos ");
            entity.Property(e => e.Sfp)
                .HasMaxLength(255)
                .HasColumnName("SFP");
            entity.Property(e => e.Ubicación).HasMaxLength(255);
            entity.Property(e => e.Usuario).HasMaxLength(255);
            entity.Property(e => e.Velocidad).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtInfEqRespaldoEnergium>(entity =>
        {
            entity.ToTable("CVT_INF_EqRespaldoEnergia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Capacidad).HasMaxLength(255);
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Entrada).HasMaxLength(255);
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.NumeroDeTomas).HasColumnName("Numero de Tomas");
            entity.Property(e => e.Potencia).HasMaxLength(255);
            entity.Property(e => e.RackDeComunicaciones)
                .HasMaxLength(255)
                .HasColumnName("Rack de comunicaciones");
            entity.Property(e => e.Salida).HasMaxLength(255);
            entity.Property(e => e.TiempoDeRespaldo)
                .HasMaxLength(255)
                .HasColumnName("Tiempo de Respaldo: ");
        });

        modelBuilder.Entity<CvtInfEqWireless>(entity =>
        {
            entity.ToTable("CVT_INF_EqWireless");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Canal).HasMaxLength(255);
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.ConectadoA)
                .HasMaxLength(255)
                .HasColumnName("Conectado a");
            entity.Property(e => e.ContraseñaAdm)
                .HasMaxLength(255)
                .HasColumnName("Contraseña Adm");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Firmware).HasMaxLength(255);
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("IP");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.SecurityType)
                .HasMaxLength(255)
                .HasColumnName("Security Type");
            entity.Property(e => e.Ssid)
                .HasMaxLength(255)
                .HasColumnName("SSID");
            entity.Property(e => e.Ubicación).HasMaxLength(255);
            entity.Property(e => e.UsuarioAdm)
                .HasMaxLength(255)
                .HasColumnName("Usuario Adm");
        });

        modelBuilder.Entity<CvtInfEquiposMovile>(entity =>
        {
            entity.HasKey(e => e.IdEquiposMoviles);

            entity.ToTable("CVT_INF_EquiposMoviles");

            entity.Property(e => e.IdEquiposMoviles).HasColumnName("Id_EquiposMoviles");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.IdMarca).HasColumnName("id_Marca");
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMEI");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Procesador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ram)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.So)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SO");
        });

        modelBuilder.Entity<CvtInfFormEntregaCelulare>(entity =>
        {
            entity.HasKey(e => e.IdFormEntregaCelulares);

            entity.ToTable("CVT_INF_FORM_EntregaCelulares");

            entity.Property(e => e.IdFormEntregaCelulares).HasColumnName("ID_FormEntregaCelulares");
            entity.Property(e => e.CableDatosUsb).HasColumnName("CableDatosUSB");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CreaCodTipoEquipoEntregaEquipos]([ID_FormEntregaCelulares]))", false);
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Entrega");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hasta");
            entity.Property(e => e.IdUsuarioAsignado)
                .HasMaxLength(50)
                .HasColumnName("idUsuarioAsignado");
            entity.Property(e => e.IdUsuarioRecibe).HasMaxLength(50);
            entity.Property(e => e.Nlinea).HasColumnName("NLinea");
            entity.Property(e => e.Otro).IsUnicode(false);
            entity.Property(e => e.TarjetaMicroSd).HasColumnName("TarjetaMicroSD");
            entity.Property(e => e.TarjetaSim).HasColumnName("TarjetaSIM");
            entity.Property(e => e.TipoDispo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vb).HasColumnName("VB");
        });

        modelBuilder.Entity<CvtInfImpresora>(entity =>
        {
            entity.ToTable("CVT_INF_Impresora");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Conectividad).HasMaxLength(255);
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.DireccionIp)
                .HasMaxLength(255)
                .HasColumnName("Direccion IP");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.SerieDimacofi)
                .IsUnicode(false)
                .HasColumnName("Serie_Dimacofi");
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(255)
                .HasColumnName("Tipo Contrato");
            entity.Property(e => e.TipoDispositivo)
                .HasMaxLength(255)
                .HasColumnName("Tipo Dispositivo");
            entity.Property(e => e.Tóner).HasMaxLength(255);
            entity.Property(e => e.UbicaciónUsuario)
                .HasMaxLength(255)
                .HasColumnName("Ubicación / Usuario");
            entity.Property(e => e.Usuario).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtInfLineasMovile>(entity =>
        {
            entity.HasKey(e => e.Nlinea);

            entity.ToTable("CVT_INF_LineasMoviles");

            entity.Property(e => e.Nlinea)
                .ValueGeneratedNever()
                .HasColumnName("NLinea");
            entity.Property(e => e.Asignado).HasMaxLength(50);
            entity.Property(e => e.CodPlan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Plan");
            entity.Property(e => e.FechaAdquisicion).HasColumnType("datetime");
            entity.Property(e => e.MarcaAsignadoMovistar).HasColumnName("Marca_AsignadoMovistar");
            entity.Property(e => e.MesesFaltCambio).HasComputedColumnSql("([dbo].[CVT_INF_MesesFaltantesCambioLineasMov]([NLinea]))", false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModeloAsignadoMovistar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Modelo_AsignadoMovistar");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SerieAsignadoMovistar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Serie_AsignadoMovistar");
            entity.Property(e => e.Sim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SIM");
        });

        modelBuilder.Entity<CvtInfMantencionDescripcion>(entity =>
        {
            entity.HasKey(e => e.IdMantencion).HasName("PK_CVT_INF_MANTENCION_DESCRIPCION");

            entity.ToTable("CVT_INF_Mantencion_Descripcion");

            entity.Property(e => e.IdMantencion).HasColumnName("ID_Mantencion");
            entity.Property(e => e.MantencionDescr).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfMantencionEncabezado>(entity =>
        {
            entity.HasKey(e => e.IdMantInfEnc).HasName("PK_CVT_INF_MantencionEncabezado");

            entity.ToTable("CVT_INF_Mantencion_Encabezado");

            entity.Property(e => e.IdMantInfEnc).HasColumnName("ID_MantInfEnc");
            entity.Property(e => e.Causa).IsUnicode(false);
            entity.Property(e => e.CodActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Falla).IsUnicode(false);
            entity.Property(e => e.FechaMantencion).HasColumnType("datetime");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Solucion).IsUnicode(false);
            entity.Property(e => e.TipoMantencion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfMantencionRepuesto>(entity =>
        {
            entity.HasKey(e => e.IdInfMantencionRepuestos);

            entity.ToTable("CVT_INF_Mantencion_Repuesto");

            entity.Property(e => e.IdInfMantencionRepuestos).HasColumnName("ID_InfMantencionRepuestos");
            entity.Property(e => e.IdMantInfEnc).HasColumnName("ID_MantInfEnc");
            entity.Property(e => e.Pieza).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfMantencionTipo>(entity =>
        {
            entity.HasKey(e => e.IdInfTipoMantencion);

            entity.ToTable("CVT_INF_Mantencion_Tipo");

            entity.Property(e => e.IdInfTipoMantencion).HasColumnName("Id_InfTipoMantencion");
            entity.Property(e => e.IdMantInfEnc).HasColumnName("ID_MantInfEnc");
            entity.Property(e => e.MantencionDet).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfMarca>(entity =>
        {
            entity.ToTable("CVT_INF_MARCA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MARCA");
        });

        modelBuilder.Entity<CvtInfMonitore>(entity =>
        {
            entity.HasKey(e => e.IdInvMonitores);

            entity.ToTable("CVT_INF_Monitores");

            entity.Property(e => e.IdInvMonitores).HasColumnName("Id_invMonitores");
            entity.Property(e => e.CodActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Conexion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(50)
                .HasColumnName("Id_Usuario");
            entity.Property(e => e.Modelo).IsUnicode(false);
            entity.Property(e => e.Pulgadas).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Resolucion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfOtroEq>(entity =>
        {
            entity.ToTable("CVT_INF_OtroEq");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BaseDatos)
                .HasMaxLength(255)
                .HasColumnName("Base Datos");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.ContraseñaBd)
                .HasMaxLength(255)
                .HasColumnName("Contraseña BD");
            entity.Property(e => e.DireccionIp)
                .HasMaxLength(255)
                .HasColumnName("Direccion IP");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.Proveedor).HasMaxLength(255);
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(255)
                .HasColumnName("Usuario BD");
        });

        modelBuilder.Entity<CvtInfPeriferico>(entity =>
        {
            entity.HasKey(e => e.IdPerisferico).HasName("PK_CVT_INF_Perisfericos");

            entity.ToTable("CVT_INF_Perifericos");

            entity.Property(e => e.Nombre).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfPlanesMovile>(entity =>
        {
            entity.HasKey(e => e.PlanCodigo);

            entity.ToTable("CVT_INF_PlanesMoviles");

            entity.Property(e => e.PlanCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Plan_Codigo");
            entity.Property(e => e.Gb).HasColumnName("GB");
            entity.Property(e => e.PlanNombre)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Plan_Nombre");
            entity.Property(e => e.Sms).HasColumnName("SMS");
        });

        modelBuilder.Entity<CvtInfRadioFrecuencium>(entity =>
        {
            entity.ToTable("CVT_INF_RadioFrecuencia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Cpu)
                .HasMaxLength(255)
                .HasColumnName("CPU");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.FlashSize)
                .HasMaxLength(255)
                .HasColumnName("Flash Size");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("IP");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("MAC");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.PartNumber)
                .HasMaxLength(255)
                .HasColumnName("Part Number");
            entity.Property(e => e.Ram)
                .HasMaxLength(255)
                .HasColumnName("RAM");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .HasColumnName("Serial Number");
            entity.Property(e => e.SistemaOperativo).HasColumnName("Sistema Operativo");
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.UsuarioDos).HasMaxLength(50);
        });

        modelBuilder.Entity<CvtInfServidor>(entity =>
        {
            entity.ToTable("CVT_INF_Servidor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.CodLicencia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DireccionIp)
                .HasMaxLength(255)
                .HasColumnName("Direccion IP");
            entity.Property(e => e.DireccionMac)
                .HasMaxLength(255)
                .HasColumnName("Direccion MAC");
            entity.Property(e => e.Disco).HasMaxLength(255);
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(255)
                .HasColumnName("Nombre Equipo");
            entity.Property(e => e.Procesador).HasMaxLength(255);
            entity.Property(e => e.Ram)
                .HasMaxLength(255)
                .HasColumnName("RAM");
            entity.Property(e => e.SistemaOperativo).HasColumnName("Sistema Operativo");
            entity.Property(e => e.TipoLicencia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfSistemaOperativo>(entity =>
        {
            entity.ToTable("CVT_INF_SistemaOperativo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SistemaOperativo).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfTelefoniaFija>(entity =>
        {
            entity.HasKey(e => e.IdTfija);

            entity.ToTable("CVT_INF_Telefonia_Fija");

            entity.Property(e => e.IdTfija).HasColumnName("ID_TFija");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.DireccionIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DireccionIP");
            entity.Property(e => e.DireccionMac)
                .IsUnicode(false)
                .HasColumnName("DireccionMAC");
            entity.Property(e => e.Dispositivo).IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oficina).IsUnicode(false);
            entity.Property(e => e.Otros)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario).IsUnicode(false);
            entity.Property(e => e.VlanId).HasColumnName("VlanID");
        });

        modelBuilder.Entity<CvtInfTipoDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdTipoDispositivo);

            entity.ToTable("CVT_INF_TipoDispositivo");

            entity.Property(e => e.IdTipoDispositivo).HasColumnName("Id_tipoDispositivo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfToner>(entity =>
        {
            entity.HasKey(e => e.IdToner);

            entity.ToTable("CVT_INF_Toner");

            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModeloCompatible).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInfVideoVigilancium>(entity =>
        {
            entity.ToTable("CVT_INF_VideoVigilancia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acceso).HasMaxLength(255);
            entity.Property(e => e.Almacenamiento).HasMaxLength(255);
            entity.Property(e => e.Codificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConectadaA)
                .HasMaxLength(255)
                .HasColumnName("Conectada  a");
            entity.Property(e => e.Contraseña).HasMaxLength(255);
            entity.Property(e => e.DirecciónMac)
                .HasMaxLength(255)
                .HasColumnName("Dirección MAC");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Firmware).HasMaxLength(255);
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.Monitoreo).HasMaxLength(255);
            entity.Property(e => e.Nvr)
                .HasMaxLength(255)
                .HasColumnName("NVR");
            entity.Property(e => e.Resolución).HasMaxLength(255);
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .HasColumnName("Tipo ");
            entity.Property(e => e.Usuario).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtInspeccionPtArroz>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtArroz);

            entity.ToTable("CVT_InspeccionPT_Arroz");

            entity.Property(e => e.IdInspeccionPtArroz).HasColumnName("Id_InspeccionPT_Arroz");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegisro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pmixto).HasColumnName("PMixto");
            entity.Property(e => e.ProvMixto).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtArrozDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleInspeccionPtArroz);

            entity.ToTable("CVT_InspeccionPT_ArrozDetalle");

            entity.Property(e => e.IdDetalleInspeccionPtArroz).HasColumnName("IdDetalleInspeccionPT_Arroz");
            entity.Property(e => e.Color).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosDanados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosYesados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtArroz).HasColumnName("Id_InspeccionPT_Arroz");
            entity.Property(e => e.Observacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtArveja>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtArveja);

            entity.ToTable("CVT_InspeccionPT_Arveja");

            entity.Property(e => e.IdInspeccionPtArveja).HasColumnName("Id_InspeccionPT_Arveja");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegisro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtArvejaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionArvejaDetalle);

            entity.ToTable("CVT_InspeccionPT_ArvejaDetalle");

            entity.Property(e => e.IdInspeccionArvejaDetalle).HasColumnName("Id_InspeccionArvejaDetalle");
            entity.Property(e => e.ContratePorColor).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosDanadosXinsectos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosEnteros).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtArveja).HasColumnName("Id_InspeccionPT_Arveja");
            entity.Property(e => e.Linea).HasColumnName("linea");
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtAzucar>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtAzucar);

            entity.ToTable("CVT_InspeccionPT_Azucar");

            entity.Property(e => e.IdInspeccionPtAzucar).HasColumnName("Id_InspeccionPT_Azucar");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtAzucarDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtAzucarDetalle);

            entity.ToTable("CVT_InspeccionPT_AzucarDetalle");

            entity.Property(e => e.IdInspeccionPtAzucarDetalle).HasColumnName("Id_InspeccionPT_AzucarDetalle");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtAzucar).HasColumnName("Id_InspeccionPT_Azucar");
            entity.Property(e => e.Observacion)
                .IsUnicode(false)
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<CvtInspeccionPtGarbanzo>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtGarbanzo);

            entity.ToTable("CVT_InspeccionPT_Garbanzo");

            entity.Property(e => e.IdInspeccionPtGarbanzo).HasColumnName("Id_InspeccionPT_Garbanzo");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtGarbanzoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionGarbanzoDetalle);

            entity.ToTable("CVT_InspeccionPT_GarbanzoDetalle");

            entity.Property(e => e.IdInspeccionGarbanzoDetalle).HasColumnName("Id_InspeccionGarbanzo_Detalle");
            entity.Property(e => e.GranosDanadosXinsectos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosVerdosos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtGarbanzo).HasColumnName("Id_InspeccionPT_Garbanzo");
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtLenteja>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtLenteja);

            entity.ToTable("CVT_InspeccionPT_Lenteja");

            entity.Property(e => e.IdInspeccionPtLenteja).HasColumnName("Id_InspeccionPT_Lenteja");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtLentejaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPtLentejaDetalle);

            entity.ToTable("CVT_InspeccionPT_LentejaDetalle");

            entity.Property(e => e.IdInspeccionPtLentejaDetalle).HasColumnName("Id_InspeccionPT_LentejaDetalle");
            entity.Property(e => e.GranosArrugados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosQuebrados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtLenteja).HasColumnName("Id_InspeccionPT_Lenteja");
            entity.Property(e => e.Impurezas).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MateriaExtranaAnimal).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtPoroto>(entity =>
        {
            entity.HasKey(e => e.IdIspeccionPtPoroto).HasName("PK_CVT_InspeccionPorotoHallado");

            entity.ToTable("CVT_InspeccionPT_Porotos");

            entity.Property(e => e.IdIspeccionPtPoroto).HasColumnName("Id_IspeccionPT_Poroto");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtPorotoNegro>(entity =>
        {
            entity.HasKey(e => e.IdIspeccionPtPorotoNegro).HasName("PK_CVT_InspeccionPorotoNegro");

            entity.ToTable("CVT_InspeccionPT_PorotoNegro");

            entity.Property(e => e.IdIspeccionPtPorotoNegro).HasColumnName("Id_IspeccionPT_PorotoNegro");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtPorotoNegroDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPorotoNegroDetalle);

            entity.ToTable("CVT_InspeccionPT_PorotoNegroDetalle");

            entity.Property(e => e.IdInspeccionPorotoNegroDetalle).HasColumnName("Id_InspeccionPorotoNegroDetalle");
            entity.Property(e => e.GanosDañadosXinsecto).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchado).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdIspeccionPtPorotoNegro).HasColumnName("Id_IspeccionPT_PorotoNegro");
            entity.Property(e => e.MateriaExtraña).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionPtPorotosDetalle>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionPorotoDetalle).HasName("PK_CVT_InspeccionPT_PorotoHalladoDetalle");

            entity.ToTable("CVT_InspeccionPT_PorotosDetalle");

            entity.Property(e => e.IdInspeccionPorotoDetalle).HasColumnName("Id_InspeccionPorotoDetalle");
            entity.Property(e => e.GanosDañadosXinsecto).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchado).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdIspeccionPtPoroto).HasColumnName("Id_IspeccionPT_Poroto");
            entity.Property(e => e.MateriaExtraña).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInspeccionVisualMalla>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionMalla);

            entity.ToTable("CVT_InspeccionVisualMalla");

            entity.Property(e => e.IdInspeccionMalla).HasColumnName("Id_InspeccionMalla");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.Medidas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("medidas");
        });

        modelBuilder.Entity<CvtInspeccionVisualSaco>(entity =>
        {
            entity.HasKey(e => e.IdInspeccionSacos);

            entity.ToTable("CVT_Inspeccion_Visual_Sacos");

            entity.Property(e => e.IdInspeccionSacos).HasColumnName("Id_InspeccionSacos");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.Humedad).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.IdEncargadaCalidad).HasColumnName("Id_EncargadaCalidad");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.LotePt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LotePT");
            entity.Property(e => e.NaccionCorrectiva).HasColumnName("NAccionCorrectiva");
            entity.Property(e => e.ProveedoresMixtos)
                .IsUnicode(false)
                .HasColumnName("Proveedores_Mixtos");
        });

        modelBuilder.Entity<CvtInventarioEstadoDet>(entity =>
        {
            entity.HasKey(e => e.InventarioEstadoDetId);

            entity.ToTable("CVT_InventarioEstadoDet");

            entity.Property(e => e.InventarioEstadoDetId).HasColumnName("InventarioEstadoDet_Id");
            entity.Property(e => e.Bodega)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.InventarioEstadoId).HasColumnName("InventarioEstado_Id");
            entity.Property(e => e.Sap).HasColumnName("SAP");
            entity.Property(e => e.Wms).HasColumnName("WMS");
        });

        modelBuilder.Entity<CvtInventarioEstadoProducto>(entity =>
        {
            entity.HasKey(e => new { e.InventarioId, e.CodProducto });

            entity.ToTable("CVT_InventarioEstadoProducto");

            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CantSap).HasColumnName("CantSAP");
            entity.Property(e => e.CantWms).HasColumnName("CantWMS");
            entity.Property(e => e.Contador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InventarioEstadoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InventarioEstado_Id");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtInventarioPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_InventarioPBI");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadPallet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Familia).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtLaboresArchivo>(entity =>
        {
            entity.HasKey(e => e.IdRutaArchivoLabores).HasName("PK_CVT_ArchivoLabores");

            entity.ToTable("CVT_LaboresArchivos");

            entity.Property(e => e.IdRutaArchivoLabores).HasColumnName("Id_RutaArchivoLabores");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdLaborTurno).HasColumnName("ID_LaborTurno");
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.RutaArchivo).IsUnicode(false);
        });

        modelBuilder.Entity<CvtLaboresExterna>(entity =>
        {
            entity.HasKey(e => e.IdLabores).HasName("PK_CVT_TarifasExternas");

            entity.ToTable("CVT_LaboresExternas");

            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdArea).HasColumnName("id_Area");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<CvtLaboresTurno>(entity =>
        {
            entity.HasKey(e => e.IdLaborTurno);

            entity.ToTable("CVT_LaboresTurno");

            entity.Property(e => e.IdLaborTurno).HasColumnName("ID_LaborTurno");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.PedidosPreparadosAp).HasColumnName("PedidosPreparadosAP");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtLaboresTurnoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdLabores).HasName("PK_CVT_Labores");

            entity.ToTable("CVT_LaboresTurnoDetalle");

            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdLaborTurno).HasColumnName("ID_LaborTurno");
        });

        modelBuilder.Entity<CvtLaboresTurnoRecepcione>(entity =>
        {
            entity.HasKey(e => e.IdDetalleRecepciones).HasName("PK_CVT_DetalleRecepciones");

            entity.ToTable("CVT_LaboresTurnoRecepciones");

            entity.Property(e => e.IdDetalleRecepciones).HasColumnName("Id_DetalleRecepciones");
            entity.Property(e => e.IdLaborTurno).HasColumnName("ID_LaborTurno");
            entity.Property(e => e.Nrecepcion).HasColumnName("NRecepcion");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.Productos).IsUnicode(false);
            entity.Property(e => e.Ubicacion).HasMaxLength(150);
        });

        modelBuilder.Entity<CvtLibroNovedade>(entity =>
        {
            entity.HasKey(e => e.NovedadId);

            entity.ToTable("CVT_LibroNovedades");

            entity.Property(e => e.NovedadId).HasColumnName("Novedad_Id");
            entity.Property(e => e.Actividad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_Id");
        });

        modelBuilder.Entity<CvtLineasProduccion>(entity =>
        {
            entity.HasKey(e => e.LineaId);

            entity.ToTable("CVT_LineasProduccion");

            entity.Property(e => e.NumeroLinea)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Numero_Linea");
        });

        modelBuilder.Entity<CvtListadoClientesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoClientesPBI");

            entity.Property(e => e.Canal).HasMaxLength(100);
            entity.Property(e => e.Codigo).HasMaxLength(15);
            entity.Property(e => e.Eerr)
                .HasMaxLength(40)
                .HasColumnName("EERR");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.GrupoVenta).HasMaxLength(40);
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Rut)
                .HasMaxLength(32)
                .HasColumnName("RUT");
            entity.Property(e => e.SubCanal).HasMaxLength(50);
            entity.Property(e => e.Vendedor).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtListadoCobranzaPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoCobranzaPBI");

            entity.Property(e => e.Abonos).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.CiudadPbi).HasMaxLength(104);
            entity.Property(e => e.CodProveedor).HasMaxLength(15);
            entity.Property(e => e.Comuna).HasMaxLength(100);
            entity.Property(e => e.ComunaPbi).HasMaxLength(104);
            entity.Property(e => e.CondicionPago).HasMaxLength(100);
            entity.Property(e => e.DocRelacionado).HasMaxLength(18);
            entity.Property(e => e.Empresa)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaCon).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.GrpEmpresa).HasMaxLength(40);
            entity.Property(e => e.GrupProveedor).HasMaxLength(100);
            entity.Property(e => e.GrupoVencimiento)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.GrupoVenta).HasMaxLength(40);
            entity.Property(e => e.LineaCredito).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.LineaCreditoPesos).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.LineaCreditoUf)
                .HasMaxLength(15)
                .HasColumnName("LineaCreditoUF");
            entity.Property(e => e.ListaNegra)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Moneda).HasMaxLength(3);
            entity.Property(e => e.Nota).HasColumnType("numeric(22, 4)");
            entity.Property(e => e.NumRegion)
                .HasMaxLength(3)
                .HasColumnName("Num_Region");
            entity.Property(e => e.Oc)
                .HasMaxLength(100)
                .HasColumnName("OC");
            entity.Property(e => e.Pendiente).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.SeguroFecha).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.Uf)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("UF");
            entity.Property(e => e.Vendedor).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtListadoDesechosporgrupopbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoDESECHOSPORGRUPOPBI");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Dia).HasColumnName("dia");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Producto).HasMaxLength(200);
        });

        modelBuilder.Entity<CvtListadoOfDetencion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_LISTADO_OF_DETENCION");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Producto).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtListadoProductosPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoProductosPBI");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Dun14)
                .HasMaxLength(254)
                .HasColumnName("DUN14");
            entity.Property(e => e.Ean13)
                .HasMaxLength(200)
                .HasColumnName("EAN13");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Marca).HasMaxLength(20);
            entity.Property(e => e.Peso)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("PESO");
            entity.Property(e => e.ProvPredet).HasMaxLength(100);
            entity.Property(e => e.UndxCaja)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("UNDxCaja");
        });

        modelBuilder.Entity<CvtListadoRegionesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoRegionesPBI");

            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Ncorto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NCorto");
            entity.Property(e => e.NombreRegion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre_Region");
            entity.Property(e => e.Nregion).HasColumnName("NRegion");
            entity.Property(e => e.TipoTransporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtListadoVendedoresPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_ListadoVendedoresPBI");

            entity.Property(e => e.Ncorto)
                .HasMaxLength(50)
                .HasColumnName("NCorto");
            entity.Property(e => e.Responsable).HasMaxLength(50);
            entity.Property(e => e.SlpName).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtListadoVentasPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_LIstadoVentasPBI");

            entity.Property(e => e.Canal).HasMaxLength(32);
            entity.Property(e => e.Cantidad).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.CodCliente).HasMaxLength(15);
            entity.Property(e => e.CodDireccion).HasMaxLength(50);
            entity.Property(e => e.CodigoArticulo).HasMaxLength(50);
            entity.Property(e => e.Comentario).HasMaxLength(50);
            entity.Property(e => e.CompConta).HasColumnName("Comp_Conta");
            entity.Property(e => e.Comuna).HasMaxLength(100);
            entity.Property(e => e.Costo).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.CostoTotal).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Direccion).HasMaxLength(254);
            entity.Property(e => e.EmbalajePorUm)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("EmbalajePorUM");
            entity.Property(e => e.EmpresaRelacionada).HasMaxLength(40);
            entity.Property(e => e.FCont)
                .HasColumnType("datetime")
                .HasColumnName("F_Cont");
            entity.Property(e => e.FVenc)
                .HasColumnType("datetime")
                .HasColumnName("F_Venc");
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.GrupoCliente).HasMaxLength(100);
            entity.Property(e => e.GrupoVenta).HasMaxLength(40);
            entity.Property(e => e.Indicador).HasMaxLength(50);
            entity.Property(e => e.Marca).HasMaxLength(20);
            entity.Property(e => e.MargeRc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MargeRC");
            entity.Property(e => e.MargenBruto).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.MargenReal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.NotaBruta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotaRc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NotaRC");
            entity.Property(e => e.NotaReal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NumDocRef)
                .HasMaxLength(18)
                .HasColumnName("NumDocREF");
            entity.Property(e => e.NumInterno).HasColumnName("Num_Interno");
            entity.Property(e => e.NumRegion)
                .HasMaxLength(3)
                .HasColumnName("Num_Region");
            entity.Property(e => e.PcrComision)
                .HasColumnType("decimal(22, 6)")
                .HasColumnName("Pcr_Comision");
            entity.Property(e => e.PesoTotal).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.PrcRAcuerdo)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Acuerdo");
            entity.Property(e => e.PrcRCentra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Centra");
            entity.Property(e => e.PrcRDaymon)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Daymon");
            entity.Property(e => e.PrcRFcrappel)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_FCRappel");
            entity.Property(e => e.PrcRLogAuto)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_LogAuto");
            entity.Property(e => e.PrcRMermaCero)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_MermaCero");
            entity.Property(e => e.PrcRPlataforma)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_Plataforma");
            entity.Property(e => e.PrcRRepoInt)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PrcR_RepoInt");
            entity.Property(e => e.PrcRapel)
                .HasColumnType("decimal(25, 6)")
                .HasColumnName("Prc_Rapel");
            entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Tipo)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoComision)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocRef).HasMaxLength(100);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoMarca)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TotalComision).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalLinea).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.TotalRAcuerdo)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Acuerdo");
            entity.Property(e => e.TotalRCentra)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Centra");
            entity.Property(e => e.TotalRDaymon)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Daymon");
            entity.Property(e => e.TotalRFcrappel)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_FCRappel");
            entity.Property(e => e.TotalRLogAuto)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_LogAuto");
            entity.Property(e => e.TotalRMermaCero)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_MermaCero");
            entity.Property(e => e.TotalRPlataforma)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_Plataforma");
            entity.Property(e => e.TotalRRepoInt)
                .HasColumnType("numeric(38, 10)")
                .HasColumnName("TotalR_RepoInt");
            entity.Property(e => e.TotalRapel).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalSinRapel)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Total_SinRapel");
            entity.Property(e => e.Transporte).HasMaxLength(50);
            entity.Property(e => e.UmEmbalaje)
                .HasMaxLength(30)
                .HasColumnName("Um_Embalaje");
            entity.Property(e => e.UmVendida)
                .HasMaxLength(100)
                .HasColumnName("UM_Vendida");
            entity.Property(e => e.UnidadesVendidas).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.UtilidadBruta).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.UtilidadRc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("UtilidadRC");
            entity.Property(e => e.UtilidadRealCt)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("UtilidadRealCT");
            entity.Property(e => e.ValorProductoTransporte).HasColumnType("numeric(38, 14)");
            entity.Property(e => e.Vendedor).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtLogErrorInforme>(entity =>
        {
            entity.HasKey(e => e.IdError);

            entity.ToTable("CVT_LogErrorInformes");

            entity.Property(e => e.IdError).ValueGeneratedNever();
            entity.Property(e => e.DescripcionErr).IsUnicode(false);
            entity.Property(e => e.FechaError).HasColumnType("datetime");
            entity.Property(e => e.TipoInforme).IsUnicode(false);
        });

        modelBuilder.Entity<CvtLogPrecioEntrega>(entity =>
        {
            entity.HasKey(e => e.IdError);

            entity.ToTable("CVT_LogPrecioEntrega");

            entity.Property(e => e.IdError).HasColumnName("idError");
            entity.Property(e => e.DescError).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Modulo).IsUnicode(false);
        });

        modelBuilder.Entity<CvtLogRegistroPrecioEntrega>(entity =>
        {
            entity.HasKey(e => new { e.DocEntryEntrada, e.FechaEjecucion });

            entity.ToTable("CVT_LOG_RegistroPrecioEntrega");

            entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");
            entity.Property(e => e.DifCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DifCambioAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.PesoEntrada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PesoOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PesoOC");
            entity.Property(e => e.ValorDolarHoy).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorDolarOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorDolarOC");
            entity.Property(e => e.ValorOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorOC");
            entity.Property(e => e.ValorOchoy)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorOCHoy");
        });

        modelBuilder.Entity<CvtLogSistema>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("CVT_LogSistema");

            entity.Property(e => e.LogId).HasColumnName("Log_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtLogUtilidade>(entity =>
        {
            entity.HasKey(e => e.IdLogUtilidad);

            entity.ToTable("CVT_LogUtilidades");

            entity.Property(e => e.IdLogUtilidad).HasColumnName("id_LogUtilidad");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Ntransaccion).HasColumnName("NTransaccion");
            entity.Property(e => e.TipoTransac)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtLogtrx>(entity =>
        {
            entity.HasKey(e => e.Idtrx)
                .HasName("CVT_LOGTrx_PK")
                .IsClustered(false);

            entity.ToTable("CVT_LOGTrx");

            entity.HasIndex(e => new { e.Tabla, e.Columna }, "Tabla_Columna");

            entity.Property(e => e.Idtrx).HasColumnName("IDTrx");
            entity.Property(e => e.Columna)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IdAccion).HasDefaultValue((short)1);
            entity.Property(e => e.IdDirIp)
                .HasMaxLength(100)
                .HasDefaultValue(" ")
                .HasColumnName("IdDirIP");
            entity.Property(e => e.IdNombrePc)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.IdUserPc)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Tabla)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.ValorNuevo)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.ValorPrevio)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtLotesBloqueadosSap>(entity =>
        {
            entity.HasKey(e => e.Llave);

            entity.ToTable("CVT_LotesBloqueadosSap");

            entity.Property(e => e.Llave)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.BatchNum)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtLotesDefinidosPorTrx>(entity =>
        {
            entity.HasKey(e => e.IdDefinicion)
                .HasName("CVT_LotesPorTrx_PK")
                .IsClustered(false);

            entity.ToTable("CVT_LotesDefinidosPorTrx");

            entity.Property(e => e.CodigoLote)
                .HasMaxLength(50)
                .HasDefaultValue(" ");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasDefaultValue(" ");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtMailingInforme>(entity =>
        {
            entity.HasKey(e => e.DistribucionId);

            entity.ToTable("CVT_MailingInformes");

            entity.Property(e => e.DistribucionId).HasColumnName("Distribucion_Id");
            entity.Property(e => e.Informe)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtMaquinaComponente>(entity =>
        {
            entity.ToTable("CVT_MaquinaComponente");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descricion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PadreId).HasColumnName("Padre_ID");
        });

        modelBuilder.Entity<CvtMenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.ToTable("CVT_Menu");

            entity.Property(e => e.NombreMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Menu");
        });

        modelBuilder.Entity<CvtMenuXamarin>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.ToTable("CVT_MenuXamarin");

            entity.Property(e => e.IdMenu).HasColumnName("Id_Menu");
            entity.Property(e => e.TituloMenu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtMenusXperfil>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_MenusXPerfil");

            entity.Property(e => e.NombreMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Menu");
            entity.Property(e => e.NombrePerfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Perfil");
            entity.Property(e => e.NombreSubMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_SubMenu");
            entity.Property(e => e.UrlSubMenu)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_SubMenu");
        });

        modelBuilder.Entity<CvtMezclaProductoUbicacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_MezclaProductoUbicacion");

            entity.Property(e => e.CantPorductos).HasColumnName("Cant_Porductos");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<CvtMonitoreoDetectorMetalesDo>(entity =>
        {
            entity.HasKey(e => e.IdMonitoreoMetalesDos);

            entity.ToTable("CVT_MonitoreoDetectorMetalesDos");

            entity.Property(e => e.IdMonitoreoMetalesDos).HasColumnName("Id_monitoreoMetalesDos");
            entity.Property(e => e.DetectaFe25mm).HasColumnName("DetectaFE25mm");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.HoraMonitoreo).HasPrecision(2);
            entity.Property(e => e.IdEncargadaCalidad).HasColumnName("Id_EncargadaCalidad");
            entity.Property(e => e.NoFe30mm).HasColumnName("NoFE30mm");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtMonitoreoDetectorMetalesUno>(entity =>
        {
            entity.HasKey(e => e.IdMonitoreoMetales);

            entity.ToTable("CVT_MonitoreoDetectorMetalesUno");

            entity.Property(e => e.IdMonitoreoMetales).HasColumnName("Id_MonitoreoMetales");
            entity.Property(e => e.BrazoDeRechazo).HasColumnName("Brazo de rechazo");
            entity.Property(e => e.Fe15mm).HasColumnName("FE15mm");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaMonitoreo).HasColumnType("datetime");
            entity.Property(e => e.HoraMonitoreo).HasPrecision(2);
            entity.Property(e => e.IdEncargadaCalidad).HasColumnName("Id_EncargadaCalidad");
            entity.Property(e => e.NoFe25mm).HasColumnName("NoFE25mm");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtMotivoDentecion>(entity =>
        {
            entity.HasKey(e => e.MotivoCod);

            entity.ToTable("CVT_MotivoDentecion");

            entity.Property(e => e.MotivoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Motivo_Cod");
            entity.Property(e => e.CategoriaId).HasColumnName("Categoria_Id");
            entity.Property(e => e.DetencionMotivo)
                .IsUnicode(false)
                .HasColumnName("Detencion_Motivo");
        });

        modelBuilder.Entity<CvtMotivoDevolucion>(entity =>
        {
            entity.HasKey(e => e.IdMotivoDevolucion);

            entity.ToTable("CVT_MotivoDevolucion");

            entity.Property(e => e.IdMotivoDevolucion).HasColumnName("Id_MotivoDevolucion");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtMovimientoMantencion>(entity =>
        {
            entity.HasKey(e => e.MovimientoId);

            entity.ToTable("CVT_MovimientoMantencion");

            entity.Property(e => e.MovimientoId).HasColumnName("Movimiento_Id");
            entity.Property(e => e.AreaId).HasColumnName("Area_Id");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.LugarUtilizacion).IsUnicode(false);
            entity.Property(e => e.ObjetoId).HasColumnName("Objeto_Id");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtNoConformidade>(entity =>
        {
            entity.HasKey(e => e.IdNoConformidad);

            entity.ToTable("CVT_NoConformidades");

            entity.Property(e => e.IdNoConformidad).HasColumnName("Id_NoConformidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaMod)
                .HasColumnType("datetime")
                .HasColumnName("fechaUltimaMod");
            entity.Property(e => e.IdAreaNoConformidad).HasColumnName("id_AreaNoConformidad");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioultimaMod)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtNotaMargen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_NotaMargen");

            entity.Property(e => e.Cnota).HasColumnName("CNota");
            entity.Property(e => e.Nota).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CvtNotificacione>(entity =>
        {
            entity.HasKey(e => e.NotificacionId).HasName("PK_Notificaciones");

            entity.ToTable("CVT_Notificaciones");

            entity.Property(e => e.NotificacionId).HasColumnName("Notificacion_Id");
            entity.Property(e => e.NotificacionNombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Notificacion_Nombre");
        });

        modelBuilder.Entity<CvtNotificacionesUsuario>(entity =>
        {
            entity.HasKey(e => new { e.UsuarioId, e.NotificacionId });

            entity.ToTable("CVT_NotificacionesUsuario");

            entity.Property(e => e.UsuarioId).HasColumnName("Usuario_Id");
            entity.Property(e => e.NotificacionId).HasColumnName("Notificacion_Id");
        });

        modelBuilder.Entity<CvtObjeto>(entity =>
        {
            entity.HasKey(e => e.ObjetoId);

            entity.ToTable("CVT_Objeto");

            entity.Property(e => e.ObjetoId).HasColumnName("Objeto_Id");
            entity.Property(e => e.ObjetoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Objeto_Nombre");
        });

        modelBuilder.Entity<CvtOcabiertasEerr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_OCAbiertas_EERR");

            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.Empresa)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SlpName).HasMaxLength(155);
        });

        modelBuilder.Entity<CvtOrdenDeVenta>(entity =>
        {
            entity.HasKey(e => e.IdOrdenVentas);

            entity.ToTable("CVT_Orden_de_Ventas");

            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DirDespacho)
                .IsUnicode(false)
                .HasColumnName("Dir_Despacho");
            entity.Property(e => e.DirFacturacion)
                .IsUnicode(false)
                .HasColumnName("Dir_Facturacion");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtOrderAsignacion>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.Itemcode, e.Lote });

            entity.ToTable("CVT_OrderAsignacion");

            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtParamReporteTrazabilidad>(entity =>
        {
            entity.HasKey(e => new { e.IdReporte, e.DetIdReporte })
                .HasName("CVT_ParamRptTraza_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ParamReporteTrazabilidad");

            entity.Property(e => e.NombreParam)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtParametrosproduccion>(entity =>
        {
            entity.HasKey(e => e.ParametroId);

            entity.ToTable("CVT_PARAMETROSPRODUCCION");

            entity.Property(e => e.ParametroId).HasColumnName("PARAMETRO_ID");
            entity.Property(e => e.GolpesHora)
                .HasComputedColumnSql("([GOLPES_MINUTO]*(60))", false)
                .HasColumnName("GOLPES_HORA");
            entity.Property(e => e.GolpesJornada)
                .HasComputedColumnSql("(([GOLPES_MINUTO]*(60))*[HORAS_JORNADA])", false)
                .HasColumnName("GOLPES_JORNADA");
            entity.Property(e => e.GolpesMinuto).HasColumnName("GOLPES_MINUTO");
            entity.Property(e => e.HorasJornada).HasColumnName("HORAS_JORNADA");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEMCODE");
            entity.Property(e => e.MetaTotal)
                .HasComputedColumnSql("(((([GOLPES_MINUTO]*(60))*[HORAS_JORNADA])*((100)-[PORC_DETENCIONACEPTADA]))/(100))", false)
                .HasColumnName("META_TOTAL");
            entity.Property(e => e.PorcDetencionaceptada).HasColumnName("PORC_DETENCIONACEPTADA");
            entity.Property(e => e.Sala).HasColumnName("SALA");
        });

        modelBuilder.Entity<CvtPeonetaControlAcceso>(entity =>
        {
            entity.HasKey(e => e.PeonetaId).HasName("PK_PeonetaControlAcceso");

            entity.ToTable("CVT_PeonetaControlAcceso");

            entity.Property(e => e.PeonetaId).HasColumnName("Peoneta_Id");
            entity.Property(e => e.ControlAccesoId).HasColumnName("ControlAcceso_Id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RUN");
        });

        modelBuilder.Entity<CvtPerfilUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPerfil);

            entity.ToTable("CVT_PerfilUsuario");

            entity.Property(e => e.NombrePerfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Perfil");
        });

        modelBuilder.Entity<CvtPeriodo>(entity =>
        {
            entity.HasKey(e => new { e.CodPeriodo, e.AnoPeriodo })
                .HasName("CVT_Periodos_PK")
                .IsClustered(false);

            entity.ToTable("CVT_Periodos");

            entity.Property(e => e.CodPeriodo)
                .HasMaxLength(6)
                .HasDefaultValue("");
            entity.Property(e => e.DescPeriodo)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtPermisoTrabajoSeguro>(entity =>
        {
            entity.HasKey(e => e.IdPts);

            entity.ToTable("CVT_PermisoTrabajoSeguro");

            entity.Property(e => e.IdPts)
                .ValueGeneratedNever()
                .HasColumnName("Id_Pts");
            entity.Property(e => e.AreaTrabajo).IsUnicode(false);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.DiasDuracion).HasComputedColumnSql("([dbo].[Dias_PTS]([Id_Pts]))", false);
            entity.Property(e => e.Empresa).IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.IdUsuarioRegistra).HasColumnName("ID_UsuarioRegistra");
            entity.Property(e => e.Responsable).IsUnicode(false);
            entity.Property(e => e.Tarea).IsUnicode(false);
            entity.Property(e => e.TipoTrabajo).IsUnicode(false);
            entity.Property(e => e.TotalAst).HasColumnName("TotalAST");
        });

        modelBuilder.Entity<CvtPermisoTrabajoSeguroAst>(entity =>
        {
            entity.HasKey(e => e.IdAst);

            entity.ToTable("CVT_PermisoTrabajoSeguro_AST", tb => tb.HasTrigger("TotalAST"));

            entity.Property(e => e.IdAst).HasColumnName("Id_Ast");
            entity.Property(e => e.Astorder).HasColumnName("ASTOrder");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.IdPts).HasColumnName("Id_Pts");
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.UrlAst).IsUnicode(false);
        });

        modelBuilder.Entity<CvtPermisoTrabajoSeguroPt>(entity =>
        {
            entity.HasKey(e => e.IdArchivo);

            entity.ToTable("CVT_PermisoTrabajoSeguro_PTS");

            entity.Property(e => e.IdArchivo).HasColumnName("ID_Archivo");
            entity.Property(e => e.Extencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPts).HasColumnName("Id_Pts");
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtPermisosSistInterno>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.IdUsuario, e.Funcion })
                .HasName("CVT_PermisosSistInternos_PK")
                .IsClustered(false);

            entity.ToTable("CVT_PermisosSistInternos");

            entity.Property(e => e.Funcion)
                .HasMaxLength(40)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtPersonal>(entity =>
        {
            entity.HasKey(e => e.IdPersonal).HasName("PK_Personal");

            entity.ToTable("CVT_Personal");

            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Monitor).HasColumnName("monitor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtPlanMantencionEncabezado>(entity =>
        {
            entity.HasKey(e => e.IdPlanMantencion).HasName("PK_CVT_AgendaMantencion_Encabezado");

            entity.ToTable("CVT_PlanMantencion_Encabezado");

            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
            entity.Property(e => e.Alarma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Asunto).IsUnicode(false);
            entity.Property(e => e.CantHoras).HasColumnName("Cant_Horas");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaLimite)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Limite");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Termino");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtPlanMantencionHerramientum>(entity =>
        {
            entity.HasKey(e => e.IdHerramientaPlanMantencion);

            entity.ToTable("CVT_PlanMantencion_Herramienta");

            entity.Property(e => e.IdHerramientaPlanMantencion).HasColumnName("id_HerramientaPlanMantencion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
        });

        modelBuilder.Entity<CvtPlanMantencionMaquina>(entity =>
        {
            entity.HasKey(e => e.IdMaquinaPlanMantencion).HasName("PK_CVT_AgendaMantencion_Maquina");

            entity.ToTable("CVT_PlanMantencion_Maquina");

            entity.Property(e => e.IdMaquinaPlanMantencion).HasColumnName("id_Maquina_PlanMantencion");
            entity.Property(e => e.CodMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
        });

        modelBuilder.Entity<CvtPlanMantencionParte>(entity =>
        {
            entity.HasKey(e => e.IdPartePlanMantencion);

            entity.ToTable("CVT_PlanMantencion_Parte");

            entity.Property(e => e.IdPartePlanMantencion).HasColumnName("id_PartePlanMantencion");
            entity.Property(e => e.CodParte)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
        });

        modelBuilder.Entity<CvtPlanMantencionPieza>(entity =>
        {
            entity.HasKey(e => e.IdPiezaPlanMantencion);

            entity.ToTable("CVT_PlanMantencion_Pieza");

            entity.Property(e => e.IdPiezaPlanMantencion).HasColumnName("id_Pieza_PlanMantencion");
            entity.Property(e => e.CodPieza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
        });

        modelBuilder.Entity<CvtPlanMantencionRepuesto>(entity =>
        {
            entity.HasKey(e => e.IdRepuestoPlanMantencion);

            entity.ToTable("CVT_PlanMantencion_Repuesto");

            entity.Property(e => e.IdRepuestoPlanMantencion).HasColumnName("Id_RepuestoPlanMantencion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
        });

        modelBuilder.Entity<CvtPlanMantencionRrhh>(entity =>
        {
            entity.HasKey(e => e.IdRhhplanMantencion);

            entity.ToTable("CVT_PlanMantencion_RRHH");

            entity.Property(e => e.IdRhhplanMantencion).HasColumnName("id_RHHPlanMantencion");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlanMantencion).HasColumnName("Id_PlanMantencion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Run).HasMaxLength(50);
        });

        modelBuilder.Entity<CvtPlanificacionMantencion>(entity =>
        {
            entity.HasKey(e => e.MantencionId);

            entity.ToTable("CVT_PlanificacionMantencion");

            entity.Property(e => e.MantencionId).HasColumnName("Mantencion_Id");
            entity.Property(e => e.ComponenteId).HasColumnName("Componente_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Termino");
            entity.Property(e => e.MaquinaId).HasColumnName("Maquina_Id");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.ParteId).HasColumnName("Parte_Id");
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecursoId).HasColumnName("Recurso_Id");
            entity.Property(e => e.TipoMantencionId).HasColumnName("Tipo_Mantencion_Id");
        });

        modelBuilder.Entity<CvtPlanillaInsumo>(entity =>
        {
            entity.HasKey(e => e.PinsumosId);

            entity.ToTable("CVT_Planilla_Insumos");

            entity.Property(e => e.PinsumosId).HasColumnName("PInsumos_Id");
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.UsuarioSistema).HasColumnName("Usuario_Sistema");
        });

        modelBuilder.Entity<CvtPlanillaInsumosDetalle>(entity =>
        {
            entity.HasKey(e => e.PiDetalleId).HasName("PK_insumo");

            entity.ToTable("CVT_PlanillaInsumos_Detalle");

            entity.Property(e => e.PiDetalleId).HasColumnName("PI_Detalle_Id");
            entity.Property(e => e.CodArticulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Articulo");
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Proveedor");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PinsumosId).HasColumnName("PInsumos_Id");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtPorcentajeRapel>(entity =>
        {
            entity.HasKey(e => new { e.CardCode, e.Address, e.ItemCode, e.FechaInicio });

            entity.ToTable("CVT_Porcentaje_Rapel");

            entity.Property(e => e.CardCode).HasMaxLength(15);
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Centralizacion).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CobroFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DistribCentMmpp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Distrib_Cent_MMPP");
            entity.Property(e => e.DistribCentRestSurtido)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Distrib_Cent_Rest_Surtido");
            entity.Property(e => e.ExtranetRestSurtido)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Extranet_Rest_Surtido");
            entity.Property(e => e.FamiliaProducto)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_CodigoFamiliaProducto]([ItemCode]))", false);
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.LaColiseoCm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LA_Coliseo_CM");
            entity.Property(e => e.LaColiseoW)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LA_Coliseo_W");
            entity.Property(e => e.LaMmppW)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LA_MMPP_W");
            entity.Property(e => e.Merma).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NoDevolucion).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PastaColiseo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pel)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PEL");
            entity.Property(e => e.RebateFijo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Rebate_Fijo");
            entity.Property(e => e.ReposicionIntSellOut)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reposicion_Int_SellOut");
            entity.Property(e => e.TotalRapel)
                .HasComputedColumnSql("(((((((((((((isnull([PastaColiseo],(0))+isnull([LA_Coliseo_CM],(0)))+isnull([LA_Coliseo_W],(0)))+isnull([LA_MMPP_W],(0)))+isnull([Centralizacion],(0)))+isnull([Merma],(0)))+isnull([Distrib_Cent_MMPP],(0)))+isnull([Distrib_Cent_Rest_Surtido],(0)))+isnull([Extranet_Rest_Surtido],(0)))+isnull([Rebate_Fijo],(0)))+isnull([Reposicion_Int_SellOut],(0)))+isnull([NoDevolucion],(0)))+isnull([PEL],(0)))+isnull([CobroFianza],(0)))", false)
                .HasColumnType("decimal(31, 4)");
        });

        modelBuilder.Entity<CvtPosicionesConExcesoBulto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_PosicionesConExcesoBultos");

            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_id");
            entity.Property(e => e.PalletPermitidos).HasColumnName("Pallet_Permitidos");
            entity.Property(e => e.PalletUbicados).HasColumnName("Pallet_Ubicados");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<CvtPreRecepcion>(entity =>
        {
            entity.HasKey(e => new { e.Oc, e.CodProducto, e.Fproduccion, e.LoteProveedor, e.Ncontenedor });

            entity.ToTable("CVT_PreRecepcion");

            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fproduccion)
                .HasColumnType("datetime")
                .HasColumnName("FProduccion");
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Lote_Proveedor");
            entity.Property(e => e.Ncontenedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NContenedor");
            entity.Property(e => e.CantPallets)
                .HasComputedColumnSql("([dbo].[CalculaCantidadPalletOC]([PreRecepcion_Id]))", false)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("Cant_Pallets");
            entity.Property(e => e.Eta).HasColumnName("ETA");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.Fvencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FVencimiento");
            entity.Property(e => e.PreRecepcionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PreRecepcion_Id");
            entity.Property(e => e.Tcontenedor).HasColumnName("TContenedor");
        });

        modelBuilder.Entity<CvtPreguntaEncuestum>(entity =>
        {
            entity.HasKey(e => e.IdPregunta);

            entity.ToTable("CVT_PreguntaEncuesta");

            entity.Property(e => e.IdPregunta).HasColumnName("Id_Pregunta");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdAspectoPregunta).HasColumnName("Id_AspectoPregunta");
            entity.Property(e => e.Pregunta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtPreparaPedidoBodega>(entity =>
        {
            entity.HasKey(e => new { e.NumPedidoSap, e.CodProducto })
                .HasName("CVT_PrepPedBod_PK")
                .IsClustered(false);

            entity.ToTable("CVT_PreparaPedidoBodega");

            entity.Property(e => e.NumPedidoSap).HasColumnName("NumPedidoSAP");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.CantPalCompleto)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Cant_PalCompleto");
            entity.Property(e => e.CantPicadillo)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Cant_Picadillo");
            entity.Property(e => e.CantSaldoInicio)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Cant_SaldoInicio");
            entity.Property(e => e.CantSaldoxMerma)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("Cant_SaldoxMerma");
            entity.Property(e => e.CantidadPedido).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Cliente)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.DescProducto)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.FechaDesp)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.NumPedidoWms).HasColumnName("NumPedidoWMS");
        });

        modelBuilder.Entity<CvtPresupuestoCanalVenta>(entity =>
        {
            entity.ToTable("CVT_Presupuesto_CanalVentas");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.CodVendedor).HasColumnName("Cod_Vendedor");
        });

        modelBuilder.Entity<CvtPresupuestoCliente>(entity =>
        {
            entity.ToTable("CVT_Presupuesto_Clientes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Cliente");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.CodVendedor).HasColumnName("Cod_Vendedor");
        });

        modelBuilder.Entity<CvtPresupuestoDetalle>(entity =>
        {
            entity.HasKey(e => e.PresupuestoDetalleId);

            entity.ToTable("CVT_PresupuestoDetalle");

            entity.Property(e => e.PresupuestoDetalleId).HasColumnName("PresupuestoDetalle_ID");
            entity.Property(e => e.AbrilPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(4)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AbrilPA");
            entity.Property(e => e.AgostoPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(8)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AgostoPA");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DiciembrePa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(12)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DiciembrePA");
            entity.Property(e => e.EneroPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(1)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EneroPA");
            entity.Property(e => e.FebreroPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(2)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FebreroPA");
            entity.Property(e => e.ItemName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JulioPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(7)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JulioPA");
            entity.Property(e => e.JunioPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(6)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JunioPA");
            entity.Property(e => e.MarzoPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(3)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MarzoPA");
            entity.Property(e => e.MayoPa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(5)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MayoPA");
            entity.Property(e => e.NoviembrePa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(11)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NoviembrePA");
            entity.Property(e => e.OctubrePa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(10)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OctubrePA");
            entity.Property(e => e.PresupuestoId).HasColumnName("Presupuesto_ID");
            entity.Property(e => e.SeptiembrePa)
                .HasComputedColumnSql("([dbo].[CalculoVentasPeriodoAnterior]([Presupuesto_ID],[Itemcode],[CardCode],(9)))", false)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SeptiembrePA");
        });

        modelBuilder.Entity<CvtPresupuestoInformeVendedorAño>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_PresupuestoInformeVendedorAño");

            entity.Property(e => e.AbrilPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AbrilPA");
            entity.Property(e => e.AgostoPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AgostoPA");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DiciembrePa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DiciembrePA");
            entity.Property(e => e.EneroPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EneroPA");
            entity.Property(e => e.FebreroPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FebreroPA");
            entity.Property(e => e.ItemName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JulioPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JulioPA");
            entity.Property(e => e.JunioPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JunioPA");
            entity.Property(e => e.MarzoPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MarzoPA");
            entity.Property(e => e.MayoPa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MayoPA");
            entity.Property(e => e.NoviembrePa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NoviembrePA");
            entity.Property(e => e.OctubrePa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OctubrePA");
            entity.Property(e => e.PresupuestoId).HasColumnName("Presupuesto_ID");
            entity.Property(e => e.SeptiembrePa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SeptiembrePA");
            entity.Property(e => e.TipoPresupuesto)
                .HasMaxLength(17)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtPresupuestoVendedor>(entity =>
        {
            entity.HasKey(e => e.PresupuestoId);

            entity.ToTable("CVT_PresupuestoVendedor");

            entity.Property(e => e.PresupuestoId).HasColumnName("Presupuesto_Id");
        });

        modelBuilder.Entity<CvtPresupuestoVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_Presupuesto_Ventas");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Clp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CLP");
            entity.Property(e => e.ClpSrapel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CLP_SRapel");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcRapel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Porc_Rapel");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Venta");
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vendedor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtPrivilegioPerfil>(entity =>
        {
            entity.HasKey(e => new { e.IdPerfil, e.IdSubMenu });

            entity.ToTable("CVT_PrivilegioPerfil");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.CvtPrivilegioPerfils)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CVT_PrivilegioPerfil_CVT_PerfilUsuario");

            entity.HasOne(d => d.IdSubMenuNavigation).WithMany(p => p.CvtPrivilegioPerfils)
                .HasForeignKey(d => d.IdSubMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CVT_PrivilegioPerfil_CVT_SubMenu");
        });

        modelBuilder.Entity<CvtPrivilegiosPerfilXamarin>(entity =>
        {
            entity.HasKey(e => new { e.IdPerfil, e.IdMenuXam });

            entity.ToTable("CVT_PrivilegiosPerfilXamarin");

            entity.Property(e => e.IdPerfil).HasColumnName("idPerfil");
            entity.Property(e => e.IdMenuXam).HasColumnName("idMenuXam");
        });

        modelBuilder.Entity<CvtProcesoAdicional>(entity =>
        {
            entity.HasKey(e => e.ProcesoAdicionalId);

            entity.ToTable("CVT_ProcesoAdicional");

            entity.Property(e => e.ProcesoAdicionalId).HasColumnName("ProcesoAdicional_Id");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicioAdicionalId).HasColumnName("TipoServicioAdicional_Id");
            entity.Property(e => e.TransferenciaId).HasColumnName("Transferencia_Id");
        });

        modelBuilder.Entity<CvtProcesoAdicionalDetalle>(entity =>
        {
            entity.HasKey(e => e.DetalleProcesoId);

            entity.ToTable("CVT_ProcesoAdicionalDetalle");

            entity.Property(e => e.DetalleProcesoId).HasColumnName("DetalleProceso_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.ProcesoAdicionalId).HasColumnName("ProcesoAdicional_Id");
        });

        modelBuilder.Entity<CvtProdPorcRapel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_PROD_PORC_RAPEL");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtProductoBloqueado>(entity =>
        {
            entity.HasKey(e => e.IdProdBloqueado);

            entity.ToTable("CVT_Producto_Bloqueado");

            entity.Property(e => e.IdProdBloqueado).HasColumnName("Id_ProdBloqueado");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaTerminoBloqueo).HasColumnType("datetime");
            entity.Property(e => e.IdTipoBloqueo).HasColumnName("Id_TipoBloqueo");
            entity.Property(e => e.Observacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtProductoBloqueadoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdProdBloqDetalle);

            entity.ToTable("CVT_Producto_Bloqueado_Detalle");

            entity.Property(e => e.IdProdBloqDetalle).HasColumnName("Id_ProdBloqDetalle");
            entity.Property(e => e.FechaBloqueo).HasColumnType("datetime");
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.IdPackage).HasColumnName("Id_package");
            entity.Property(e => e.IdProdBloqueado).HasColumnName("Id_ProdBloqueado");
            entity.Property(e => e.IdUsuarioBloqueo).HasColumnName("ID_UsuarioBloqueo");
            entity.Property(e => e.IdUsuarioLiberacion).HasColumnName("ID_UsuarioLiberacion");
        });

        modelBuilder.Entity<CvtProductoTipoBloqueo>(entity =>
        {
            entity.HasKey(e => e.IdTipoBloqueo);

            entity.ToTable("CVT_Producto_TipoBloqueo");

            entity.Property(e => e.IdTipoBloqueo).HasColumnName("Id_TipoBloqueo");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRechazosDetertorMetale>(entity =>
        {
            entity.ToTable("CVT_RechazosDetertorMetales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AccionCorrectiva)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Elemento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtReclamo>(entity =>
        {
            entity.HasKey(e => e.IdReclamo);

            entity.ToTable("CVT_Reclamo");

            entity.Property(e => e.IdReclamo).HasColumnName("Id_Reclamo");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.FechaEnvasado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegReclamo).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.IdUserRegReclamo).HasColumnName("ID_UserRegReclamo");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionEstado).IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtReclamoArchivo>(entity =>
        {
            entity.HasKey(e => e.IdRutaArchivoReclamo);

            entity.ToTable("CVT_Reclamo_Archivos");

            entity.Property(e => e.IdRutaArchivoReclamo).HasColumnName("Id_RutaArchivoReclamo");
            entity.Property(e => e.Extencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdReclamo).HasColumnName("Id_Reclamo");
            entity.Property(e => e.NombreArchivo).IsUnicode(false);
            entity.Property(e => e.RutaArchivo).IsUnicode(false);
        });

        modelBuilder.Entity<CvtReclamoDestinatario>(entity =>
        {
            entity.HasKey(e => e.IdDestinaReclamo).HasName("PK_CVT_Reclamo_Detalle");

            entity.ToTable("CVT_Reclamo_Destinatario");

            entity.Property(e => e.IdDestinaReclamo).HasColumnName("id_DestinaReclamo");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.Comuna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo).IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdReclamo).HasColumnName("id_Reclamo");
            entity.Property(e => e.MedioEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Seguimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtReclamoDetalleProd>(entity =>
        {
            entity.HasKey(e => e.IdDetReclamo);

            entity.ToTable("CVT_Reclamo_DetalleProd");

            entity.Property(e => e.IdDetReclamo).HasColumnName("ID_DetReclamo");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdReclamo).HasColumnName("ID_Reclamo");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidadDeMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRecurso>(entity =>
        {
            entity.HasKey(e => e.RecursoId);

            entity.ToTable("CVT_Recurso");

            entity.Property(e => e.NombreRecurso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Recurso");
        });

        modelBuilder.Entity<CvtRecursoMantencion>(entity =>
        {
            entity.HasKey(e => e.RecursoId);

            entity.ToTable("CVT_RecursoMantencion");

            entity.Property(e => e.RecursoId).HasColumnName("Recurso_Id");
            entity.Property(e => e.RecursoNombre)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Recurso_Nombre");
        });

        modelBuilder.Entity<CvtRegEstadoCamionesCruzado>(entity =>
        {
            entity.HasKey(e => e.IdRegRecepcionCamiones);

            entity.ToTable("CVT_RegEstadoCamionesCruzados");

            entity.Property(e => e.IdRegRecepcionCamiones).HasColumnName("id_RegRecepcionCamiones");
            entity.Property(e => e.Fercha).HasColumnType("datetime");
            entity.Property(e => e.Ncamiones).HasColumnName("NCamiones");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_Region");

            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Ncorto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NCorto");
            entity.Property(e => e.NombreRegion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre_Region");
            entity.Property(e => e.Nregion).HasColumnName("NRegion");
            entity.Property(e => e.TipoTransporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroAmonestacion>(entity =>
        {
            entity.HasKey(e => e.IdAmonestacion);

            entity.ToTable("CVT_RegistroAmonestacion");

            entity.Property(e => e.IdAmonestacion).HasColumnName("Id_Amonestacion");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.Deptid)
                .HasMaxLength(50)
                .HasColumnName("DEPTID");
            entity.Property(e => e.FechaAmonestacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Amonestacion");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdAmonestador).HasColumnName("Id_Amonestador");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.Incumplimiento).IsUnicode(false);
            entity.Property(e => e.PlazoEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.Seguimiento).IsUnicode(false);
            entity.Property(e => e.TipoIncidencia).HasColumnName("Tipo_Incidencia");
            entity.Property(e => e.Verificacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroAmonestacionPersona>(entity =>
        {
            entity.HasKey(e => new { e.IdAmonestacion, e.IdPersonal });

            entity.ToTable("CVT_RegistroAmonestacion_Persona");

            entity.Property(e => e.IdAmonestacion).HasColumnName("Id_Amonestacion");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
        });

        modelBuilder.Entity<CvtRegistroCamion>(entity =>
        {
            entity.HasKey(e => e.IdRegistroCamion);

            entity.ToTable("CVT_RegistroCamion");

            entity.Property(e => e.IdRegistroCamion).HasColumnName("Id_RegistroCamion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Salida");
            entity.Property(e => e.IdCamion).HasColumnName("Id_Camion");
            entity.Property(e => e.IdChofer).HasColumnName("Id_Chofer");
            entity.Property(e => e.IdPeoneta).HasColumnName("Id_Peoneta");
            entity.Property(e => e.NumDocumento).HasColumnName("Num_Documento");
            entity.Property(e => e.Patente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PatenteRampla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Patente_Rampla");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento).HasColumnName("Tipo_documento");
        });

        modelBuilder.Entity<CvtRegistroCargaCombustible>(entity =>
        {
            entity.HasKey(e => e.IdLitrosPrecio);

            entity.ToTable("CVT_RegistroCargaCombustible");

            entity.Property(e => e.IdLitrosPrecio).HasColumnName("Id_LitrosPrecio");
            entity.Property(e => e.Litros).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nestanque).HasColumnName("NEstanque");
            entity.Property(e => e.NumeroDocumento).HasColumnName("Numero_Documento");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioLitro)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Litro");
        });

        modelBuilder.Entity<CvtRegistroCargaCombustibleJefatura>(entity =>
        {
            entity.HasKey(e => e.IdCarga);

            entity.ToTable("CVT_RegistroCargaCombustible_Jefatura");

            entity.Property(e => e.IdCarga).HasColumnName("Id_Carga");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Litros).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroCargaUrea>(entity =>
        {
            entity.HasKey(e => e.IdCargaUrea);

            entity.ToTable("CVT_RegistroCargaUrea");

            entity.Property(e => e.IdCargaUrea).HasColumnName("Id_CargaUrea");
            entity.Property(e => e.CostoxCarga).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LitrosCargados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nestanque).HasColumnName("NEstanque");
            entity.Property(e => e.Odometro).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalCarga)
                .HasComputedColumnSql("([LitrosCargados]*[CostoxCarga])", false)
                .HasColumnType("decimal(37, 2)");
        });

        modelBuilder.Entity<CvtRegistroCompraUrea>(entity =>
        {
            entity.HasKey(e => e.IdRegUrea);

            entity.ToTable("CVT_Registro_CompraUrea");

            entity.Property(e => e.IdRegUrea).HasColumnName("Id_Reg_Urea");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.LitrosComprados).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total)
                .HasComputedColumnSql("([LitrosComprados]*[PrecioLitro])", false)
                .HasColumnType("decimal(29, 0)");
        });

        modelBuilder.Entity<CvtRegistroFallaGrua>(entity =>
        {
            entity.HasKey(e => e.RfgId);

            entity.ToTable("CVT_RegistroFallaGruas");

            entity.Property(e => e.RfgId).HasColumnName("RFG_ID");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.EmpresaReclamo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFalla).HasColumnType("datetime");
            entity.Property(e => e.FechaReparacion).HasColumnType("datetime");
            entity.Property(e => e.GruaId).HasColumnName("Grua_ID");
            entity.Property(e => e.Horometro).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Resolucion).IsUnicode(false);
            entity.Property(e => e.TfallaId).HasColumnName("TFalla_ID");
        });

        modelBuilder.Entity<CvtRegistroFumigacion>(entity =>
        {
            entity.HasKey(e => e.IdFumigacion).HasName("PK_CVT_RegistroFumigacion_1");

            entity.ToTable("CVT_RegistroFumigacion");

            entity.Property(e => e.IdFumigacion).HasColumnName("Id_Fumigacion");
            entity.Property(e => e.Certificado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFumigacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Fumigacion");
            entity.Property(e => e.FechaVentilacion).HasColumnName("Fecha_Ventilacion");
            entity.Property(e => e.NumeroRecepcion).HasColumnName("Numero_Recepcion");
            entity.Property(e => e.Observaciones).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroHallazgoMateriaExtraña>(entity =>
        {
            entity.HasKey(e => e.IdRegistroHallazgo);

            entity.ToTable("CVT_RegistroHallazgoMateriaExtraña");

            entity.Property(e => e.IdRegistroHallazgo).HasColumnName("Id_RegistroHallazgo");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionMe).HasColumnName("DescripcionME");
            entity.Property(e => e.FechaHallazgo).HasColumnName("Fecha_Hallazgo");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.IdTipoHallazgo).HasColumnName("Id_TipoHallazgo");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfProducto).HasColumnName("OF_Producto");
            entity.Property(e => e.SalaId).HasColumnName("SALA_ID");
            entity.Property(e => e.Turno)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroHigienePlantum>(entity =>
        {
            entity.HasKey(e => e.IdRegistroHigienePlanta);

            entity.ToTable("CVT_RegistroHigienePlanta");

            entity.Property(e => e.IdRegistroHigienePlanta).HasColumnName("Id_RegistroHigienePlanta");
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdAreaHigiene).HasColumnName("Id_AreaHigiene");
            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.IdTipoZonaHigiene).HasColumnName("Id_tipoZonaHigiene");
            entity.Property(e => e.IdZonaHigiene).HasColumnName("Id_ZonaHigiene");
            entity.Property(e => e.Observaciones).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroIncidenciaMovistar>(entity =>
        {
            entity.HasKey(e => e.IdIncidenciaInf);

            entity.ToTable("CVT_RegistroIncidenciaMovistar");

            entity.Property(e => e.IdIncidenciaInf).HasColumnName("Id_IncidenciaInf");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.Diagnostico).IsUnicode(false);
            entity.Property(e => e.FechaCaida).HasColumnType("datetime");
            entity.Property(e => e.FechaReparacion).HasColumnType("datetime");
            entity.Property(e => e.Nticket)
                .IsUnicode(false)
                .HasColumnName("NTicket");
            entity.Property(e => e.ServicioAfectado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroOdometro>(entity =>
        {
            entity.HasKey(e => e.IdRegistroOdometro);

            entity.ToTable("CVT_RegistroOdometro");

            entity.Property(e => e.IdRegistroOdometro).HasColumnName("Id_RegistroOdometro");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.LecturaOdometro).HasColumnName("Lectura_Odometro");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroPatronTestigo>(entity =>
        {
            entity.HasKey(e => e.IdPatronesTestigo);

            entity.ToTable("CVT_RegistroPatronTestigo");

            entity.Property(e => e.IdPatronesTestigo).HasColumnName("Id_PatronesTestigo");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patron)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroRechazoPncSubCatNc>(entity =>
        {
            entity.HasKey(e => e.IdSubCategoriaNc);

            entity.ToTable("CVT_Registro_RechazoPNC_SubCatNC");

            entity.Property(e => e.IdSubCategoriaNc).HasColumnName("Id_SubCategoriaNC");
            entity.Property(e => e.SubCategoria).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroRechazoProductoNoConforme>(entity =>
        {
            entity.HasKey(e => e.IdRechazoPt);

            entity.ToTable("CVT_Registro_RechazoProductoNoConforme");

            entity.Property(e => e.IdRechazoPt).HasColumnName("Id_RechazoPT");
            entity.Property(e => e.CantContenedoras)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cant_Contenedoras");
            entity.Property(e => e.DestinoRechazo)
                .IsUnicode(false)
                .HasColumnName("Destino_Rechazo");
            entity.Property(e => e.Especificacion).IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdSubcategoriaNc).HasColumnName("Id_SubcategoriaNC");
            entity.Property(e => e.MotivoRechazo)
                .IsUnicode(false)
                .HasColumnName("Motivo_Rechazo");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoNc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TipoNC");
        });

        modelBuilder.Entity<CvtRegistroRevisionCamionFactura>(entity =>
        {
            entity.HasKey(e => e.IdRevisionCamionFactura).HasName("PK_CVT_RegistroVerificacionCamionFactura");

            entity.ToTable("CVT_RegistroRevisionCamionFactura");

            entity.Property(e => e.IdRevisionCamionFactura).HasColumnName("Id_RevisionCamionFactura");
            entity.Property(e => e.Cliente)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_CLIENTEFACTURA]([Folio]))", false);
            entity.Property(e => e.Destino)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_DESTINOFACTURA]([Folio]))", false);
            entity.Property(e => e.IdRevisionCamion).HasColumnName("Id_RevisionCamion");
            entity.Property(e => e.PatenteSistema)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_PATENTEFACTURA]([Folio]))", false)
                .HasColumnName("Patente_Sistema");
        });

        modelBuilder.Entity<CvtRegistroRevisionCamione>(entity =>
        {
            entity.HasKey(e => e.IdRevisionCamion);

            entity.ToTable("CVT_RegistroRevisionCamiones");

            entity.Property(e => e.IdRevisionCamion).HasColumnName("Id_RevisionCamion");
            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.QuienCarga)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TotalDoc).HasComputedColumnSql("([dbo].[TotalDocRegistradosRevCamion]([Id_RevisionCamion]))", false);
            entity.Property(e => e.UConductor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_Conductor");
        });

        modelBuilder.Entity<CvtRegistroSaturacionPatrone>(entity =>
        {
            entity.HasKey(e => e.IdSaturacionPatrones);

            entity.ToTable("CVT_RegistroSaturacionPatrones");

            entity.Property(e => e.IdSaturacionPatrones).HasColumnName("Id_SaturacionPatrones");
            entity.Property(e => e.Fe25mm).HasColumnName("FE25mm");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.HoraRegistro).HasPrecision(2);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nofe30mm).HasColumnName("NOFE30mm");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroSaturacionPatronesAntiguo>(entity =>
        {
            entity.HasKey(e => e.IdSaturacionPatronesAntiguo);

            entity.ToTable("CVT_RegistroSaturacionPatronesAntiguo");

            entity.Property(e => e.IdSaturacionPatronesAntiguo).HasColumnName("Id_SaturacionPatronesAntiguo");
            entity.Property(e => e.Fe15mm).HasColumnName("FE15mm");
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.HoraRegistro).HasPrecision(2);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoFe25mm).HasColumnName("NoFE25mm");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroTarea>(entity =>
        {
            entity.HasKey(e => e.IdTarea);

            entity.ToTable("CVT_Registro_Tareas");

            entity.Property(e => e.Asunto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Detalle).IsUnicode(false);
            entity.Property(e => e.DptoId).HasColumnName("DptoID");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioReal).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.FechaTerminoReal).HasColumnType("datetime");
            entity.Property(e => e.HoraInicioReal).HasPrecision(0);
            entity.Property(e => e.HoraTeminoReal).HasPrecision(0);
            entity.Property(e => e.IdCreador).HasColumnName("Id_Creador");
            entity.Property(e => e.Resolucion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRegistroVerificacionBolsa>(entity =>
        {
            entity.HasKey(e => e.IdVerificacionBolsas).HasName("PK_CVT_CodificacionSelladoBolsas");

            entity.ToTable("CVT_RegistroVerificacionBolsas");

            entity.Property(e => e.IdVerificacionBolsas).HasColumnName("Id_VerificacionBolsas");
            entity.Property(e => e.ColacionInicio).HasColumnName("Colacion_inicio");
            entity.Property(e => e.ColacionTermino).HasColumnName("Colacion_Termino");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaElaboracion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Elaboracion");
            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.Of).HasColumnName("OF");
        });

        modelBuilder.Entity<CvtRegistroVerificacionBolsasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdVerificacionBolsasDetalle);

            entity.ToTable("CVT_RegistroVerificacionBolsasDetalle");

            entity.Property(e => e.IdVerificacionBolsasDetalle).HasColumnName("Id_VerificacionBolsasDetalle");
            entity.Property(e => e.CodigoBarraDun14).HasColumnName("CodigoBarraDUN14");
            entity.Property(e => e.CodigoBarraEan13).HasColumnName("CodigoBarraEAN13");
            entity.Property(e => e.FechaElaboracion).HasColumnName("Fecha_elaboracion");
            entity.Property(e => e.FechaElaboracionLote).HasColumnName("Fecha_ElaboracionLote");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_vencimiento");
            entity.Property(e => e.HoraEnvasadoCorrecto).HasColumnName("HoraEnvasado_Correcto");
            entity.Property(e => e.IdVerificacionBolsas).HasColumnName("Id_VerificacionBolsas");
            entity.Property(e => e.LineaCorrecta).HasColumnName("Linea_Correcta");
            entity.Property(e => e.LoteCorrecto).HasColumnName("Lote_Correcto");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrigenIndicadoInjeckt).HasColumnName("Origen_indicadoInjeckt");
            entity.Property(e => e.SelloHorizContenedora).HasColumnName("SelloHoriz_Contenedora");
            entity.Property(e => e.SelloHorizontal).HasColumnName("Sello_horizontal");
            entity.Property(e => e.SelloVertiContenedora).HasColumnName("SelloVerti_Contenedora");
            entity.Property(e => e.SelloVertical).HasColumnName("Sello_vertical");
            entity.Property(e => e.TurnoCorrecto).HasColumnName("Turno_Correcto");
        });

        modelBuilder.Entity<CvtRelacionGrupoFamilium>(entity =>
        {
            entity.HasKey(e => new { e.GrupoSap, e.GrupoWms });

            entity.ToTable("CVT_RelacionGrupoFamilia");

            entity.Property(e => e.GrupoSap).HasColumnName("GrupoSAP");
            entity.Property(e => e.GrupoWms).HasColumnName("GrupoWMS");
        });

        modelBuilder.Entity<CvtRendicionCosto>(entity =>
        {
            entity.HasKey(e => e.IdRendi);

            entity.ToTable("CVT_RendicionCostos");

            entity.Property(e => e.IdRendi).HasColumnName("Id_Rendi");
            entity.Property(e => e.Empresa).IsUnicode(false);
            entity.Property(e => e.FechaCierreRendi).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaValidacion).HasColumnType("datetime");
            entity.Property(e => e.IdusuarioCierraRendi).HasColumnName("IDUsuarioCierraRendi");
            entity.Property(e => e.IdusuarioCrea).HasColumnName("IDUsuarioCrea");
            entity.Property(e => e.IdusuarioValida).HasColumnName("IDUsuarioValida");
            entity.Property(e => e.MotivoGasto).IsUnicode(false);
            entity.Property(e => e.RunSolicita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalRendicion).HasComputedColumnSql("([dbo].[TotalRendicion]([Id_Rendi]))", false);
        });

        modelBuilder.Entity<CvtRendicionCostosDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetRendi);

            entity.ToTable("CVT_RendicionCostos_Detalle");

            entity.Property(e => e.IdDetRendi).HasColumnName("ID_Det_Rendi");
            entity.Property(e => e.ConceptoIngreso).IsUnicode(false);
            entity.Property(e => e.ExtencionDoc).HasMaxLength(50);
            entity.Property(e => e.FechaRend).HasColumnType("datetime");
            entity.Property(e => e.IdRendi).HasColumnName("Id_Rendi");
            entity.Property(e => e.NombreDoc).IsUnicode(false);
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.RutaDoc).IsUnicode(false);
            entity.Property(e => e.TipoDoc).IsUnicode(false);
        });

        modelBuilder.Entity<CvtReporteTrazabilidad>(entity =>
        {
            entity.HasKey(e => e.IdReporte)
                .HasName("CVT_RptTraza_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ReporteTrazabilidad");

            entity.Property(e => e.Descripción)
                .HasMaxLength(500)
                .HasDefaultValue("");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.NombreReporte)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtReservaStockPallet>(entity =>
        {
            entity.HasKey(e => new { e.NumPedido, e.PackageSscc })
                .HasName("CVT_ResStockPallet_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ReservaStock_Pallets");

            entity.Property(e => e.PackageSscc)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.CantPedidoSap)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantPedidoSAP");
            entity.Property(e => e.CantidadReserva).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ' collate SQL_Latin1_General_CP850_CI_AS)");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtReservaStockPedidoUbicacion>(entity =>
        {
            entity.HasKey(e => e.NumPedido)
                .HasName("CVT_ResStockPedUb_PK")
                .IsClustered(false);

            entity.ToTable("CVT_ReservaStock_PedidoUbicacion", tb => tb.HasTrigger("CVT_ReservaStock_PedidoUbicacion_UPDATE"));

            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.LayoutWms).HasColumnName("Layout_Wms");
            entity.Property(e => e.ObsLugarFisico)
                .HasMaxLength(500)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtRespuestaEncuestum>(entity =>
        {
            entity.HasKey(e => e.IdRespuestas);

            entity.ToTable("CVT_RespuestaEncuesta");

            entity.Property(e => e.IdRespuestas).HasColumnName("Id_Respuestas");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdPregunta).HasColumnName("Id_Pregunta");
        });

        modelBuilder.Entity<CvtRevisionExtintor>(entity =>
        {
            entity.HasKey(e => e.IdRevisionExtintor);

            entity.ToTable("CVT_REVISION_EXTINTOR");

            entity.Property(e => e.IdRevisionExtintor).HasColumnName("Id_Revision_Extintor");
            entity.Property(e => e.FechaInspeccion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Inspeccion");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Nextintor).HasColumnName("NExtintor");
            entity.Property(e => e.TipoAgente).IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VigenciaRecarga).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtRevisionExtintorDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetExtintor);

            entity.ToTable("CVT_REVISION_EXTINTOR_DETALLE");

            entity.Property(e => e.IdDetExtintor).HasColumnName("Id_DetExtintor");
            entity.Property(e => e.IdRevisionExtintor).HasColumnName("Id_Revision_Extintor");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Pregunta).IsUnicode(false);
            entity.Property(e => e.Respuesta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRevisionExtintorEntorno>(entity =>
        {
            entity.HasKey(e => e.IdRevisionEntorno);

            entity.ToTable("CVT_REVISION_EXTINTOR_ENTORNO");

            entity.Property(e => e.IdRevisionEntorno).HasColumnName("Id_RevisionEntorno");
            entity.Property(e => e.IdRevisionExtintor).HasColumnName("Id_Revision_Extintor");
            entity.Property(e => e.ObservacionEntorno).IsUnicode(false);
            entity.Property(e => e.PreguntaEntorno).IsUnicode(false);
            entity.Property(e => e.RespuestaEntorno)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRondaCheckPoint>(entity =>
        {
            entity.HasKey(e => e.CheckPointId);

            entity.ToTable("CVT_Ronda_CheckPoint");

            entity.Property(e => e.CheckPointId).HasColumnName("CheckPoint_ID");
            entity.Property(e => e.CheckPointCoordenadas)
                .IsUnicode(false)
                .HasColumnName("CheckPoint_Coordenadas");
            entity.Property(e => e.CheckPointLugar)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CheckPoint_Lugar");
        });

        modelBuilder.Entity<CvtRondaRegistro>(entity =>
        {
            entity.HasKey(e => e.RegistroRondaId);

            entity.ToTable("CVT_Ronda_Registro");

            entity.Property(e => e.RegistroRondaId).HasColumnName("RegistroRonda_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UrlUbicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL_Ubicacion");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtRptVentasDiaria>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_RptVentasDiarias");

            entity.Property(e => e.Mensaje).HasMaxLength(150);
        });

        modelBuilder.Entity<CvtRptetiquetaTipoPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_RPTEtiqueta_TipoPallet");

            entity.Property(e => e.ClaveSeguridad).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(80);
            entity.Property(e => e.IdTipo)
                .HasComment("1: Normal    2: envasado")
                .HasColumnName("Id_Tipo");
        });

        modelBuilder.Entity<CvtRptetiquetum>(entity =>
        {
            entity.HasKey(e => e.PackageId)
                .HasName("CVT_RPTEtiqueta_PK")
                .IsClustered(false);

            entity.ToTable("CVT_RPTEtiqueta");

            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.FechaImpresion)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IdTipo)
                .HasComment("1: Normal   2: Producción")
                .HasColumnName("Id_Tipo");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Package_SSCC");
        });

        modelBuilder.Entity<CvtRutaArchivoNoConformidad>(entity =>
        {
            entity.HasKey(e => e.IdRutaArchivoNoConformidad);

            entity.ToTable("CVT_RutaArchivoNoConformidad");

            entity.Property(e => e.IdRutaArchivoNoConformidad).HasColumnName("Id_RutaArchivoNoConformidad");
            entity.Property(e => e.Extencion)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IdNoConformidad).HasColumnName("Id_NoConformidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtRutaCamion>(entity =>
        {
            entity.HasKey(e => e.IdRutaCamion);

            entity.ToTable("CVT_RutaCamion");

            entity.Property(e => e.IdRutaCamion).HasColumnName("Id_RutaCamion");
            entity.Property(e => e.CantPeonetas).HasColumnName("Cant_Peonetas");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRuta).HasColumnName("Fecha_Ruta");
            entity.Property(e => e.HraEntrada).HasColumnName("Hra_Entrada");
            entity.Property(e => e.HraSalida).HasColumnName("Hra_Salida");
            entity.Property(e => e.LlevaCarro).HasColumnName("LLeva_Carro");
            entity.Property(e => e.NombreChofer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Chofer");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatenteCarro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Patente_Carro");
            entity.Property(e => e.TipoVuelta).HasColumnName("Tipo_vuelta");
        });

        modelBuilder.Entity<CvtRutaCertificadoFumigacion>(entity =>
        {
            entity.HasKey(e => e.IdRuta);

            entity.ToTable("CVT_RutaCertificadoFumigacion");

            entity.Property(e => e.IdRuta).HasColumnName("idRuta");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtSalasenvasado>(entity =>
        {
            entity.HasKey(e => e.SalaId);

            entity.ToTable("CVT_SALASENVASADO");

            entity.Property(e => e.SalaId).HasColumnName("SALA_ID");
            entity.Property(e => e.CantLinea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cant_Linea");
            entity.Property(e => e.CantMaquinas).HasColumnName("CANT_MAQUINAS");
            entity.Property(e => e.NumSala).HasColumnName("NUM_SALA");
        });

        modelBuilder.Entity<CvtSalidaInsumo>(entity =>
        {
            entity.HasKey(e => e.SalidaInsumosId);

            entity.ToTable("CVT_SalidaInsumos");

            entity.Property(e => e.SalidaInsumosId).HasColumnName("SalidaInsumos_ID");
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Responsable)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtSalidaInsumosDetalle>(entity =>
        {
            entity.HasKey(e => e.SalidaInsumosDetalleId);

            entity.ToTable("CVT_SalidaInsumosDetalle");

            entity.Property(e => e.SalidaInsumosDetalleId).HasColumnName("SalidaInsumosDetalle_ID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ccosto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCosto");
            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[ObtieneDivision]([CCosto]))", false);
            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalidaInsumosId).HasColumnName("SalidaInsumos_ID");
            entity.Property(e => e.Uadm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[ObtieneUAMD]([CCosto]))", false)
                .HasColumnName("UAdm");
        });

        modelBuilder.Entity<CvtSapcompany>(entity =>
        {
            entity.HasKey(e => e.Sapcompany);

            entity.ToTable("CVT_SAPCompany");

            entity.Property(e => e.Sapcompany)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAPCompany");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserManager)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtSeguro>(entity =>
        {
            entity.HasKey(e => e.Poliza);

            entity.ToTable("CVT_Seguro");

            entity.Property(e => e.Poliza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compania)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Moneda)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimaAfecta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrimaExenta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrimaTotal)
                .HasComputedColumnSql("(isnull([PrimaAfecta],(0))+isnull([PrimaExenta],(0)))", false)
                .HasColumnType("decimal(19, 4)");
        });

        modelBuilder.Entity<CvtSeguroDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleSeguro);

            entity.ToTable("CVT_Seguro_Detalle");

            entity.Property(e => e.IdDetalleSeguro).HasColumnName("Id_Detalle_Seguro");
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.IdMateriaAsegurada).HasColumnName("id_MateriaAsegurada");
            entity.Property(e => e.MontoAsegurado).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Nfactura)
                .IsUnicode(false)
                .HasColumnName("NFactura");
            entity.Property(e => e.Poliza)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtSeguroEmpresaRelacionadum>(entity =>
        {
            entity.HasKey(e => e.Rut);

            entity.ToTable("CVT_Seguro_Empresa_Relacionada");

            entity.Property(e => e.Rut).ValueGeneratedNever();
            entity.Property(e => e.DescripcionEmpresa).IsUnicode(false);
        });

        modelBuilder.Entity<CvtSeguroMateriaAseguradum>(entity =>
        {
            entity.HasKey(e => e.IdMateriaAsegurada);

            entity.ToTable("CVT_Seguro_MateriaAsegurada");

            entity.Property(e => e.IdMateriaAsegurada).HasColumnName("Id_MateriaAsegurada");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdTipoSeguro).HasColumnName("Id_TipoSeguro");
        });

        modelBuilder.Entity<CvtSeguroTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoSeguro).HasName("PK_CVT_Seguros_Tipo");

            entity.ToTable("CVT_Seguro_Tipo");

            entity.Property(e => e.IdTipoSeguro).HasColumnName("Id_TipoSeguro");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtSistemasInterno>(entity =>
        {
            entity.HasKey(e => e.IdSistema)
                .HasName("CVT_Sistemasinternos_PK")
                .IsClustered(false);

            entity.ToTable("CVT_SistemasInternos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtSiteUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_SITE_USUARIOS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtSolicitudCompra>(entity =>
        {
            entity.HasKey(e => e.SolicitudCompraId);

            entity.ToTable("CVT_SolicitudCompra");

            entity.Property(e => e.SolicitudCompraId).HasColumnName("SolicitudCompra_Id");
            entity.Property(e => e.Area)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaNecesaria).HasColumnType("datetime");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtSolicitudCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.SolicitudCompraDetalleId);

            entity.ToTable("CVT_SolicitudCompraDetalle");

            entity.Property(e => e.SolicitudCompraDetalleId).HasColumnName("SolicitudCompraDetalle_Id");
            entity.Property(e => e.Almacen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CentroCostro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioInfo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudCompraId).HasColumnName("SolicitudCompra_Id");
            entity.Property(e => e.UnidadAdministrativa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_Stock");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Codigo).HasMaxLength(15);
            entity.Property(e => e.ComprometidoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostoProm).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostoUltCompra).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.SolicitadoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Stock).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtStockAperturaMe>(entity =>
        {
            entity.HasKey(e => new { e.Mes, e.Año, e.CodProducto, e.Bodega });

            entity.ToTable("CVT_StockAperturaMes");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrupoArticulo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtStockBma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_StockBMAS");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Codigo).HasMaxLength(15);
            entity.Property(e => e.ComprometidoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostoProm).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostoUltCompra).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.SolicitadoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Stock).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtSubMenu>(entity =>
        {
            entity.HasKey(e => e.IdSubMenu);

            entity.ToTable("CVT_SubMenu");

            entity.Property(e => e.NombreSubMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_SubMenu");
            entity.Property(e => e.Tooltip).IsUnicode(false);
            entity.Property(e => e.UrlSubMenu)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_SubMenu");
        });

        modelBuilder.Entity<CvtSupervisore>(entity =>
        {
            entity.HasKey(e => e.IdRegistroSupervision);

            entity.ToTable("CVT_Supervisores");

            entity.Property(e => e.IdRegistroSupervision).HasColumnName("Id_RegistroSupervision");
            entity.Property(e => e.IdSuperVisor).HasColumnName("Id_SuperVisor");
            entity.Property(e => e.IdVendedor).HasColumnName("Id_Vendedor");
            entity.Property(e => e.NombreSupervisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_NombreSupervisor]([Id_SuperVisor]))", false);
            entity.Property(e => e.NombreVendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[CVT_NombreSupervisor]([Id_Vendedor]))", false);
            entity.Property(e => e.Zona).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTablaPrueba>(entity =>
        {
            entity.HasKey(e => e.Run);

            entity.ToTable("CVT_tabla_prueba");

            entity.Property(e => e.Run)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("run");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .HasColumnName("apellidos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<CvtTarea>(entity =>
        {
            entity.HasKey(e => e.TareaId);

            entity.ToTable("CVT_Tarea");

            entity.Property(e => e.TareaId).HasColumnName("Tarea_Id");
            entity.Property(e => e.TareaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tarea_Nombre");
        });

        modelBuilder.Entity<CvtTarifasExterno>(entity =>
        {
            entity.HasKey(e => new { e.CvtCargo, e.Empresa }).HasName("PK_CVT_TarifasExternos_1");

            entity.ToTable("CVT_TarifasExternos");

            entity.Property(e => e.CvtCargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CVT_Cargo");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ValorHora)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Valor_Hora");
        });

        modelBuilder.Entity<CvtTblConsumoOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_TBL_CONSUMO_OF");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Cantidad2).HasColumnName("CANTIDAD2");
            entity.Property(e => e.CodigoLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_LOTE");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PRODUCTO");
            entity.Property(e => e.CodigoProducto2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODIGO_PRODUCTO2");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.ItemOf)
                .ValueGeneratedOnAdd()
                .HasColumnName("ITEM_OF");
            entity.Property(e => e.Line).HasColumnName("LINE");
            entity.Property(e => e.Motivo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.NroOf).HasColumnName("NRO_OF");
            entity.Property(e => e.TipoProducto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TIPO_PRODUCTO");
        });

        modelBuilder.Entity<CvtTestWsintranet>(entity =>
        {
            entity.ToTable("CVT_Test_WSIntranet");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTfallaGrua>(entity =>
        {
            entity.HasKey(e => e.TfallaId);

            entity.ToTable("CVT_TFallaGrua");

            entity.Property(e => e.TfallaId).HasColumnName("TFalla_ID");
            entity.Property(e => e.TfallaNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TFalla_Nombre");
        });

        modelBuilder.Entity<CvtTicket>(entity =>
        {
            entity.HasKey(e => e.IdTicket);

            entity.ToTable("CVT_Ticket");

            entity.Property(e => e.IdTicket)
                .ValueGeneratedNever()
                .HasColumnName("Id_Ticket");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.FechaTomaTicket).HasColumnType("datetime");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdCategoriaTicket).HasColumnName("id_CategoriaTicket");
            entity.Property(e => e.IdTipoProblema).HasColumnName("id_TipoProblema");
            entity.Property(e => e.IdTomaTicket).HasColumnName("Id_TomaTicket");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
        });

        modelBuilder.Entity<CvtTicketAdjuntoRespuestum>(entity =>
        {
            entity.HasKey(e => e.IdAdjTicketResp);

            entity.ToTable("CVT_Ticket_AdjuntoRespuesta");

            entity.Property(e => e.IdAdjTicketResp).HasColumnName("Id_AdjTicketResp");
            entity.Property(e => e.Extencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdRespTiquet).HasColumnName("Id_RespTiquet");
            entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTicketsArchivoAdjunto>(entity =>
        {
            entity.HasKey(e => e.IdAdjuntoTicket);

            entity.ToTable("CVT_Tickets_ArchivoAdjunto");

            entity.Property(e => e.IdAdjuntoTicket).HasColumnName("Id_AdjuntoTicket");
            entity.Property(e => e.Extencion).HasMaxLength(50);
            entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTicketsCategorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaTicket);

            entity.ToTable("CVT_Tickets_Categoria");

            entity.Property(e => e.IdCategoriaTicket).HasColumnName("id_CategoriaTicket");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.Nombre).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTicketsRespuestum>(entity =>
        {
            entity.HasKey(e => e.IdRespuestaTicket);

            entity.ToTable("CVT_Tickets_Respuesta");

            entity.Property(e => e.IdRespuestaTicket).HasColumnName("Id_RespuestaTicket");
            entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");
            entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Respuesta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTicketsTipoProblema>(entity =>
        {
            entity.HasKey(e => e.IdTipoProblema);

            entity.ToTable("CVT_Tickets_TipoProblema");

            entity.Property(e => e.IdTipoProblema).HasColumnName("id_TipoProblema");
            entity.Property(e => e.IdCategoriaTicket).HasColumnName("id_CategoriaTicket");
            entity.Property(e => e.NombreProblema).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTiempobajadapedidopbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_TIEMPOBAJADAPEDIDOPBI");

            entity.Property(e => e.OrderUNumDocSap).HasColumnName("Order_U_NumDocSAP");
            entity.Property(e => e.PrimeroPosicionado).HasColumnType("datetime");
            entity.Property(e => e.UltimoPosicionado).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtTipoCarroceriaCamion>(entity =>
        {
            entity.HasKey(e => e.IdTipoCarroceria);

            entity.ToTable("CVT_TipoCarroceriaCamion");

            entity.Property(e => e.IdTipoCarroceria).HasColumnName("Id_TipoCarroceria");
            entity.Property(e => e.Carroceria)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTipoHallazgoMe>(entity =>
        {
            entity.HasKey(e => e.IdTipoHallazgo);

            entity.ToTable("CVT_TipoHallazgoME");

            entity.Property(e => e.IdTipoHallazgo).HasColumnName("Id_TipoHallazgo");
            entity.Property(e => e.IdCategoriaHallazgo).HasColumnName("Id_CategoriaHallazgo");
            entity.Property(e => e.NombreTipoHallazgo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTipoMantencion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_TipoMantencion");

            entity.Property(e => e.TipoMantencion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_Mantencion");
            entity.Property(e => e.TipoMantencionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TipoMantencion_Id");
        });

        modelBuilder.Entity<CvtTipoServicioAdicional>(entity =>
        {
            entity.HasKey(e => e.TipoServicioAdicionalId);

            entity.ToTable("CVT_TipoServicioAdicional");

            entity.Property(e => e.TipoServicioAdicionalId).HasColumnName("TipoServicioAdicional_Id");
            entity.Property(e => e.TipoServicioAdicionalNombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TipoServicioAdicional_Nombre");
        });

        modelBuilder.Entity<CvtTipoZonaHigiene>(entity =>
        {
            entity.HasKey(e => e.IdTipoZonaHigiene);

            entity.ToTable("CVT_TipoZonaHigiene");

            entity.Property(e => e.IdTipoZonaHigiene).HasColumnName("Id_tipoZonaHigiene");
            entity.Property(e => e.TipoZonaHigiene)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_ZonaHigiene");
        });

        modelBuilder.Entity<CvtTmppedidosSeleccionado>(entity =>
        {
            entity.HasKey(e => new { e.DocEntry, e.IdUsuario })
                .HasName("CVT_TmpPedSel_PK")
                .IsClustered(false);

            entity.ToTable("CVT_TMPPedidosSeleccionados");

            entity.Property(e => e.PesoPendiente)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<CvtToneladasMovida>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_TONELADAS_MOVIDAS");

            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Dscription).HasMaxLength(200);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(100);
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Peso).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.Quantity).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Ton)
                .HasColumnType("numeric(38, 11)")
                .HasColumnName("TON");
            entity.Property(e => e.Tproducto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TProducto");
        });

        modelBuilder.Entity<CvtTransferAsignacion>(entity =>
        {
            entity.HasKey(e => new { e.TransferId, e.ItemCode, e.Lote });

            entity.ToTable("CVT_TransferAsignacion");

            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTransferenciaRechazo>(entity =>
        {
            entity.HasKey(e => e.RechazoId);

            entity.ToTable("CVT_TransferenciaRechazo");

            entity.Property(e => e.RechazoId).HasColumnName("Rechazo_ID");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTransferenciaTiempoCierre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_TransferenciaTiempoCierre");

            entity.Property(e => e.Destino)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Dia).HasColumnName("dia");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Origen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.TransferUFechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_U_FechaCierre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtTransformacion>(entity =>
        {
            entity.HasKey(e => e.TransformacionId);

            entity.ToTable("CVT_Transformacion");

            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ProcRelacionado).IsUnicode(false);
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
        });

        modelBuilder.Entity<CvtTransformacionAjustadum>(entity =>
        {
            entity.HasKey(e => e.TransformacionId);

            entity.ToTable("CVT_TransformacionAjustada");

            entity.Property(e => e.TransformacionId)
                .ValueGeneratedNever()
                .HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtTransformacionDetalle>(entity =>
        {
            entity.HasKey(e => e.TransformacionDetId);

            entity.ToTable("CVT_TransformacionDetalle");

            entity.Property(e => e.TransformacionDetId).HasColumnName("TransformacionDet_Id");
            entity.Property(e => e.ArticleProviderDestinyId).HasColumnName("ArticleProviderDestiny_Id");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageDestinyId).HasColumnName("PackageDestiny_Id");
            entity.Property(e => e.PackageDestinyQuantity).HasColumnName("PackageDestiny_Quantity");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtTransporteMantencion>(entity =>
        {
            entity.HasKey(e => e.IdMantencionTransporte);

            entity.ToTable("CVT_Transporte_Mantencion");

            entity.Property(e => e.IdMantencionTransporte).HasColumnName("Id_MantencionTransporte");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaMantencion).HasColumnType("datetime");
            entity.Property(e => e.NombreChofer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMantencion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtTransporteMantencionRepuesto>(entity =>
        {
            entity.HasKey(e => e.IdRepuestosTransporte);

            entity.ToTable("CVT_Transporte_Mantencion_Repuesto");

            entity.Property(e => e.IdRepuestosTransporte).HasColumnName("Id_RepuestosTransporte");
            entity.Property(e => e.IdMantencionTransporte).HasColumnName("Id_MantencionTransporte");
            entity.Property(e => e.Repuesto).IsUnicode(false);
            entity.Property(e => e.ValorRepuesto).IsUnicode(false);
        });

        modelBuilder.Entity<CvtTratoPorArea>(entity =>
        {
            entity.HasKey(e => e.IdTrato).HasName("PK_CVT_TratoPorAreas_1");

            entity.ToTable("CVT_TratoPorAreas");

            entity.Property(e => e.IdTrato).HasColumnName("Id_Trato");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.MontoHora).HasColumnName("Monto_Hora");
            entity.Property(e => e.MontoMin).HasColumnName("Monto_min");
            entity.Property(e => e.MontoTrato).HasColumnName("Monto_Trato");
            entity.Property(e => e.NombreArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Area");
        });

        modelBuilder.Entity<CvtTrazabilidadSecuenciaEmisionRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVT_TrazabilidadSecuenciaEmisionRpt");

            entity.Property(e => e.CampoKey)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.CampoOrden).HasDefaultValue((short)0);
            entity.Property(e => e.CantParametros)
                .HasDefaultValue((short)0)
                .HasColumnName("Cant_Parametros");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.NombreReporte)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.ValorParametro)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtUbicacionDefecto>(entity =>
        {
            entity.HasKey(e => new { e.SiteId, e.Tipo }).HasName("KCVUbicDefkey");

            entity.ToTable("CVT_UbicacionDefecto");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
        });

        modelBuilder.Entity<CvtUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario)
                .HasName("CVT_Usuarios_PK")
                .IsClustered(false);

            entity.ToTable("CVT_Usuarios");

            entity.HasIndex(e => e.UsuarioSistema, "Usuario").IsUnique();

            entity.Property(e => e.Clave)
                .HasMaxLength(15)
                .HasDefaultValue("1234");
            entity.Property(e => e.ClaveEncriptada)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Depto)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IdArea)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("Id_Area");
            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .HasDefaultValue(" ");
            entity.Property(e => e.RestriccionBodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RutaFirma).IsUnicode(false);
            entity.Property(e => e.RutaFoto).IsUnicode(false);
            entity.Property(e => e.UsuarioSistema)
                .HasMaxLength(20)
                .HasDefaultValue(" ");
        });

        modelBuilder.Entity<CvtVentasDatosProducto>(entity =>
        {
            entity.HasKey(e => e.ItemCode);

            entity.ToTable("CVT_Ventas_DatosProducto");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Upc).HasColumnName("UPC");
        });

        modelBuilder.Entity<CvtVentasFlete>(entity =>
        {
            entity.HasKey(e => e.CvtVentasFletesId);

            entity.ToTable("CVT_Ventas_Fletes");

            entity.Property(e => e.CvtVentasFletesId).HasColumnName("CVT_Ventas_Fletes_Id");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtViewStockwmsProdBodega>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_STOCKWMS_PROD_BODEGA");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.EstadoLote)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Estado_Lote");
            entity.Property(e => e.Fproduccion).HasColumnName("FProduccion");
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<CvtViewStockwmsProdBodegaLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_STOCKWMS_PROD_BODEGA_LOTE");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Fproduccion).HasColumnName("FProduccion");
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_Description");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.Sscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("SSCC");
        });

        modelBuilder.Entity<CvtViewTransformacionDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_View_TransformacionDetalle");

            entity.Property(e => e.ArticleProviderDestinyId).HasColumnName("ArticleProviderDestiny_Id");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.CantidadDestino).HasColumnName("Cantidad_Destino");
            entity.Property(e => e.Codigo)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodigoDestino)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Codigo_Destino");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Npallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("NPallet");
            entity.Property(e => e.NpalletDestino)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("NPallet_Destino");
            entity.Property(e => e.PackageDestinyId).HasColumnName("PackageDestiny_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.Posicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoDestino)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Producto_Destino");
            entity.Property(e => e.TransformacionDetId).HasColumnName("TransformacionDet_Id");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtViewTransformacionDetalleEntradaLotesSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_TransformacionDetalleEntradaLotesSAP");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderDestinyId).HasColumnName("ArticleProviderDestiny_Id");
            entity.Property(e => e.Origen)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtViewTransformacionDetalleEntradaSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_transformacionDetalleEntradaSAP");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderDestinyId).HasColumnName("ArticleProviderDestiny_Id");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.Origen)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtViewTransformacionDetalleSalLotesSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_TransformacionDetalleSalLotesSAP");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtViewTransformacionDetalleSalidaSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VIEW_TransformacionDetalleSalidaSAP");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.TransformacionId).HasColumnName("Transformacion_Id");
        });

        modelBuilder.Entity<CvtVtaperCabPedido>(entity =>
        {
            entity.HasKey(e => new { e.IdCabPedido, e.CodPeriodo, e.SlpCode })
                .HasName("CVT_CAbPedido_PK")
                .IsClustered(false);

            entity.ToTable("CVT_VTAPER_CabPedidos", tb => tb.HasTrigger("CVT_VTAPER_CabPedidosUPDATE"));

            entity.Property(e => e.CodPeriodo)
                .HasMaxLength(6)
                .HasDefaultValue("");
            entity.Property(e => e.CodBodega)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Estado).HasDefaultValue((short)1);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IdUsuario).HasDefaultValue(0);
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtVtaperDetPedido>(entity =>
        {
            entity.HasKey(e => new { e.IdCabPedido, e.CodProducto })
                .HasName("CVT_DetPedido_PK")
                .IsClustered(false);

            entity.ToTable("CVT_VTAPER_DetPedidos", tb => tb.HasTrigger("CVT_VTAPER_DetPedidosUPDATE"));

            entity.Property(e => e.CodProducto)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("('')")
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.EqUsuario)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IdUsuario).HasDefaultValue(0);
            entity.Property(e => e.IpAddress)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CvtVwAsignacionRutaAgendaRecurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AsignacionRutaAgendaRecursos");

            entity.Property(e => e.NombreCorto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwAsignacionRutaAgendum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AsignacionRutaAgenda");

            entity.Property(e => e.Camion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CamionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Camion_ID");
            entity.Property(e => e.Cliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1151)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DocStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaAgendada).HasColumnType("datetime");
            entity.Property(e => e.Horario)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.UAgendamiento)
                .HasMaxLength(50)
                .HasColumnName("U_Agendamiento");
            entity.Property(e => e.UHoraEntrega).HasColumnName("U_Hora_entrega");
        });

        modelBuilder.Entity<CvtVwAsistenciaCompletum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AsistenciaCompleta");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Compañia)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HoraEntrada).HasColumnName("Hora_Entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_Salida");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Labor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MinutosTrabajados).HasColumnName("Minutos_Trabajados");
            entity.Property(e => e.TotalHorasTrabajadas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Trabajador)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtVwAsistenciaCvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AsistenciaCVT");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HoraEntrada).HasColumnName("Hora_Entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_Salida");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Labor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MinutosTrabajados).HasColumnName("Minutos_Trabajados");
            entity.Property(e => e.TotalHorasTrabajadas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Trabajador)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtVwAsistenciaJdb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AsistenciaJDB");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AsistenciaId).HasColumnName("Asistencia_Id");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HoraEntrada).HasColumnName("Hora_Entrada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_Salida");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdLabores).HasColumnName("Id_Labores");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(50)
                .HasColumnName("Id_Personal");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Labor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MinutosTrabajados).HasColumnName("Minutos_Trabajados");
            entity.Property(e => e.TotalHorasTrabajadas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Trabajador)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtVwAuditoriaRecepcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_AuditoriaRecepcion");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAuditoria)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Auditoria");
            entity.Property(e => e.GrueroAsig1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Gruero_Asig_1");
            entity.Property(e => e.GrueroAsignado1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gruero_Asignado_1");
            entity.Property(e => e.GrueroAsignado2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gruero_Asignado_2");
            entity.Property(e => e.IdAuditoria).HasColumnName("Id_Auditoria");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.StaffName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Staff_Name");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwCalculoHorasExtra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_CalculoHorasExtras");

            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.EmpleadoId)
                .HasMaxLength(50)
                .HasColumnName("Empleado_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.He100).HasColumnName("HE_100");
            entity.Property(e => e.Horas).HasColumnType("decimal(24, 6)");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Run)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Semana).HasColumnName("SEMANA");
            entity.Property(e => e.SueldoBase).HasColumnName("sueldo_base");
            entity.Property(e => e.ValorBruto).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ValorRedondeado).HasColumnType("numeric(38, 6)");
            entity.Property(e => e._1000).HasColumnName("1000");
            entity.Property(e => e._10000).HasColumnName("10000");
            entity.Property(e => e._20000).HasColumnName("20000");
            entity.Property(e => e._5000).HasColumnName("5000");
        });

        modelBuilder.Entity<CvtVwCantPalletRecepCv201>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_CantPalletRecepCV201");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(30, 6)");
            entity.Property(e => e.Origen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Producto).HasMaxLength(200);
        });

        modelBuilder.Entity<CvtVwCheckListArmadoPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_CheckListArmadoPedido");

            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.Dun14).HasColumnName("DUN14");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fefo).HasColumnName("FEFO");
            entity.Property(e => e.LugarArmado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observasiones).IsUnicode(false);
            entity.Property(e => e.PedidoN).HasColumnName("Pedido N");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwControlBodega>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ControlBodega");

            entity.Property(e => e.ControlId).HasColumnName("Control_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaJustificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Justificacion");
            entity.Property(e => e.Justificacion).IsUnicode(false);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.LayoutShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_ShortDescription");
            entity.Property(e => e.LoteDestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Destino");
            entity.Property(e => e.LoteOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Lote_Origen");
            entity.Property(e => e.Sscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("SSCC");
            entity.Property(e => e.SsccDestino)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("SSCC_Destino");
            entity.Property(e => e.Tipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoControl).HasColumnName("Tipo_Control");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.UsuarioJustificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Usuario_Justificacion");
        });

        modelBuilder.Entity<CvtVwControlEstimadoFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ControlEstimadoFILM");

            entity.Property(e => e.FilmEnfardadorEstimado).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.FilmImpresoEstimado).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.FilmInformadoEnfardador).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.FilmInformadoImpreso).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.Producido).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtVwDetalleLineasMovilesxPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DetalleLineasMovilesxPlan");

            entity.Property(e => e.Asignado).HasMaxLength(50);
            entity.Property(e => e.CodPlan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Plan");
            entity.Property(e => e.DetallePlan)
                .HasMaxLength(39)
                .IsUnicode(false);
            entity.Property(e => e.FechaAdquisicion).HasColumnType("datetime");
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MarcaAsignada)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModeloAsignadoMovistar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Modelo_AsignadoMovistar");
            entity.Property(e => e.Nlinea).HasColumnName("NLinea");
            entity.Property(e => e.PlanNombre)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Plan_Nombre");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SerieAsignadoMovistar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Serie_AsignadoMovistar");
            entity.Property(e => e.Sim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SIM");
            entity.Property(e => e.TipoEquipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwDetalleProductoBloqueado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Detalle_ProductoBloqueado");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.IdPackage).HasColumnName("Id_package");
            entity.Property(e => e.IdProdBloqDetalle).HasColumnName("Id_ProdBloqDetalle");
            entity.Property(e => e.IdProdBloqueado).HasColumnName("Id_ProdBloqueado");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwDevolucionFilmPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DevolucionFilm_PBI");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Motivo)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwDevolucionPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DevolucionPBI");

            entity.Property(e => e.AreaResponsable)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .HasColumnName("Cod_Cliente");
            entity.Property(e => e.CodMotivo)
                .HasMaxLength(50)
                .HasColumnName("Cod_Motivo");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.FechaDevolucion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Devolucion");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Factura");
            entity.Property(e => e.FolioDevolucionWms).HasColumnName("Folio_Devolucion_WMS");
            entity.Property(e => e.FolioFactura)
                .HasMaxLength(18)
                .HasColumnName("Folio_Factura");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.MontoTotalDevolucion).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.MontoTotalFactura).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Motivo).HasMaxLength(100);
            entity.Property(e => e.NpedidoSap).HasColumnName("NPedidoSAP");
            entity.Property(e => e.NpedidoWms).HasColumnName("NPedidoWMS");
            entity.Property(e => e.PatenteCamion)
                .HasMaxLength(50)
                .HasColumnName("Patente_Camion");
            entity.Property(e => e.PesoTotalDevolucion).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.PesoTotalFactura).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.RazonGlobalDevolucion)
                .HasMaxLength(50)
                .HasColumnName("Razon_Global_Devolucion");
            entity.Property(e => e.UsuarioDespachador).HasMaxLength(20);
            entity.Property(e => e.UsuarioReceptorDevolucion)
                .HasMaxLength(20)
                .HasColumnName("Usuario_Receptor_Devolucion");
        });

        modelBuilder.Entity<CvtVwDevolucionesKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Devoluciones_KPI");

            entity.Property(e => e.AñoDevolucion).HasColumnName("Año_Devolucion");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.MesDevolucion).HasColumnName("Mes_Devolucion");
        });

        modelBuilder.Entity<CvtVwDevolucionesKpiMotivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Devoluciones_KPI_Motivos");

            entity.Property(e => e.AñoDevolucion).HasColumnName("Año_Devolucion");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.MesDevolucion).HasColumnName("Mes_Devolucion");
            entity.Property(e => e.Motivo).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwDevolucionesKpiProduccionPropium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Devoluciones_KPI_ProduccionPropia");

            entity.Property(e => e.AñoDevolucion).HasColumnName("Año_Devolucion");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.MesDevolucion).HasColumnName("Mes_Devolucion");
        });

        modelBuilder.Entity<CvtVwDevolucionesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DevolucionesPBI");

            entity.Property(e => e.AreaResponsable)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AñoDevolucion).HasColumnName("Año_Devolucion");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .HasColumnName("Cod_Cliente");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Kilos).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.MesDevolucion).HasColumnName("Mes_Devolucion");
            entity.Property(e => e.Motivo).HasMaxLength(100);
            entity.Property(e => e.PatenteCamion)
                .HasMaxLength(50)
                .HasColumnName("Patente_Camion");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.UsuarioReceptorDevolucion)
                .HasMaxLength(20)
                .HasColumnName("Usuario_Receptor_Devolucion");
        });

        modelBuilder.Entity<CvtVwDevolucionesVentasKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Devoluciones_Ventas_KPI");

            entity.Property(e => e.Devolucion).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.Porc).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Ventas).HasColumnType("numeric(38, 11)");
        });

        modelBuilder.Entity<CvtVwDiferenciasDuplicado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DiferenciasDuplicados");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Fproduccion)
                .HasColumnType("datetime")
                .HasColumnName("FProduccion");
            entity.Property(e => e.Fvencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FVencimiento");
            entity.Property(e => e.InventarioDetId).HasColumnName("InventarioDet_Id");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwDuplicadosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_DuplicadosInventario");

            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
        });

        modelBuilder.Entity<CvtVwEncuestasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_EncuestasDetalle");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Aspecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdPregunta).HasColumnName("Id_Pregunta");
            entity.Property(e => e.Pregunta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwEncuestasResumenAspecto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_EncuestasResumenAspectos");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Aspecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
        });

        modelBuilder.Entity<CvtVwEncuestasResumenPregunta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_EncuestasResumenPreguntas");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Aspecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdPregunta).HasColumnName("Id_Pregunta");
            entity.Property(e => e.Pregunta).IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwExpedicionFilmPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ExpedicionFilm_PBI");

            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_inicio");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_termino");
            entity.Property(e => e.FolioExp).HasColumnName("Folio_Exp");
            entity.Property(e => e.Motivo)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.NDocumento).HasColumnName("N_Documento");
            entity.Property(e => e.Nota).IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Tipo_Documento");
            entity.Property(e => e.Usuario).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwExpedicionesDetallePbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ExpedicionesDetalle_PBI");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Cod. Producto");
            entity.Property(e => e.Descripción)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.IdBulto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Id Bulto");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwExpedicionesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Expediciones_PBI");

            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_inicio");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_termino");
            entity.Property(e => e.Motivo)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Nota)
                .HasMaxLength(2550)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.NumDocum).HasColumnName("Num_docum");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Tipo_Doc");
            entity.Property(e => e.TipoExpedicion)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("Tipo_Expedicion");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBenv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBENV");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBenvlote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBENVLotes");

            entity.Property(e => e.BatchNum).HasMaxLength(36);
            entity.Property(e => e.CantLote).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBkit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBKIT");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBkitlote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBKITLotes");

            entity.Property(e => e.BatchNum).HasMaxLength(36);
            entity.Property(e => e.CantLote).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBmerma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBMerma");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBmermaLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBMermaLotes");

            entity.Property(e => e.BatchNum).HasMaxLength(36);
            entity.Property(e => e.CantLote).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBPT");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFilmtransferidoBptlote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FILMTransferidoBPTLotes");

            entity.Property(e => e.BatchNum).HasMaxLength(36);
            entity.Property(e => e.CantLote).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Quantity).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwFiltroDetProdBloqueado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FiltroDetProdBloqueado");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.DescProducto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.EstadoReserva)
                .HasMaxLength(42)
                .IsUnicode(false);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.NumPallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwFiltroTransferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FiltroTransferencia");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.LayoutShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_ShortDescription");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<CvtVwFoliosPedidosAsignacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FoliosPedidosAsignacion");

            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
        });

        modelBuilder.Entity<CvtVwFoliosTransferenciasAsignacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FoliosTransferenciasAsignacion");

            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<CvtVwFormularioEntregaEquipo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FormularioEntregaEquipos");

            entity.Property(e => e.Auriculares)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CableDatosUsb)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CableDatosUSB");
            entity.Property(e => e.CajaOriginal)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Carcasa)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CargadorBateria)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Cargo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CargoRecibe)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Equipo).HasMaxLength(255);
            entity.Property(e => e.EstadoRecibo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Entrega");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hasta");
            entity.Property(e => e.Idequipo).HasColumnName("IDEquipo");
            entity.Property(e => e.LaminaVidrio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.Nlinea).HasColumnName("NLinea");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NombreUsuarioRecibe)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Otro).IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .HasColumnName("RUT");
            entity.Property(e => e.Rutrecibe)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RUTRecibe");
            entity.Property(e => e.Sim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SIM");
            entity.Property(e => e.TarjetaMicroSd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TarjetaMicroSD");
            entity.Property(e => e.TarjetaSim)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TarjetaSIM");
            entity.Property(e => e.TipoDispo)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwGastoCamionesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_GastoCamionesPBI");

            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DetalleGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Item).IsUnicode(false);
            entity.Property(e => e.Nrendicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NRendicion");
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwHallazgo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Hallazgos");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(15)
                .HasColumnName("Cod_Proveedor");
            entity.Property(e => e.Familia).HasMaxLength(20);
            entity.Property(e => e.FechaHallazgo).HasColumnName("Fecha_Hallazgo");
            entity.Property(e => e.Indicador).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Linea)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Lotes).HasColumnName("LOTES");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.PesoProd).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Producido).HasColumnName("PRODUCIDO");
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.ProveedorMixto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoHallazgo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Hallazgo");
            entity.Property(e => e.Ton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Turno)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInfCodigosActivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_INF_CODIGOS_ACTIVOS");

            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(255)
                .HasColumnName("Nombre Equipo");
        });

        modelBuilder.Entity<CvtVwInfMantencionDatosEquipo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_INF_Mantencion_DatosEquipo");

            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(255)
                .HasColumnName("Nombre Equipo");
            entity.Property(e => e.Procesador).HasMaxLength(255);
            entity.Property(e => e.Ram)
                .HasMaxLength(255)
                .HasColumnName("RAM");
            entity.Property(e => e.Tipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.UsuarioEquipo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtVwInformeDetencione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InformeDetenciones");

            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Componente)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DetencionMotivo)
                .IsUnicode(false)
                .HasColumnName("Detencion_Motivo");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Estado)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.FechConfirma).HasColumnType("datetime");
            entity.Property(e => e.HrInicio)
                .HasPrecision(4)
                .HasColumnName("Hr_Inicio");
            entity.Property(e => e.HrTermino)
                .HasPrecision(4)
                .HasColumnName("Hr_Termino");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(100);
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Maquina)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Motivo_Cod");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Parte)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.ULinea)
                .HasMaxLength(20)
                .HasColumnName("U_Linea");
            entity.Property(e => e.UNumSala).HasColumnName("U_NumSala");
            entity.Property(e => e.UOperador)
                .HasMaxLength(50)
                .HasColumnName("U_Operador");
            entity.Property(e => e.UsuarioConfirma).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwInformeValorizadoTratosxAsistencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InformeValorizadoTratosxAsistencia");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.HoraInicio).HasColumnName("Hora_Inicio");
            entity.Property(e => e.HoraTermino).HasColumnName("Hora_Termino");
            entity.Property(e => e.HrsTurno).HasColumnName("Hrs_Turno");
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Trabajador)
                .HasMaxLength(101)
                .UseCollation("Chinese_PRC_CI_AS");
            entity.Property(e => e.ValorPagar).HasColumnName("Valor_Pagar");
        });

        modelBuilder.Entity<CvtVwInventarioCantidadDiferente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioCantidadDiferente");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.PackageOutDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_OutDate");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioCantidadDiferenteInf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioCantidadDiferenteInf");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioLoteDiferente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioLoteDiferente");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioPalletInventariadosEstadoDespachado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioPalletInventariadosEstadoDespachado");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioPalletVivosNoInventariado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioPalletVivosNoInventariados");

            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("NPallet");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwInventarioProductoDiferente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioProductoDiferente");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioResumenUsuarioProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioResumenUsuarioProducto");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioSiteDiferente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioSiteDiferente");

            entity.Property(e => e.BodegaPistoleo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaSistema)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProductoSistema)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProductoSistema)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackPistoleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RackSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwInventarioSumCantRepal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventarioSumCantRepal");

            entity.Property(e => e.PackageSsccOrigin)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC_Origin");
            entity.Property(e => e.PickingListDate)
                .HasColumnType("datetime")
                .HasColumnName("PickingList_Date");
        });

        modelBuilder.Entity<CvtVwInventariorRestaCantRepal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_InventariorRestaCantRepal");

            entity.Property(e => e.PackageSsccDestiny)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC_Destiny");
            entity.Property(e => e.PickingListDate)
                .HasColumnType("datetime")
                .HasColumnName("PickingList_Date");
        });

        modelBuilder.Entity<CvtVwLeeCuentaExistenciasxProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_LeeCuentaExistenciasxProducto");

            entity.Property(e => e.BalInvntAc).HasMaxLength(15);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CvtVwListadosEquiposTipo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ListadosEquiposTipo");

            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Codigo)
                .HasMaxLength(102)
                .IsUnicode(false);
            entity.Property(e => e.Equipo).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo).HasMaxLength(255);
        });

        modelBuilder.Entity<CvtVwLogRegistro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_LogRegistro");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.LogId).HasColumnName("Log_Id");
            entity.Property(e => e.NombreMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Menu");
            entity.Property(e => e.NombreSubMenu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_SubMenu");
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwOperadorPuestaMarchaPt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_OPERADOR_PUESTA_MARCHA_PT");

            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.IdMonPuestaMarchaMaq).HasColumnName("Id_MonPuestaMarcha_Maq");
            entity.Property(e => e.Operador1)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Operador2)
                .HasMaxLength(101)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwPackageArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Package_Article");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<CvtVwPalletProducidosEnvasado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PalletProducidosEnvasado");

            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwPalletProducidosKit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PalletProducidosKIT");

            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwPalletTransferidosDesdeMerma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PalletTransferidosDesdeMerma");

            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwPalletTransferidosDesdeMermaContenedora>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PalletTransferidosDesdeMermaContenedoras");

            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwPalletVendidoGrupoPorducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PalletVendidoGrupoPorducto");

            entity.Property(e => e.CantidadPallets).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.CtaCosto).HasMaxLength(15);
            entity.Property(e => e.GrupoProducto).HasColumnName("Grupo_Producto");
            entity.Property(e => e.NombreGrupoProducto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Grupo_Producto");
        });

        modelBuilder.Entity<CvtVwPedidoDetalleOrdenCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PedidoDetalleOrdenCarga");

            entity.Property(e => e.CantPedidoSap)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantPedidoSAP");
            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Fentrega)
                .HasColumnType("datetime")
                .HasColumnName("FEntrega");
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.TipoPallet)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TipoSoportante)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwPedidoOrdenCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PedidoOrdenCarga");

            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.DirDespacho).HasMaxLength(50);
            entity.Property(e => e.Fentrega)
                .HasColumnType("datetime")
                .HasColumnName("FEntrega");
            entity.Property(e => e.NumAtCard).HasMaxLength(100);
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwPedidoOrdenCargaListadoPendiente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PedidoOrdenCargaListadoPendientes");

            entity.Property(e => e.CantidadPallets).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.DirDespacho).HasMaxLength(50);
            entity.Property(e => e.Fentrega)
                .HasColumnType("datetime")
                .HasColumnName("FEntrega");
            entity.Property(e => e.PesoTotalPallets).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwPedidosDespacho>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Pedidos_Despacho");

            entity.Property(e => e.Cliente).HasMaxLength(100);
            entity.Property(e => e.DirDespacho).HasMaxLength(4000);
            entity.Property(e => e.FecDespacho).HasColumnType("datetime");
            entity.Property(e => e.FecDocto).HasColumnType("datetime");
            entity.Property(e => e.IndFacturado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Indvuelta).HasMaxLength(10);
            entity.Property(e => e.PedSap).HasColumnName("PedSAP");
            entity.Property(e => e.PesoPendiente).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.PesoTotal).HasColumnType("numeric(38, 11)");
        });

        modelBuilder.Entity<CvtVwPersonasTorniquete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PERSONAS_TORNIQUETE");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.Pin)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pin");
        });

        modelBuilder.Entity<CvtVwPorcentajePalletProducidosEnvasado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PorcentajePalletProducidosEnvasado");

            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(29, 13)");
        });

        modelBuilder.Entity<CvtVwPorcentajePalletProducidosKit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PorcentajePalletProducidosKIT");

            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(29, 13)");
        });

        modelBuilder.Entity<CvtVwPorcentajePalletTransferidosDesdeMerma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PorcentajePalletTransferidosDesdeMerma");

            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.CostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Porcentaje).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalPallets).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwPorcentajePalletTransferidosDesdeMermaContenedora>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PorcentajePalletTransferidosDesdeMermaContenedora");

            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.CostoVenta).HasMaxLength(15);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Porcentaje).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalPallets).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwPorcentajePalletVendidosPorGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PorcentajePalletVendidosPorGrupo");

            entity.Property(e => e.CtaCosto).HasMaxLength(15);
            entity.Property(e => e.GrupoProducto).HasColumnName("Grupo_Producto");
            entity.Property(e => e.NombreGrupoProducto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Grupo_Producto");
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.TotalPallets).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<CvtVwProduccionpbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_PRODUCCIONPBI");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.GolpesMin)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Operador)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.OrigenPrimario)
                .HasMaxLength(70)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ProducidoOf)
                .HasColumnType("numeric(30, 6)")
                .HasColumnName("ProducidoOF");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.RechazadoKilosCalidad).HasColumnType("decimal(38, 3)");
        });

        modelBuilder.Entity<CvtVwProductoAzucar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProductoAzucar");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProductoGarbanzo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProductoGarbanzo");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProductoLenteja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_productoLenteja");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProductoPoroto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProductoPorotos");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProductosArroz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProductosArroz");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProdutoArveja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProdutoArveja");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwProdutoPorotosNegro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ProdutoPorotosNegros");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwRamonestacionPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RAmonestacion_Personas");

            entity.Property(e => e.IdAmonestacion).HasColumnName("Id_Amonestacion");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.Pin)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pin");
        });

        modelBuilder.Entity<CvtVwRecepcionFilmPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RecepcionFilm_PBI");

            entity.Property(e => e.BodRecepcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Bod_Recepcion");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.DocumentoSap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Documento_SAP");
            entity.Property(e => e.Estado)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Recepcion");
            entity.Property(e => e.NDocumento).HasColumnName("N_documento");
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.NumDocSap).HasColumnName("Num_Doc_SAP");
            entity.Property(e => e.Proveedor).HasMaxLength(15);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Tipo_documento");
        });

        modelBuilder.Entity<CvtVwRecepcionPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Recepcion_PBI");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingreso");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_salida");
            entity.Property(e => e.GrueroAsignado).HasColumnName("Gruero_asignado");
            entity.Property(e => e.NDocumento).HasColumnName("N_Documento");
            entity.Property(e => e.NumSap).HasColumnName("NumSAP");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.TipoDescarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Tipo_Descarga");
            entity.Property(e => e.TipoDocSap)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("TipoDocSAP");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Tipo_Documento");
            entity.Property(e => e.TipoRecepcion)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Tipo_Recepcion");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwRechazoPncPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RechazoPNC_PBI");

            entity.Property(e => e.CantContenedoras)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Cant_Contenedoras");
            entity.Property(e => e.DestinoRechazo)
                .IsUnicode(false)
                .HasColumnName("Destino_Rechazo");
            entity.Property(e => e.Especificacion).IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdRechazoPt).HasColumnName("Id_RechazoPT");
            entity.Property(e => e.IdSubcategoriaNc).HasColumnName("Id_SubcategoriaNC");
            entity.Property(e => e.MotivoRechazo)
                .IsUnicode(false)
                .HasColumnName("Motivo_Rechazo");
            entity.Property(e => e.Peso)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("PESO");
            entity.Property(e => e.ProdName).HasMaxLength(200);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubCategoria).IsUnicode(false);
            entity.Property(e => e.TipoNc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TipoNC");
            entity.Property(e => e.UAbocador)
                .HasMaxLength(20)
                .HasColumnName("U_Abocador");
            entity.Property(e => e.UCantPtreal).HasColumnName("U_CantPTReal");
            entity.Property(e => e.ULinea)
                .HasMaxLength(20)
                .HasColumnName("U_Linea");
            entity.Property(e => e.UNumSala).HasColumnName("U_NumSala");
            entity.Property(e => e.UOperador)
                .HasMaxLength(50)
                .HasColumnName("U_Operador");
            entity.Property(e => e.UndxCaja)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("UNDxCaja");
        });

        modelBuilder.Entity<CvtVwRegistroAmonestacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RegistroAmonestacion");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.Amonestador).HasMaxLength(100);
            entity.Property(e => e.AreaTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cargo).HasMaxLength(100);
            entity.Property(e => e.Empresa).HasMaxLength(50);
            entity.Property(e => e.FechaAmonestacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Amonestacion");
            entity.Property(e => e.IdAmonestacion).HasColumnName("Id_Amonestacion");
            entity.Property(e => e.Incumplimiento).IsUnicode(false);
            entity.Property(e => e.Persona)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PlazoEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.Seguimiento).IsUnicode(false);
            entity.Property(e => e.TipoIncidencia).HasColumnName("Tipo_Incidencia");
            entity.Property(e => e.Verificacion).IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwReimpresionEtiqueta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ReimpresionEtiquetas");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwRepInsperccionvisualsaco>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_REP_INSPERCCIONVISUALSACOS");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.Calidad).HasMaxLength(100);
            entity.Property(e => e.FechaIngresoRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_ingresoRegistro");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.Humedad).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.IdEncargadaCalidad).HasColumnName("Id_EncargadaCalidad");
            entity.Property(e => e.IdInspeccionSacos).HasColumnName("Id_InspeccionSacos");
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.LotePt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LotePT");
            entity.Property(e => e.NaccionCorrectiva).HasColumnName("NAccionCorrectiva");
        });

        modelBuilder.Entity<CvtVwRepInsperccionvisualsacosAccionCorrectiva>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_REP_INSPERCCIONVISUALSACOS_AccionCorrectiva");

            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_registro");
        });

        modelBuilder.Entity<CvtVwReporInspeccionArroz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_REPOR_INSPECCION_ARROZ");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.Color).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegisro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.GranosDanados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosYesados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtArroz).HasColumnName("Id_InspeccionPT_Arroz");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwReportesTrazabalidadCalidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ReportesTrazabalidadCalidad");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Informe)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.LotePt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LotePT");
            entity.Property(e => e.Reporte)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenCamionesFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenCamionesFecha");

            entity.Property(e => e.Camion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
        });

        modelBuilder.Entity<CvtVwResumenConsumoCombustiblePorMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoCombustiblePorMes");

            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalConsumo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalLitros).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<CvtVwResumenConsumoCombustiblePorPropietario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoCombustiblePorPropietario");

            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalConsumo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalLitros).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<CvtVwResumenConsumoFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoFilm");

            entity.Property(e => e.Bodega)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CantidadFilmConsumir).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CantidadFilmTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.CtaExistenciaFilm).HasMaxLength(15);
            entity.Property(e => e.Grupo).HasMaxLength(150);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.TotalPallets).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<CvtVwResumenConsumoFilmCv100>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoFilmCV100");

            entity.Property(e => e.CantidadFilmConsumir).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CantidadFilmTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.CtaExistenciaFilm).HasMaxLength(15);
            entity.Property(e => e.Grupo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalPallets).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<CvtVwResumenConsumoFilmCv200>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoFilmCV200");

            entity.Property(e => e.CantidadFilmConsumir).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CantidadFilmTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.CtaExistenciaFilm).HasMaxLength(15);
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.Porcentaje).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalPallets).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<CvtVwResumenConsumoFilmCv300>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoFilmCV300");

            entity.Property(e => e.CantidadFilmConsumir).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CantidadFilmTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.CtaExistenciaFilm).HasMaxLength(15);
            entity.Property(e => e.Grupo).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(29, 13)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenConsumoFilmCv301>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenConsumoFilmCV301");

            entity.Property(e => e.CantidadFilmConsumir).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CantidadFilmTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.CtaCostoVenta).HasMaxLength(15);
            entity.Property(e => e.CtaExistenciaFilm).HasMaxLength(15);
            entity.Property(e => e.Grupo).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(29, 13)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenDetencione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenDetenciones");

            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
            entity.Property(e => e.DetencionMotivo)
                .IsUnicode(false)
                .HasColumnName("Detencion_Motivo");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(100);
            entity.Property(e => e.OfId).HasColumnName("OF_Id");
            entity.Property(e => e.TipoDetencion)
                .HasMaxLength(14)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenDetencionesCategorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenDetencionesCategoria");

            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
            entity.Property(e => e.Tipo)
                .HasMaxLength(14)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenMensualCamion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenMensualCamion");

            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenMensualCategoriaCamion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenMensualCategoriaCamion");

            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenMensualGastosCamion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenMensualGastosCamion");

            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetalleGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwResumenProduccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenProduccion");

            entity.Property(e => e.CantPtreal).HasColumnName("CantPTReal");
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.DetencionMotivo)
                .IsUnicode(false)
                .HasColumnName("Detencion_Motivo");
            entity.Property(e => e.Familia).HasMaxLength(20);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Linea).HasMaxLength(20);
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Meta).HasColumnName("META");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.PorcCumplimiento)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("PORC_CUMPLIMIENTO");
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.Turno).HasMaxLength(10);
        });

        modelBuilder.Entity<CvtVwResumenTotalGastoCamionPorDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_ResumenTotalGastoCamionPorDetalle");

            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetalleGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwRotacionBodegaRecuperacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RotacionBodegaRecuperacion");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Costo).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.GrupoProducto).HasMaxLength(100);
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrigenDestino)
                .HasMaxLength(8)
                .HasColumnName("Origen_Destino");
            entity.Property(e => e.Peso).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.ProcesoOrigen)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwRotacionInventarioPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Rotacion_Inventario_PBI");

            entity.Property(e => e.Apcmact)
                .HasMaxLength(15)
                .HasColumnName("APCMAct");
            entity.Property(e => e.Apcmeuact)
                .HasMaxLength(15)
                .HasColumnName("APCMEUAct");
            entity.Property(e => e.ApcmfrnAct)
                .HasMaxLength(15)
                .HasColumnName("APCMFrnAct");
            entity.Property(e => e.Arcmact)
                .HasMaxLength(15)
                .HasColumnName("ARCMAct");
            entity.Property(e => e.Arcmeuact)
                .HasMaxLength(15)
                .HasColumnName("ARCMEUAct");
            entity.Property(e => e.ArcmexpAct)
                .HasMaxLength(15)
                .HasColumnName("ARCMExpAct");
            entity.Property(e => e.ArcmfrnAct)
                .HasMaxLength(15)
                .HasColumnName("ARCMFrnAct");
            entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.BalInvntAc).HasMaxLength(15);
            entity.Property(e => e.BalanceAcc).HasMaxLength(15);
            entity.Property(e => e.Cantidad).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.Cnjpman)
                .HasMaxLength(14)
                .HasColumnName("CNJPMan");
            entity.Property(e => e.CodigoArticulo).HasMaxLength(50);
            entity.Property(e => e.CompConta).HasColumnName("Comp_Conta");
            entity.Property(e => e.ComprometidoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Consig).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostRvlAct).HasMaxLength(15);
            entity.Property(e => e.Costo).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.CostoProm).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CostoTotal).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.CostoUltCompra).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Counted).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.CstOffsAct).HasMaxLength(15);
            entity.Property(e => e.DecreasAc).HasMaxLength(15);
            entity.Property(e => e.DecresGlAc).HasMaxLength(15);
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.DftBinEnfd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmbalajePorUm)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("EmbalajePorUM");
            entity.Property(e => e.EuexpensAc)
                .HasMaxLength(15)
                .HasColumnName("EUExpensAc");
            entity.Property(e => e.EurevenuAc)
                .HasMaxLength(15)
                .HasColumnName("EURevenuAc");
            entity.Property(e => e.ExchangeAc).HasMaxLength(15);
            entity.Property(e => e.ExmptIncom).HasMaxLength(15);
            entity.Property(e => e.ExpClrAct).HasMaxLength(15);
            entity.Property(e => e.ExpOfstAct).HasMaxLength(15);
            entity.Property(e => e.ExpensesAc).HasMaxLength(15);
            entity.Property(e => e.Expr1).HasMaxLength(200);
            entity.Property(e => e.FCont)
                .HasColumnType("datetime")
                .HasColumnName("F_Cont");
            entity.Property(e => e.FVenc)
                .HasColumnType("datetime")
                .HasColumnName("F_Venc");
            entity.Property(e => e.FrExpensAc).HasMaxLength(15);
            entity.Property(e => e.FrRevenuAc).HasMaxLength(15);
            entity.Property(e => e.FreeChrgPu)
                .HasMaxLength(15)
                .HasColumnName("FreeChrgPU");
            entity.Property(e => e.FreeChrgSa)
                .HasMaxLength(15)
                .HasColumnName("FreeChrgSA");
            entity.Property(e => e.Freezed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoArticulo).HasMaxLength(100);
            entity.Property(e => e.IncreasAc).HasMaxLength(15);
            entity.Property(e => e.IncresGlAc).HasMaxLength(15);
            entity.Property(e => e.IndEscala)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Indicador).HasMaxLength(50);
            entity.Property(e => e.IsCommited).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Locked)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LogInstanc).HasColumnName("logInstanc");
            entity.Property(e => e.Marca).HasMaxLength(20);
            entity.Property(e => e.MargenBruto).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.MargenReal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.MaxStock).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.MinOrder).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.MinStock).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.NegStckAct).HasMaxLength(15);
            entity.Property(e => e.NumDocRef)
                .HasMaxLength(18)
                .HasColumnName("NumDocREF");
            entity.Property(e => e.Object).HasMaxLength(20);
            entity.Property(e => e.OnHand).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.OnOrder).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.PareturnAc)
                .HasMaxLength(15)
                .HasColumnName("PAReturnAc");
            entity.Property(e => e.PesoTotal).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.PriceDifAc).HasMaxLength(15);
            entity.Property(e => e.PurBalAct).HasMaxLength(15);
            entity.Property(e => e.PurchOfsAc).HasMaxLength(15);
            entity.Property(e => e.PurchaseAc).HasMaxLength(15);
            entity.Property(e => e.ReturnAc).HasMaxLength(15);
            entity.Property(e => e.RevRetAct).HasMaxLength(15);
            entity.Property(e => e.RevenuesAc).HasMaxLength(15);
            entity.Property(e => e.SaleCostAc).HasMaxLength(15);
            entity.Property(e => e.ShpdGdsAct).HasMaxLength(15);
            entity.Property(e => e.SolicitadoVentas).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.StkInTnAct).HasMaxLength(15);
            entity.Property(e => e.StkOffsAct).HasMaxLength(15);
            entity.Property(e => e.Stock).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.StockOffst).HasMaxLength(15);
            entity.Property(e => e.StockValue).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.StokRvlAct).HasMaxLength(15);
            entity.Property(e => e.Tipo)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoDocRef).HasMaxLength(100);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoMarca)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TotalComision).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.TotalLinea).HasColumnType("numeric(21, 6)");
            entity.Property(e => e.TotalSinRapel)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Total_SinRapel");
            entity.Property(e => e.TransferAc).HasMaxLength(15);
            entity.Property(e => e.ULockFg).HasColumnName("U_Lock_fg");
            entity.Property(e => e.UmEmbalaje)
                .HasMaxLength(30)
                .HasColumnName("Um_Embalaje");
            entity.Property(e => e.UmVendida)
                .HasMaxLength(100)
                .HasColumnName("UM_Vendida");
            entity.Property(e => e.UnidadesVendidas).HasColumnType("numeric(38, 11)");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
            entity.Property(e => e.UserSign2).HasColumnName("userSign2");
            entity.Property(e => e.UtilidadBruta).HasColumnType("numeric(38, 9)");
            entity.Property(e => e.UtilidadRc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("UtilidadRC");
            entity.Property(e => e.ValorProductoTransporte).HasColumnType("numeric(38, 14)");
            entity.Property(e => e.VarianceAc).HasMaxLength(15);
            entity.Property(e => e.VatRevAct).HasMaxLength(15);
            entity.Property(e => e.WasCounted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WhIcenAct)
                .HasMaxLength(15)
                .HasColumnName("WhICenAct");
            entity.Property(e => e.WhOcenAct)
                .HasMaxLength(15)
                .HasColumnName("WhOCenAct");
            entity.Property(e => e.WhsCode).HasMaxLength(8);
            entity.Property(e => e.WipAcct).HasMaxLength(15);
            entity.Property(e => e.WipOffset).HasMaxLength(15);
            entity.Property(e => e.WipVarAcct).HasMaxLength(15);
        });

        modelBuilder.Entity<CvtVwRptDatosequipo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RPT_DATOSEQUIPOS");

            entity.Property(e => e.Causa).IsUnicode(false);
            entity.Property(e => e.CodActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodAf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_AF");
            entity.Property(e => e.Dispositivo).HasMaxLength(255);
            entity.Property(e => e.Falla).IsUnicode(false);
            entity.Property(e => e.FechaMantencion).HasColumnType("datetime");
            entity.Property(e => e.IdMantInfEnc).HasColumnName("ID_MantInfEnc");
            entity.Property(e => e.Marca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo).HasMaxLength(255);
            entity.Property(e => e.NombreEquipo)
                .HasMaxLength(255)
                .HasColumnName("Nombre Equipo");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Procesador).HasMaxLength(255);
            entity.Property(e => e.Ram)
                .HasMaxLength(255)
                .HasColumnName("RAM");
            entity.Property(e => e.Solucion).IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoMantencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioEquipo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CvtVwRptMantencioninformatica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_RPT_MANTENCIONINFORMATICA");

            entity.Property(e => e.Causa).IsUnicode(false);
            entity.Property(e => e.CodActivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetalleMantencion).IsUnicode(false);
            entity.Property(e => e.Falla).IsUnicode(false);
            entity.Property(e => e.FechaMantencion).HasColumnType("datetime");
            entity.Property(e => e.IdMantencion).HasColumnName("idMantencion");
            entity.Property(e => e.Mantencion)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Solucion).IsUnicode(false);
            entity.Property(e => e.TipoMantencion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwSolicitudTransferenciaPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_SolicitudTransferencia_PBI");

            entity.Property(e => e.BodegaDestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Bodega_destino");
            entity.Property(e => e.BodegaOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Bodega_origen");
            entity.Property(e => e.Estado)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.NumeroOf).HasColumnName("NumeroOF");
        });

        modelBuilder.Entity<CvtVwStockDisponibleBajadaPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_STOCK_DISPONIBLE_BAJADA_PEDIDO");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.EstadoLote)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Estado_Lote");
            entity.Property(e => e.Fproduccion).HasColumnName("FProduccion");
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.Sscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("SSCC");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtVwTotalDetencionesOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TotalDetencionesOF");

            entity.Property(e => e.OfId).HasColumnName("OF_Id");
            entity.Property(e => e.Tipo)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.TipoId).HasColumnName("TipoID");
        });

        modelBuilder.Entity<CvtVwTotalPalletVendidoGrupoPorducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TotalPalletVendidoGrupoPorducto");

            entity.Property(e => e.TotalPallets).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<CvtVwTranferSaplote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TranferSAPLotes");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<CvtVwTranferenciaSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TranferenciaSAP");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<CvtVwTransferenciaCv410>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TransferenciaCV410");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Defecto).IsUnicode(false);
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Producto).HasMaxLength(200);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
        });

        modelBuilder.Entity<CvtVwTransferenciaFilmPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TransferenciaFilm_PBI");

            entity.Property(e => e.BodDestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Bod_Destino");
            entity.Property(e => e.BodOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Bod_Origen");
            entity.Property(e => e.EntidadMot)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Entidad_Mot");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");
            entity.Property(e => e.FechaTransferencia).HasColumnType("datetime");
            entity.Property(e => e.Nsolicitud).HasColumnName("NSolicitud");
            entity.Property(e => e.NumeroOf).HasColumnName("NumeroOF");
            entity.Property(e => e.UsuarioEnvia)
                .HasMaxLength(100)
                .HasColumnName("Usuario_envia");
            entity.Property(e => e.UsuarioRecep)
                .HasMaxLength(100)
                .HasColumnName("Usuario_Recep");
        });

        modelBuilder.Entity<CvtVwTransferenciasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TransferenciasDetalle");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LayoutIdActual).HasColumnName("Layout_Id_Actual");
            entity.Property(e => e.LayoutShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Layout_ShortDescription");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
            entity.Property(e => e.TaskId).HasColumnName("Task_Id");
            entity.Property(e => e.TaskQuantityPicked).HasColumnName("Task_Quantity_Picked");
            entity.Property(e => e.TaskQuantityToPick).HasColumnName("Task_QuantityToPick");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<CvtVwTransferenciasRechazada>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TransferenciasRechazadas");

            entity.Property(e => e.ArticleProviderCodClient)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_CodClient");
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.RechazoId).HasColumnName("Rechazo_ID");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwTransformacionesPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_Transformaciones_PBI");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Entidad)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ProcRelacionado).IsUnicode(false);
            entity.Property(e => e.StaffUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Staff_UserName");
            entity.Property(e => e.SubTipo)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtVwTrazaBalanceMasaAnalizaLotesMp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TrazaBalanceMasaAnalizaLotesMP");

            entity.Property(e => e.CantidadConsumida).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Clave).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.LoteConsumo).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwTrazaBalanceMasaAnalizaLotesPt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TrazaBalanceMasaAnalizaLotesPT");

            entity.Property(e => e.CantidadConsumida).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Clave).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.LoteConsumo).HasMaxLength(20);
        });

        modelBuilder.Entity<CvtVwTrazaBalanceMasaAnalizaLotesRep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TrazaBalanceMasaAnalizaLotesREP");

            entity.Property(e => e.CantidadConsimida).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Clave).HasMaxLength(20);
            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.LoteConsumo).HasMaxLength(20);
            entity.Property(e => e.Of)
                .HasMaxLength(20)
                .HasColumnName("OF");
        });

        modelBuilder.Entity<CvtZonaHigiene>(entity =>
        {
            entity.HasKey(e => e.IdZonaHigiene);

            entity.ToTable("CVT_ZonaHigiene");

            entity.Property(e => e.IdZonaHigiene).HasColumnName("Id_ZonaHigiene");
            entity.Property(e => e.ZonaHigiene)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CvtviewPalletsRecSinPosicionar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVTView_PalletsRecSinPosicionar");

            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.DescProducto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaIngreso)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Fecha Ingreso");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Pallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Sitio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtviewProduccionOfabierta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVTView_ProduccionOFAbiertas");

            entity.Property(e => e.BatchNum).HasMaxLength(36);
            entity.Property(e => e.CantPallet).HasMaxLength(4000);
            entity.Property(e => e.CantPlanificada).HasMaxLength(4000);
            entity.Property(e => e.CantidadRecibo).HasMaxLength(4000);
            entity.Property(e => e.CodProducto).HasMaxLength(20);
            entity.Property(e => e.CreaciónOf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CreaciónOF");
            entity.Property(e => e.DescProducto).HasMaxLength(100);
            entity.Property(e => e.EstadoPallet)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaReciboPt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FechaReciboPT");
            entity.Property(e => e.KilosRecibidos).HasColumnType("numeric(22, 6)");
            entity.Property(e => e.NumOf).HasColumnName("NumOF");
            entity.Property(e => e.Pallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Ubicación)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<CvtviewTransaccionesWm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVTView_TransaccionesWMS");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.DescProducto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.DescUbicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Dia).HasMaxLength(30);
            entity.Property(e => e.FecIngreso).HasColumnType("datetime");
            entity.Property(e => e.FecSalida).HasColumnType("datetime");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(304)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_Description");
            entity.Property(e => e.StaffName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Staff_Name");
            entity.Property(e => e.Trx)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Warehouse_Description");
        });

        modelBuilder.Entity<DatoVersionesAppxam>(entity =>
        {
            entity.HasKey(e => e.IdVersion);

            entity.ToTable("DatoVersionesAPPXAM");

            entity.Property(e => e.IdVersion).HasColumnName("id_Version");
            entity.Property(e => e.CodVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreApp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NombreAPP");
        });

        modelBuilder.Entity<DimFecha>(entity =>
        {
            entity.HasKey(e => e.FechaId);

            entity.ToTable("DIM_FECHA");

            entity.Property(e => e.FechaId).HasColumnName("Fecha_ID");
        });

        modelBuilder.Entity<EstadisticaVenta>(entity =>
        {
            entity.ToTable("Estadistica_Ventas");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Canal)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Cliente");
            entity.Property(e => e.CompContable).HasColumnName("Comp_Contable");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoFinal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Costo_Final");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.DireccionEnvio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Direccion_Envio");
            entity.Property(e => e.FechaContab)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Contab");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Venc");
            entity.Property(e => e.GrupoProducto).HasColumnName("Grupo_Producto");
            entity.Property(e => e.Indicador)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NombreGrupoProducto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Grupo_Producto");
            entity.Property(e => e.NumInterno).HasColumnName("Num_Interno");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioSinRapel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Sin_Rapel");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Precio_Unitario");
            entity.Property(e => e.ProcentajeRapel)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Procentaje_RAPEL");
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Razon_Social");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMarca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Tipo_Marca");
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Tipo_Negocio");
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Tipo_Venta");
            entity.Property(e => e.TotalLinea)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Total_Linea");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FallasGruaPbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FallasGruaPBI");

            entity.Property(e => e.ChoferMomentoFalla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.EmpresaReclamo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EstadoGrua)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFalla).HasColumnType("datetime");
            entity.Property(e => e.FechaReparacion).HasColumnType("datetime");
            entity.Property(e => e.GruaNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Grua_Numero");
            entity.Property(e => e.Horometro).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Resolucion).IsUnicode(false);
            entity.Property(e => e.RfgId).HasColumnName("RFG_ID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoFalla)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCierre)
                .HasMaxLength(100)
                .HasColumnName("Usuario_Cierre");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(100)
                .HasColumnName("Usuario_Creacion");
        });

        modelBuilder.Entity<ImpresionEtiqueta>(entity =>
        {
            entity.HasKey(e => e.IdImpresion);

            entity.ToTable("Impresion_Etiquetas");

            entity.Property(e => e.IdImpresion).HasColumnName("ID_Impresion");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
        });

        modelBuilder.Entity<ItemsClasificado>(entity =>
        {
            entity.ToTable("Items_Clasificados");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Centro_Costo");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GastoItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gasto_Item");
            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogSistemaCvt>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("LOG_SistemaCVT");

            entity.Property(e => e.LogId).HasColumnName("Log_Id");
            entity.Property(e => e.Entidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntidadId).HasColumnName("Entidad_Id");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Id");
            entity.Property(e => e.ValorAntiguo)
                .IsUnicode(false)
                .HasColumnName("Valor_Antiguo");
            entity.Property(e => e.ValorNuevo)
                .IsUnicode(false)
                .HasColumnName("Valor_Nuevo");
        });

        modelBuilder.Entity<MmetroLogUltimoPrecioCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdRegistroPrecio, e.FechaRegistro }).HasName("PK_MMetro_LogUltimoPrecioCompra_1");

            entity.ToTable("MMetro_LogUltimoPrecioCompra");

            entity.Property(e => e.IdRegistroPrecio).HasColumnName("id_RegistroPrecio");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Producto).IsUnicode(false);
        });

        modelBuilder.Entity<MmetroUltimoPrecioCompra>(entity =>
        {
            entity.HasKey(e => e.IdRegistroPrecio).HasName("PK_MMetro_UltimoPrecioCompra_1");

            entity.ToTable("MMetro_UltimoPrecioCompra");

            entity.Property(e => e.IdRegistroPrecio).HasColumnName("id_RegistroPrecio");
            entity.Property(e => e.Competencia).IsUnicode(false);
            entity.Property(e => e.FechaUltimoRegistro).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductoNoRegistrado).IsUnicode(false);
            entity.Property(e => e.Proveedor).IsUnicode(false);
        });

        modelBuilder.Entity<OfModificada>(entity =>
        {
            entity.HasKey(e => e.OrdenFabricacion);

            entity.ToTable("OF_Modificadas");

            entity.Property(e => e.OrdenFabricacion)
                .ValueGeneratedNever()
                .HasColumnName("Orden_Fabricacion");
        });

        modelBuilder.Entity<PresupuestoVentasCantidad>(entity =>
        {
            entity.ToTable("Presupuesto_Ventas_Cantidad");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PresupuestoVentasMonedum>(entity =>
        {
            entity.ToTable("Presupuesto_Ventas_moneda");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodVendedor).HasColumnName("Cod_Vendedor");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegistrosJornadaPractica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RegistrosJornadaPractica");

            entity.Property(e => e.Ingreso).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Rut)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("RUT");
            entity.Property(e => e.Salida).HasColumnType("datetime");
        });

        modelBuilder.Entity<SmmMailUsuariosMayoristum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_MAIL_USUARIOS_MAYORISTA");

            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
        });

        modelBuilder.Entity<TmpBalanceDeMasaMp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_BalanceDeMasaMP");

            entity.Property(e => e.Barrido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CantLoteTrazado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CantidadDeOf)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("CantidadDeOF");
            entity.Property(e => e.ConsOtrosLotes)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.DifConsumo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.FechaOf)
                .HasColumnType("datetime")
                .HasColumnName("FechaOF");
            entity.Property(e => e.LoteCons)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.NumOf).HasDefaultValue(0);
            entity.Property(e => e.PorcProdTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.ProducidoReal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.RepConsumido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Reproceso)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.SobreDosificado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.TotalConsumido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
            entity.Property(e => e.TotalProducido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<TmpTrazaConsumiblesOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_Traza_ConsumiblesOF");

            entity.Property(e => e.AutoIncrement).ValueGeneratedOnAdd();
            entity.Property(e => e.CantConsumidaTot).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CantConsxLote).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Clave)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.LoteConsumo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.NumOf).HasColumnName("Num_OF");
            entity.Property(e => e.TipoProd)
                .HasMaxLength(10)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.Area).HasMaxLength(100);
            entity.Property(e => e.Clave).HasMaxLength(15);
            entity.Property(e => e.Depto).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.UsuarioSistema).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewResumenEstadisticasVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ResumenEstadisticasVentas");

            entity.Property(e => e.Canal)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Clp)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("CLP");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Cliente");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.GrupoProducto).HasColumnName("Grupo_Producto");
            entity.Property(e => e.Marca)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NombreGrupoProducto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nombre_Grupo_Producto");
            entity.Property(e => e.Producto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Psr)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("PSR");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Razon_Social");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Tipo_Negocio");
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Tipo_Venta");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VistaInventarioOctubre2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vista_Inventario_Octubre2017");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Contenedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ConteoCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaElab)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.FechaVcto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.IdUbicCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Numserie)
                .HasMaxLength(80)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("NUMSerie");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<VwArchivosEnvTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Archivos_Env_Ticket");

            entity.Property(e => e.Extencion).HasMaxLength(50);
            entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Ruta).IsUnicode(false);
        });

        modelBuilder.Entity<VwAreaTrabajo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AREA_TRABAJO");

            entity.Property(e => e.IdArea)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Area");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBobinasRegistradasEnvasado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_BOBINAS_REGISTRADAS_ENVASADO");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.MateriaPrima).IsUnicode(false);
            entity.Property(e => e.MotivoMerma).IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Operador)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.OrigenMerma).IsUnicode(false);
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.TipoFilm)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCantBobinasTransferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CANT_BOBINAS_TRANSFERENCIA");

            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
        });

        modelBuilder.Entity<VwCorreosRechazoTranferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Correos_Rechazo_tranferencia");

            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.StaffId).HasColumnName("Staff_Id");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<VwCvtAgendamantencionEncabezado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_AGENDAMANTENCION_ENCABEZADO");

            entity.Property(e => e.CantHoras).HasColumnName("Cant_Horas");
            entity.Property(e => e.Datos).UseCollation("Chinese_PRC_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaLimite).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .UseCollation("Chinese_PRC_CI_AS")
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("Chinese_PRC_CI_AS");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.TipoMantencion).IsUnicode(false);
        });

        modelBuilder.Entity<VwCvtAgendamantencionEncabezadoTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_AGENDAMANTENCION_ENCABEZADO_test");

            entity.Property(e => e.CantHoras).HasColumnName("Cant_Horas");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaLimite).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.TipoMantencion).IsUnicode(false);
        });

        modelBuilder.Entity<VwCvtLogtranstraePesoTotalProd2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_LOGTRANSTraePesoTotalProd2");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.Peso).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Volumen).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<VwCvtMaquinasPartesComponente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_MaquinasPartesComponentes");

            entity.Property(e => e.CodComponente).HasColumnName("Cod_Componente");
            entity.Property(e => e.CodMaquina).HasColumnName("Cod_Maquina");
            entity.Property(e => e.CodParte).HasColumnName("Cod_Parte");
            entity.Property(e => e.Componente)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Maquina)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Parte)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCvtPersonalControlPt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_PersonalControlPT");

            entity.Property(e => e.IdPersonal)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Personal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<VwCvtStockLotesWmsSapxBodegaVsinventarioTest2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CVT_StockLotesWmsSapxBodegaVSInventarioTEST2");

            entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CantidadSap).HasColumnName("CantidadSAP");
            entity.Property(e => e.CantidadWms).HasColumnName("CantidadWMS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Cuenta).HasMaxLength(15);
            entity.Property(e => e.Grupo).HasMaxLength(20);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.NombreCuenta).HasMaxLength(100);
            entity.Property(e => e.Producto).UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<VwDatosBobinasFilmProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DATOS_BOBINAS_FILM_PROD");

            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.FechaBajada).HasColumnType("datetime");
            entity.Property(e => e.FechaProduc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Produc");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Venc");
            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoBrutoInicial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reserve_Quantity");
        });

        modelBuilder.Entity<VwDatosRptControlPesoProductoPaletizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Datos_Rpt_ControlPeso_ProductoPaletizado");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.CodProducto).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Lote).IsUnicode(false);
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.Observaciones).IsUnicode(false);
            entity.Property(e => e.PesoPallet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Sscc).HasColumnName("SSCC");
            entity.Property(e => e.StaffName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Staff_Name");
        });

        modelBuilder.Entity<VwDetalleRecepcionFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DetalleRecepcion_Film");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.FechaRecep).HasColumnType("datetime");
            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.NumeroDocSap).HasColumnName("NumeroDocSAp");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor).IsUnicode(false);
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<VwDetalleRecepcionFilmLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DetalleRecepcion_Film_lotes");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<VwDevolDetalleExportFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DEVOL_DETALLE_EXPORT_FILM");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescProducto).IsUnicode(false);
            entity.Property(e => e.FolioDevol).HasColumnName("Folio_Devol");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<VwDevolucionDetailSyncFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DevolucionDetailSync_Film");

            entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto).IsUnicode(false);
            entity.Property(e => e.IdDevoFilm).HasColumnName("id_DevoFilm");
            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<VwDevolucionDetailSyncLoteFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DevolucionDetailSyncLote_Film");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdDevoFilm).HasColumnName("id_DevoFilm");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwExcelResumenTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ExcelResumenTickets");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria).IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.EncargadoTicket).HasMaxLength(100);
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.FechaTomaTicket).HasColumnType("datetime");
            entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
            entity.Property(e => e.TipoProblema).IsUnicode(false);
            entity.Property(e => e.UsuarioSolicitante).HasMaxLength(100);
        });

        modelBuilder.Entity<VwExpedicionFilmDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_EXPEDICION_FILM_DETALLE");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpFilmDateIn)
                .HasColumnType("datetime")
                .HasColumnName("ExpFilm_DateIn");
            entity.Property(e => e.ExpFilmId).HasColumnName("ExpFilm_id");
            entity.Property(e => e.ExpFilmNote)
                .IsUnicode(false)
                .HasColumnName("ExpFilm_Note");
            entity.Property(e => e.ExpFilmNumDocSap).HasColumnName("ExpFilm_NumDocSap");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiteShortDescription)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Site_ShortDescription");
        });

        modelBuilder.Entity<VwExpedicionFilmDetalleLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_EXPEDICION_FILM_DETALLE_LOTE");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ExpFilmId).HasColumnName("ExpFilm_id");
            entity.Property(e => e.ExpFilmLote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExpFilm_Lote");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwFamiliaProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FAMILIA_PROD");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItmsGrpNam).HasMaxLength(20);
        });

        modelBuilder.Entity<VwFilmConReserva>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FilmConReserva");

            entity.Property(e => e.Estado)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.Operacion)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reserve_Quantity");
        });

        modelBuilder.Entity<VwFilmTransferidoOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FILM_TransferidoOF");

            entity.Property(e => e.Bdestino)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("BDestino");
            entity.Property(e => e.Borigen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("BOrigen");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroOf).HasColumnName("NumeroOF");
        });

        modelBuilder.Entity<VwFiltroTransferenciaFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FILTRO_TRANSFERENCIA_FILM");

            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwFoliosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FOLIOS_INVENTARIOS");

            entity.Property(e => e.InventarioId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Inventario_Id");
        });

        modelBuilder.Entity<VwFullPersonalTorniquete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FULL_PERSONAL_TORNIQUETE");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.Pin)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pin");
        });

        modelBuilder.Entity<VwFullstockCv200>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FULLSTOCK_CV200");

            entity.Property(e => e.ArticleProviderDescription)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.PrecioPromedio).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Sociedad)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Valorizado).HasColumnType("numeric(30, 6)");
        });

        modelBuilder.Entity<VwFullstockCvtSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FULLSTOCK_CVT_SMM");

            entity.Property(e => e.ArticleProviderDescription).HasColumnName("ArticleProvider_Description");
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodCliente).HasMaxLength(128);
            entity.Property(e => e.Familia).HasMaxLength(50);
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.PrecioPromedio).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Sociedad)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Valorizado).HasColumnType("numeric(38, 6)");
        });

        modelBuilder.Entity<VwGrupoProductosAnalisisCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GRUPO_PRODUCTOS_ANALISIS_COMPRA");

            entity.Property(e => e.Producto).HasMaxLength(20);
        });

        modelBuilder.Entity<VwGrupoProveedorAnalisisCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GRUPO_PROVEEDOR_ANALISIS_COMPRA");

            entity.Property(e => e.Proveedor).HasMaxLength(20);
        });

        modelBuilder.Entity<VwInfReportEntregaPeriferico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_INF_ReportEntregaPeriferico");

            entity.Property(e => e.Cargo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.FechaEntrega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEntPeriferico).HasColumnName("Id_EntPeriferico");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(101)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RunUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoEntrega)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwInfStockFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_INF_STOCK_FILM");

            entity.Property(e => e.BodegaActual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.BodegaRecepcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProveedor).IsUnicode(false);
            entity.Property(e => e.FechaProduc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Produc");
            entity.Property(e => e.FechaRecep).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Venc");
            entity.Property(e => e.FolioRecepFilm).HasColumnName("FolioRecep_Film");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.NumeroDocSap).HasColumnName("NumeroDocSAp");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
        });

        modelBuilder.Entity<VwListaUsuariosVerificadore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Lista_Usuarios_Verificadores");

            entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.RutaFirma).IsUnicode(false);
            entity.Property(e => e.UsuarioSistema).HasMaxLength(20);
        });

        modelBuilder.Entity<VwMaxcantidadregistrosticket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MAXCANTIDADREGISTROSTICKET");

            entity.Property(e => e.Ultimoticket).HasColumnName("ULTIMOTICKET");
        });

        modelBuilder.Entity<VwMenuxamarin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MENUXAMARIN");

            entity.Property(e => e.IdPerfil).HasColumnName("idPerfil");
            entity.Property(e => e.TituloMenu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwOperadorVsUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_OperadorVsUsuario");

            entity.Property(e => e.IdPersonal).HasColumnName("Id_Personal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPermisoTrabajoSeguroTotalAst>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PermisoTrabajoSeguro_TotalAST");

            entity.Property(e => e.IdPts).HasColumnName("Id_Pts");
            entity.Property(e => e.TotalAst).HasColumnName("TotalAST");
        });

        modelBuilder.Entity<VwPersonal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PERSONAL");

            entity.Property(e => e.IdPersonal)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Personal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(101)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPersonalDesvinculadoTorniquete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Personal_Desvinculado_Torniquete");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FechaDesvinculacion).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Razon)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Run)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<VwPesonetoinicial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PESONETOINICIAL");

            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoNetoInicial).HasColumnType("decimal(19, 4)");
        });

        modelBuilder.Entity<VwPrcComisionVendedor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PRC_COMISION_VENDEDOR");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrcComi).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.TipoComision)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProductoInvenarioFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PRODUCTO_INVENARIO_FILM");

            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwProductosFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PRODUCTOS_FILM");

            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Producto).HasMaxLength(100);
        });

        modelBuilder.Entity<VwRegCompraUreaUltimoPrecioLitro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Reg_CompraUrea_UltimoPrecioLitro");
        });

        modelBuilder.Entity<VwRegistroPrecEntrEjec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RegistroPrecEntrEjec");

            entity.Property(e => e.DifCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DifCambioAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");
            entity.Property(e => e.Oc).HasColumnName("OC");
            entity.Property(e => e.PesoEntrada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PesoOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PesoOC");
            entity.Property(e => e.ValorDolarHoy).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorDolarOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorDolarOC");
            entity.Property(e => e.ValorOc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorOC");
            entity.Property(e => e.ValorOchoy)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ValorOCHoy");
        });

        modelBuilder.Entity<VwRepInspPtarroz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REP_INSP_PTARROZ");

            entity.Property(e => e.CumplGranosPartidos)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumplSemObjetables)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumpleColor)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumpleGranManch)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumpleGranosCascara)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumpleGranosYesoVerd)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumpleMatExtrana)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwRepInspPtazucar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REP_INSP_PTAZUCAR");

            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.Impuresas)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatExtraAnim)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtrana)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
        });

        modelBuilder.Entity<VwRepInspPtlegunbre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REP_INSP_PTLEGUNBRES");

            entity.Property(e => e.CumplColor)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumplGranDanados)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumplGranEnterosArrugados)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CumplGranManchados)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateExtrana)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
        });

        modelBuilder.Entity<VwRepInspvisualSaco>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REP_INSPVISUAL_SACOS");

            entity.Property(e => e.Cumplimiento)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.Humedad).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.MatExtrAnimal)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MatExtranas)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Producto).HasMaxLength(50);
        });

        modelBuilder.Entity<VwRepMonitDetecmetale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REP_MONIT_DETECMETALES");

            entity.Property(e => e.AceroInoxidable)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.BrazoRechazo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Detector)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Ferrozo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Hora).HasPrecision(2);
            entity.Property(e => e.NoFerrozo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwReporControlEnvasadoptCab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPOR_CONTROL_ENVASADOPT_CAB");

            entity.Property(e => e.Abocador)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Barrido).HasColumnName("BARRIDO");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.KilosEnvasados).HasColumnType("numeric(30, 6)");
            entity.Property(e => e.Linea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteMp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LoteMP");
            entity.Property(e => e.LotePt)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("LotePT");
            entity.Property(e => e.Marca).IsUnicode(false);
            entity.Property(e => e.MateriaPrima).IsUnicode(false);
            entity.Property(e => e.Of).HasColumnName("OF");
            entity.Property(e => e.Operador)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Origen).HasMaxLength(100);
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .HasColumnName("PRODUCTO");
        });

        modelBuilder.Entity<VwReportFilmEnfardadora>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_FILM_ENFARDADORA");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwReportFilmImpreso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_FILM_IMPRESO");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwReportInspeccionArveja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_Inspeccion_Arveja");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegisro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.GranosAmarillos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosDanadosXinsectos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosEnteros).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtArveja).HasColumnName("Id_InspeccionPT_Arveja");
            entity.Property(e => e.Linea).HasColumnName("linea");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.Proveedor).HasMaxLength(100);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportInspeccionAzucar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_inspeccion_Azucar");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtAzucar).HasColumnName("Id_InspeccionPT_Azucar");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportInspeccionGarbanzo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_Inspeccion_Garbanzo");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.GranosDanadosXinsectos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosVerdosos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtGarbanzo).HasColumnName("Id_InspeccionPT_Garbanzo");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportInspeccionLenteja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_inspeccion_Lenteja");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.Fecharegistro).HasColumnType("datetime");
            entity.Property(e => e.GranosArrugados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosQuebrados).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdInspeccionPtLenteja).HasColumnName("Id_InspeccionPT_Lenteja");
            entity.Property(e => e.Impurezas).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtrana).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MateriaExtranaAnimal).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportInspeccionPoroto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_Inspeccion_Poroto");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.GanosDañadosXinsecto).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchado).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdIspeccionPtPoroto).HasColumnName("Id_IspeccionPT_Poroto");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtraña).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportInspeccionPorotoNegro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_Inspeccion_PorotoNegro");

            entity.Property(e => e.AccionCorrectiva).IsUnicode(false);
            entity.Property(e => e.CardName).HasMaxLength(100);
            entity.Property(e => e.EncargadoCalidad).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");
            entity.Property(e => e.GanosDañadosXinsecto).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosManchado).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.GranosPartidos).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.HoraAnalisis).HasPrecision(2);
            entity.Property(e => e.IdIspeccionPtPorotoNegro).HasColumnName("Id_IspeccionPT_PorotoNegro");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MateriaExtraña).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Verificador).HasMaxLength(100);
        });

        modelBuilder.Entity<VwReportTotalFilmEnfardadora>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_total_FilmEnfardadora");

            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<VwReportTotalFilmImpreso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_REPORT_total_FilmImpreso");

            entity.Property(e => e.IdControlEnvPt).HasColumnName("ID_ControlEnvPT");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<VwResumenReclamoCab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Resumen_Reclamo_Cab");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdReclamo).HasColumnName("Id_Reclamo");
        });

        modelBuilder.Entity<VwResumenReclamoLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Resumen_Reclamo_Lotes");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdReclamo).HasColumnName("Id_Reclamo");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
        });

        modelBuilder.Entity<VwResumenTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RESUMEN_TAREAS");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Asignado).HasMaxLength(100);
            entity.Property(e => e.Asunto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Detalle).IsUnicode(false);
            entity.Property(e => e.DptoId).HasColumnName("DptoID");
            entity.Property(e => e.Finicio)
                .HasColumnType("datetime")
                .HasColumnName("FInicio");
            entity.Property(e => e.Ftermino)
                .HasColumnType("datetime")
                .HasColumnName("FTermino");
            entity.Property(e => e.NomEstado)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.NomPrioridad)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ntarea).HasColumnName("NTarea");
            entity.Property(e => e.Resolucion).IsUnicode(false);
        });

        modelBuilder.Entity<VwRptTrazabilidadFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RPT_TRAZABILIDAD_FILM");

            entity.Property(e => e.Entidad)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Info)
                .IsUnicode(false)
                .HasColumnName("info");
            entity.Property(e => e.Operacion)
                .HasMaxLength(256)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Tipo).HasMaxLength(125);
            entity.Property(e => e.Usuario).HasMaxLength(101);
        });

        modelBuilder.Entity<VwTestResultSumaPickingList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_testResultSumaPickingList");

            entity.Property(e => e.FechaDestino)
                .HasColumnType("datetime")
                .HasColumnName("fechaDestino");
            entity.Property(e => e.FechaOrigen)
                .HasColumnType("datetime")
                .HasColumnName("fechaOrigen");
        });

        modelBuilder.Entity<VwTipoComisionVendedor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TIPO_COMISION_VENDEDOR");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoComi)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("tipoComi");
        });

        modelBuilder.Entity<VwTipoPalletXamarin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TIPO_PALLET_XAMARIN");

            entity.Property(e => e.SupportiveDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Supportive_Description");
        });

        modelBuilder.Entity<VwTranferSaplotesFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TranferSAPLotes_Film");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTranferenciaSapFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TranferenciaSAP_Film");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTransferenciaDetalleFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TRANSFERENCIA_DETALLE_FILM");

            entity.Property(e => e.FechaProduc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Produc");
            entity.Property(e => e.IdTransferenciaFilm).HasColumnName("Id_TransferenciaFilm");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoCono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTrazaBusquedaFilm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TRAZA_BUSQUEDA_FILM");

            entity.Property(e => e.BodActual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoBobina)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FechaProduc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Produc");
            entity.Property(e => e.FechaRecep).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Venc");
            entity.Property(e => e.LoteInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoteProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nbobina).HasColumnName("NBobina");
            entity.Property(e => e.PesoBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PesoNeto).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Producto).HasMaxLength(100);
            entity.Property(e => e.ReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reserve_Quantity");
        });

        modelBuilder.Entity<VwUsuariosActivosCvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_USUARIOS_ACTIVOS_CVT");

            entity.Property(e => e.Clave).HasMaxLength(15);
            entity.Property(e => e.ClaveEncriptada)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Depto).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.IdArea).HasColumnName("Id_Area");
            entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.RestriccionBodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RutaFirma).IsUnicode(false);
            entity.Property(e => e.RutaFoto).IsUnicode(false);
            entity.Property(e => e.UsuarioSistema).HasMaxLength(20);
        });

        modelBuilder.Entity<VwUsuariosXamarin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Usuarios_XAMARIN");

            entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
            entity.Property(e => e.UsuarioSistema).HasMaxLength(20);
        });

        modelBuilder.Entity<VwVencimientosProyectadosCvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_VencimientosProyectadosCVT");

            entity.Property(e => e.Bodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.Grupo).HasMaxLength(100);
            entity.Property(e => e.PrecioUnit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Producto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<VwXamarinPackage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_XAMARIN_PACKAGE");

            entity.Property(e => e.AccountsId).HasColumnName("Accounts_Id");
            entity.Property(e => e.ArticleProviderGrossWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ArticleProvider_GrossWeight");
            entity.Property(e => e.ArticleProviderId).HasColumnName("ArticleProvider_Id");
            entity.Property(e => e.CompanyId).HasColumnName("Company_Id");
            entity.Property(e => e.DevolucionMotivoId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DevolucionMotivo_Id");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageBarcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Barcode");
            entity.Property(e => e.PackageCrossDocking).HasColumnName("Package_CrossDocking");
            entity.Property(e => e.PackageData1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Data1");
            entity.Property(e => e.PackageData2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Data2");
            entity.Property(e => e.PackageDependencesTotal).HasColumnName("Package_DependencesTotal");
            entity.Property(e => e.PackageDestination).HasColumnName("Package_Destination");
            entity.Property(e => e.PackageExpiresDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ExpiresDate");
            entity.Property(e => e.PackageFoilPp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_FoilPP");
            entity.Property(e => e.PackageGrossWeight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_GrossWeight");
            entity.Property(e => e.PackageGrossWeightInitial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_GrossWeightInitial");
            entity.Property(e => e.PackageHeight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_Height");
            entity.Property(e => e.PackageId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Package_Id");
            entity.Property(e => e.PackageInDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_InDate");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageMixed).HasColumnName("Package_Mixed");
            entity.Property(e => e.PackageNetWeight)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_NetWeight");
            entity.Property(e => e.PackageNetWeightInitial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_NetWeightInitial");
            entity.Property(e => e.PackageOrigin).HasColumnName("Package_Origin");
            entity.Property(e => e.PackageOutDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_OutDate");
            entity.Property(e => e.PackageOwner)
                .HasMaxLength(14)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_Owner");
            entity.Property(e => e.PackagePn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_PN");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.PackageQualityStatus).HasColumnName("Package_QualityStatus");
            entity.Property(e => e.PackageQuantity).HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageQuantityInitial).HasColumnName("Package_QuantityInitial");
            entity.Property(e => e.PackageReserve).HasColumnName("Package_Reserve");
            entity.Property(e => e.PackageReserveQuantity).HasColumnName("Package_ReserveQuantity");
            entity.Property(e => e.PackageSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SN");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.PackageSsccparent)
                .HasMaxLength(128)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS")
                .HasColumnName("Package_SSCCParent");
            entity.Property(e => e.PackageSsccparentId).HasColumnName("Package_SSCCParent_Id");
            entity.Property(e => e.PackageStateId).HasColumnName("PackageState_Id");
            entity.Property(e => e.PackageStateIdInitial).HasColumnName("PackageState_Id_Initial");
            entity.Property(e => e.PackageStatus).HasColumnName("Package_Status");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.SupportiveId).HasColumnName("Supportive_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
