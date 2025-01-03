using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NuevoBMas.Models.BDSuper;

public partial class DbContextSuper : DbContext
{
    public DbContextSuper()
    {
    }

    public DbContextSuper(DbContextOptions<DbContextSuper> options)
        : base(options)
    {
    }

    public virtual DbSet<Correlative> Correlatives { get; set; }

    public virtual DbSet<CvtVwFiltroTransferenciasSmm> CvtVwFiltroTransferenciasSmms { get; set; }

    public virtual DbSet<CvtVwSmmDuplicadosInventario> CvtVwSmmDuplicadosInventarios { get; set; }

    public virtual DbSet<CvtVwTransferenciasDetalleSmm> CvtVwTransferenciasDetalleSmms { get; set; }

    public virtual DbSet<Expedition> Expeditions { get; set; }

    public virtual DbSet<ExpeditionDetail> ExpeditionDetails { get; set; }

    public virtual DbSet<Layout> Layouts { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PickingList> PickingLists { get; set; }

    public virtual DbSet<Rack> Racks { get; set; }

    public virtual DbSet<Reception> Receptions { get; set; }

    public virtual DbSet<Reserve> Reserves { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SmmAjusteDocumento> SmmAjusteDocumentos { get; set; }

    public virtual DbSet<SmmAperturaCaja> SmmAperturaCajas { get; set; }

    public virtual DbSet<SmmCliente> SmmClientes { get; set; }

    public virtual DbSet<SmmClientesContacto> SmmClientesContactos { get; set; }

    public virtual DbSet<SmmClientesDireccion> SmmClientesDireccions { get; set; }

    public virtual DbSet<SmmClientesOrdenVentum> SmmClientesOrdenVenta { get; set; }

    public virtual DbSet<SmmComisionProducto> SmmComisionProductos { get; set; }

    public virtual DbSet<SmmComisionVendedor> SmmComisionVendedors { get; set; }

    public virtual DbSet<SmmCotizacionCaja> SmmCotizacionCajas { get; set; }

    public virtual DbSet<SmmCotizacionCajasDetalle> SmmCotizacionCajasDetalles { get; set; }

    public virtual DbSet<SmmCotizacionCajasDireccion> SmmCotizacionCajasDireccions { get; set; }

    public virtual DbSet<SmmCumpReposicionSala> SmmCumpReposicionSalas { get; set; }

    public virtual DbSet<SmmDetalleOrdenXam> SmmDetalleOrdenXams { get; set; }

    public virtual DbSet<SmmExhibicionSala> SmmExhibicionSalas { get; set; }

    public virtual DbSet<SmmFoliosInventariosXamarin> SmmFoliosInventariosXamarins { get; set; }

    public virtual DbSet<SmmHistorialArqueo> SmmHistorialArqueos { get; set; }

    public virtual DbSet<SmmInventarioCabecera> SmmInventarioCabeceras { get; set; }

    public virtual DbSet<SmmInventarioDetalle> SmmInventarioDetalles { get; set; }

    public virtual DbSet<SmmLogCaja> SmmLogCajas { get; set; }

    public virtual DbSet<SmmLogErrorPo> SmmLogErrorPos { get; set; }

    public virtual DbSet<SmmMedicionArmadoPedido> SmmMedicionArmadoPedidos { get; set; }

    public virtual DbSet<SmmNotaCreditoDatoCliente> SmmNotaCreditoDatoClientes { get; set; }

    public virtual DbSet<SmmNotaCreditoDatoCompra> SmmNotaCreditoDatoCompras { get; set; }

    public virtual DbSet<SmmNotaCreditoDetallePago> SmmNotaCreditoDetallePagos { get; set; }

    public virtual DbSet<SmmObtieneDatosCliente> SmmObtieneDatosClientes { get; set; }

    public virtual DbSet<SmmObtieneDatosDereccione> SmmObtieneDatosDerecciones { get; set; }

    public virtual DbSet<SmmObtieneDatosDireccione> SmmObtieneDatosDirecciones { get; set; }

    public virtual DbSet<SmmOrdenDeVenta> SmmOrdenDeVentas { get; set; }

    public virtual DbSet<SmmOrdenDeVentasDetalle> SmmOrdenDeVentasDetalles { get; set; }

    public virtual DbSet<SmmPickingConsolidado> SmmPickingConsolidados { get; set; }

    public virtual DbSet<SmmPreventaDatoPago> SmmPreventaDatoPagos { get; set; }

    public virtual DbSet<SmmPreventaDetalle> SmmPreventaDetalles { get; set; }

    public virtual DbSet<SmmPreventum> SmmPreventa { get; set; }

    public virtual DbSet<SmmRegImpEtiquetum> SmmRegImpEtiqueta { get; set; }

    public virtual DbSet<SmmRegPalletSala> SmmRegPalletSalas { get; set; }

    public virtual DbSet<SmmReponedore> SmmReponedores { get; set; }

    public virtual DbSet<SmmSolicitudTransferencium> SmmSolicitudTransferencia { get; set; }

    public virtual DbSet<SmmStockFecha> SmmStockFechas { get; set; }

    public virtual DbSet<SmmTotalArqueoReal> SmmTotalArqueoReals { get; set; }

    public virtual DbSet<SmmTransformacione> SmmTransformaciones { get; set; }

    public virtual DbSet<SmmVentaPersonal> SmmVentaPersonals { get; set; }

    public virtual DbSet<SmmVentaPersonalDetalle> SmmVentaPersonalDetalles { get; set; }

    public virtual DbSet<SmmVwClientesOrdenVenta> SmmVwClientesOrdenVentas { get; set; }

    public virtual DbSet<SmmVwDeptoVenta> SmmVwDeptoVentas { get; set; }

    public virtual DbSet<SmmVwDetalleCliente> SmmVwDetalleClientes { get; set; }

    public virtual DbSet<SmmVwDetallePago> SmmVwDetallePagos { get; set; }

    public virtual DbSet<SmmVwDetallePreventum> SmmVwDetallePreventa { get; set; }

    public virtual DbSet<SmmVwDetalleRecepcion> SmmVwDetalleRecepcions { get; set; }

    public virtual DbSet<SmmVwDetalleRecepcionTransferencium> SmmVwDetalleRecepcionTransferencia { get; set; }

    public virtual DbSet<SmmVwDirDespachoOrdenVentum> SmmVwDirDespachoOrdenVenta { get; set; }

    public virtual DbSet<SmmVwDirFacturacionOrdenVentum> SmmVwDirFacturacionOrdenVenta { get; set; }

    public virtual DbSet<SmmVwDocAjustada> SmmVwDocAjustadas { get; set; }

    public virtual DbSet<SmmVwDuplicadosInventario> SmmVwDuplicadosInventarios { get; set; }

    public virtual DbSet<SmmVwExpedicionDetalle> SmmVwExpedicionDetalles { get; set; }

    public virtual DbSet<SmmVwExpeditionDetailLotSync> SmmVwExpeditionDetailLotSyncs { get; set; }

    public virtual DbSet<SmmVwExpeditiondetailexport> SmmVwExpeditiondetailexports { get; set; }

    public virtual DbSet<SmmVwInfArqueocaja> SmmVwInfArqueocajas { get; set; }

    public virtual DbSet<SmmVwInfInventarioSmm> SmmVwInfInventarioSmms { get; set; }

    public virtual DbSet<SmmVwInfInventarioxUserSmm> SmmVwInfInventarioxUserSmms { get; set; }

    public virtual DbSet<SmmVwInfoClientePreventum> SmmVwInfoClientePreventa { get; set; }

    public virtual DbSet<SmmVwInventarioCantidadDiferente> SmmVwInventarioCantidadDiferentes { get; set; }

    public virtual DbSet<SmmVwMontoEfectivo> SmmVwMontoEfectivos { get; set; }

    public virtual DbSet<SmmVwMontoEfectivoNc> SmmVwMontoEfectivoNcs { get; set; }

    public virtual DbSet<SmmVwMontoNotaCredito> SmmVwMontoNotaCreditos { get; set; }

    public virtual DbSet<SmmVwMontoNotaCreditoPrueba> SmmVwMontoNotaCreditoPruebas { get; set; }

    public virtual DbSet<SmmVwNotacreditoDetalleCliente> SmmVwNotacreditoDetalleClientes { get; set; }

    public virtual DbSet<SmmVwNotacreditoDetalleCompra> SmmVwNotacreditoDetalleCompras { get; set; }

    public virtual DbSet<SmmVwNotacreditoDetallePago> SmmVwNotacreditoDetallePagos { get; set; }

    public virtual DbSet<SmmVwPickingConsolidado> SmmVwPickingConsolidados { get; set; }

    public virtual DbSet<SmmVwProductoPreventaTodosLs11> SmmVwProductoPreventaTodosLs11s { get; set; }

    public virtual DbSet<SmmVwProductosCotizacionCaja> SmmVwProductosCotizacionCajas { get; set; }

    public virtual DbSet<SmmVwRecepcionDetalle> SmmVwRecepcionDetalles { get; set; }

    public virtual DbSet<SmmVwTipoPago> SmmVwTipoPagos { get; set; }

    public virtual DbSet<SmmVwTotalConsolidadoPicking> SmmVwTotalConsolidadoPickings { get; set; }

    public virtual DbSet<SmmVwTotaldocumentoorigen> SmmVwTotaldocumentoorigens { get; set; }

    public virtual DbSet<SmmVwTransferDetail> SmmVwTransferDetails { get; set; }

    public virtual DbSet<SmmVwTrazabilidadBultosConReserva> SmmVwTrazabilidadBultosConReservas { get; set; }

    public virtual DbSet<SmmVwTrazabilidadBusquedum> SmmVwTrazabilidadBusqueda { get; set; }

    public virtual DbSet<SmmVwTrazabilidadPallet> SmmVwTrazabilidadPallets { get; set; }

    public virtual DbSet<SmmVwVwDiferenciasDuplicado> SmmVwVwDiferenciasDuplicados { get; set; }

    public virtual DbSet<SmmsolicitudTransferenciaDetalle> SmmsolicitudTransferenciaDetalles { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<TransferDetail> TransferDetails { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<VwCalculoMontoVentaSinRedondeo> VwCalculoMontoVentaSinRedondeos { get; set; }

    public virtual DbSet<VwCalculoMontoVentum> VwCalculoMontoVenta { get; set; }

    public virtual DbSet<VwClientesOvXamarin> VwClientesOvXamarins { get; set; }

    public virtual DbSet<VwDatosPackageXamrin> VwDatosPackageXamrins { get; set; }

    public virtual DbSet<VwDepartamentosVenta> VwDepartamentosVentas { get; set; }

    public virtual DbSet<VwDireccionesClientesSap> VwDireccionesClientesSaps { get; set; }

    public virtual DbSet<VwListTransfer> VwListTransfers { get; set; }

    public virtual DbSet<VwListadoProductosSolicitud> VwListadoProductosSolicituds { get; set; }

    public virtual DbSet<VwMontoNotacredito> VwMontoNotacreditos { get; set; }

    public virtual DbSet<VwMontoVentaSinRedondeoSmm> VwMontoVentaSinRedondeoSmms { get; set; }

    public virtual DbSet<VwMontoVentaSmm> VwMontoVentaSmms { get; set; }

    public virtual DbSet<VwPackCajasSmm> VwPackCajasSmms { get; set; }

    public virtual DbSet<VwPromoTotalxProvee> VwPromoTotalxProvees { get; set; }

    public virtual DbSet<VwRecepcionResumenSmm> VwRecepcionResumenSmms { get; set; }

    public virtual DbSet<VwRptCotizacionCajasKit> VwRptCotizacionCajasKits { get; set; }

    public virtual DbSet<VwRptPalletEnSala> VwRptPalletEnSalas { get; set; }

    public virtual DbSet<VwSmmClientesDescPromo> VwSmmClientesDescPromos { get; set; }

    public virtual DbSet<VwSmmClientesTicketPromo> VwSmmClientesTicketPromos { get; set; }

    public virtual DbSet<VwSmmConsolidadoCompra> VwSmmConsolidadoCompras { get; set; }

    public virtual DbSet<VwSmmDatoClientesNotacredito> VwSmmDatoClientesNotacreditos { get; set; }

    public virtual DbSet<VwSmmDatoProductosNotacredito> VwSmmDatoProductosNotacreditos { get; set; }

    public virtual DbSet<VwSmmDiferenciasDuplicadosInventario> VwSmmDiferenciasDuplicadosInventarios { get; set; }

    public virtual DbSet<VwSmmFoliosSolicitudTransferencia> VwSmmFoliosSolicitudTransferencias { get; set; }

    public virtual DbSet<VwSmmInventarioCantidadDiferenteInf> VwSmmInventarioCantidadDiferenteInfs { get; set; }

    public virtual DbSet<VwSmmVencimientoProyectadoBma> VwSmmVencimientoProyectadoBmas { get; set; }

    public virtual DbSet<VwStockFechaRecepcion> VwStockFechaRecepcions { get; set; }

    public virtual DbSet<VwStockFechaTransferencium> VwStockFechaTransferencia { get; set; }

    public virtual DbSet<VwStockSmm> VwStockSmms { get; set; }

    public virtual DbSet<VwTotalCantReqCotizacionKit> VwTotalCantReqCotizacionKits { get; set; }

    public virtual DbSet<VwTotalPreventum> VwTotalPreventa { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.0.20.3;Database=CVT_WMS_SMM;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Correlative>(entity =>
        {
            entity.HasKey(e => e.CorrelativeId).HasName("PK_Correlative_ID");

            entity.ToTable("Correlative");

            entity.Property(e => e.CorrelativeId).HasColumnName("Correlative_Id");
            entity.Property(e => e.CorrelativeDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Correlative_Description");
            entity.Property(e => e.CorrelativeIn).HasColumnName("Correlative_In");
            entity.Property(e => e.CorrelativeNow).HasColumnName("Correlative_Now");
            entity.Property(e => e.CorrelativeOut).HasColumnName("Correlative_Out");
        });

        modelBuilder.Entity<CvtVwFiltroTransferenciasSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_FiltroTransferenciasSMM");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Medida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<CvtVwSmmDuplicadosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_SMM_DuplicadosInventario");

            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
        });

        modelBuilder.Entity<CvtVwTransferenciasDetalleSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CVT_VW_TransferenciasDetalleSMM");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutIdActual).HasColumnName("Layout_Id_Actual");
            entity.Property(e => e.Medida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageConfirm).HasColumnName("Package_Confirm");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.PackageQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<Expedition>(entity =>
        {
            entity.HasKey(e => e.ExpeditionId).HasName("PK_Expedition_SID");

            entity.ToTable("Expedition");

            entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");
            entity.Property(e => e.ExpeditionDateIn)
                .HasColumnType("datetime")
                .HasColumnName("Expedition_DateIn");
            entity.Property(e => e.ExpeditionDateOut)
                .HasColumnType("datetime")
                .HasColumnName("Expedition_DateOut");
            entity.Property(e => e.ExpeditionMotivo).HasColumnName("Expedition_Motivo");
            entity.Property(e => e.ExpeditionNote)
                .HasMaxLength(2550)
                .IsUnicode(false)
                .HasColumnName("Expedition_Note");
            entity.Property(e => e.ExpeditionNumDocSap).HasColumnName("Expedition_NumDocSAP");
            entity.Property(e => e.ExpeditionStatus).HasColumnName("Expedition_Status");
            entity.Property(e => e.ExpeditionTipoDocSap).HasColumnName("Expedition_TipoDocSAP");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<ExpeditionDetail>(entity =>
        {
            entity.HasKey(e => new { e.SiteId, e.ExpeditionId, e.PackageId }).HasName("PK_ExpeditionDetail_SEP");

            entity.ToTable("ExpeditionDetail");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.ExpeditionDetailConfirmedDate)
                .HasColumnType("datetime")
                .HasColumnName("ExpeditionDetail_ConfirmedDate");
            entity.Property(e => e.ExpeditionDetailQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ExpeditionDetail_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
        });

        modelBuilder.Entity<Layout>(entity =>
        {
            entity.HasKey(e => e.LayoutId).HasName("PK_Layout_ID");

            entity.ToTable("Layout");

            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Layout_Description");
            entity.Property(e => e.LayoutXFila).HasColumnName("Layout_X_Fila");
            entity.Property(e => e.LayoutYPasillo).HasColumnName("Layout_Y_Pasillo");
            entity.Property(e => e.LayoutZColumna).HasColumnName("Layout_Z_Columna");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.UbicacionxDefecto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK_Location_ID");

            entity.ToTable("Location");

            entity.Property(e => e.LocationId).HasColumnName("Location_Id");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.LocationInDate)
                .HasColumnType("datetime")
                .HasColumnName("Location_InDate");
            entity.Property(e => e.LocationOutDate)
                .HasColumnType("datetime")
                .HasColumnName("Location_OutDate");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK_Package_ID");

            entity.ToTable("Package");

            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.CantUniTot)
                .HasComputedColumnSql("([Package_Quantity]*[BaseUnMed])", false)
                .HasColumnType("decimal(29, 0)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageData1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Package_Data1");
            entity.Property(e => e.PackageData2)
                .IsUnicode(false)
                .HasColumnName("Package_Data2");
            entity.Property(e => e.PackageExpiresDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ExpiresDate");
            entity.Property(e => e.PackageInDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_InDate");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageOutDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_OutDate");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.PackageQuantity)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageQuantityInitial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_QuantityInitial");
            entity.Property(e => e.PackageReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_ReserveQuantity");
            entity.Property(e => e.PackageSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_SN");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.PackageStatus).HasColumnName("Package_Status");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.UnMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UomCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PickingList>(entity =>
        {
            entity.ToTable("PickingList");

            entity.Property(e => e.PickingListId).HasColumnName("PickingList_Id");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("itemCode");
            entity.Property(e => e.ItemName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("itemName");
            entity.Property(e => e.PackageIdDestiny).HasColumnName("Package_Id_Destiny");
            entity.Property(e => e.PackageIdOrigin).HasColumnName("Package_Id_Origin");
            entity.Property(e => e.PackageSsccDestiny)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC_Destiny");
            entity.Property(e => e.PackageSsccOrigin)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC_Origin");
            entity.Property(e => e.PickingListDate)
                .HasColumnType("datetime")
                .HasColumnName("PickingList_Date");
            entity.Property(e => e.PickingListQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PickingList_Quantity");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<Rack>(entity =>
        {
            entity.HasKey(e => e.RackId).HasName("PK_Rack_ID");

            entity.ToTable("Rack");

            entity.Property(e => e.RackId).HasColumnName("Rack_Id");
            entity.Property(e => e.RackType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rack_Type");
        });

        modelBuilder.Entity<Reception>(entity =>
        {
            entity.HasKey(e => e.ReceptionId).HasName("PK_Reception_ID");

            entity.ToTable("Reception");

            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DocType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumDocSap).HasColumnName("NumDocSAP");
            entity.Property(e => e.ReceptionDateIn)
                .HasColumnType("datetime")
                .HasColumnName("Reception_DateIn");
            entity.Property(e => e.ReceptionDateOut)
                .HasColumnType("datetime")
                .HasColumnName("Reception_DateOut");
            entity.Property(e => e.ReceptionDocNumber).HasColumnName("Reception_DocNumber");
            entity.Property(e => e.ReceptionNote)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("Reception_Note");
            entity.Property(e => e.ReceptionStatus).HasColumnName("Reception_Status");
            entity.Property(e => e.ReceptionType).HasColumnName("Reception_Type");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.TipoDocSap).HasColumnName("TipoDocSAP");
        });

        modelBuilder.Entity<Reserve>(entity =>
        {
            entity.ToTable("Reserve");

            entity.Property(e => e.ReserveId).HasColumnName("Reserve_Id");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Lot)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageSerie)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_Serie");
            entity.Property(e => e.ReserveDate)
                .HasColumnType("datetime")
                .HasColumnName("Reserve_Date");
            entity.Property(e => e.ReserveQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Reserve_Quantity");
            entity.Property(e => e.ReserveStatus).HasColumnName("Reserve_Status");
            entity.Property(e => e.TransferDetailUnitId).HasColumnName("Transfer_Detail_Unit_Id");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.WavePickingId).HasColumnName("WavePicking_Id");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK_Site_ID");

            entity.ToTable("Site");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
        });

        modelBuilder.Entity<SmmAjusteDocumento>(entity =>
        {
            entity.HasKey(e => new { e.PreventaId, e.Codproducto }).HasName("PK_SMM_AjusteDocElectronico");

            entity.ToTable("SMM_AjusteDocumento");

            entity.Property(e => e.PreventaId).HasColumnName("PreventaID");
            entity.Property(e => e.Codproducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAjuste).HasColumnType("datetime");
            entity.Property(e => e.NomProd).IsUnicode(false);
        });

        modelBuilder.Entity<SmmAperturaCaja>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.IdCajero });

            entity.ToTable("SMM_AperturaCaja");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdCajero)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmCliente>(entity =>
        {
            entity.HasKey(e => e.Rut);

            entity.ToTable("SMM_Clientes");

            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Giro).IsUnicode(false);
            entity.Property(e => e.IdcondicionPago).HasColumnName("IDCondicionPago");
            entity.Property(e => e.IdtipoNegocio).HasColumnName("IDTipoNegocio");
            entity.Property(e => e.IdvendAsignado).HasColumnName("IDVendAsignado");
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.NombreFantasia).IsUnicode(false);
            entity.Property(e => e.Nominacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial).IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmClientesContacto>(entity =>
        {
            entity.HasKey(e => e.Idcontacto);

            entity.ToTable("SMM_Clientes_Contacto");

            entity.Property(e => e.Idcontacto).HasColumnName("IDContacto");
            entity.Property(e => e.Apellido).IsUnicode(false);
            entity.Property(e => e.Cargo).IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("EMail");
            entity.Property(e => e.Nombre).IsUnicode(false);
        });

        modelBuilder.Entity<SmmClientesDireccion>(entity =>
        {
            entity.HasKey(e => new { e.CodCliente, e.CodDireccion });

            entity.ToTable("SMM_Clientes_Direccion");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDireccion).ValueGeneratedOnAdd();
            entity.Property(e => e.Ciudad).IsUnicode(false);
            entity.Property(e => e.Comuna).IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.TipoDir)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmClientesOrdenVentum>(entity =>
        {
            entity.HasKey(e => e.RutCliente);

            entity.ToTable("SMM_Clientes_Orden_Venta");

            entity.Property(e => e.RutCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo).IsUnicode(false);
            entity.Property(e => e.DirecDesp).IsUnicode(false);
            entity.Property(e => e.DirecFact).IsUnicode(false);
            entity.Property(e => e.Giro).IsUnicode(false);
            entity.Property(e => e.NombreCliente).IsUnicode(false);
            entity.Property(e => e.RazonSocial).IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UbiAltitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ubi_Altitud");
            entity.Property(e => e.UbiLatitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ubi_Latitud");
            entity.Property(e => e.UbiLongitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ubi_Longitud");
        });

        modelBuilder.Entity<SmmComisionProducto>(entity =>
        {
            entity.HasKey(e => e.CodProducto);

            entity.ToTable("SMM_ComisionProductos");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCategoria).HasColumnName("Cod_Categoria");
            entity.Property(e => e.CodSubCategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Sub_Categoria");
            entity.Property(e => e.NombreProducto).IsUnicode(false);
            entity.Property(e => e.PrcComision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoComision)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UMarcaProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_MarcaProducto");
        });

        modelBuilder.Entity<SmmComisionVendedor>(entity =>
        {
            entity.HasKey(e => new { e.IdVendedor, e.IdGrupoProd });

            entity.ToTable("SMM_ComisionVendedor");
        });

        modelBuilder.Entity<SmmCotizacionCaja>(entity =>
        {
            entity.HasKey(e => e.CotizacionId);

            entity.ToTable("SMM_Cotizacion_Cajas");

            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_Id");
            entity.Property(e => e.CantidadProducir).HasComputedColumnSql("([dbo].[CANTIDAD_CAJAS_COTIZACION]([Cotizacion_Id]))", false);
            entity.Property(e => e.CorreoCliente)
                .IsUnicode(false)
                .HasColumnName("Correo_Cliente");
            entity.Property(e => e.CosTotalCotizacion).HasComputedColumnSql("([dbo].[COSTO_UNITARIO_COTIZACION_CABECERA]([Cotizacion_Id]))", false);
            entity.Property(e => e.FechaCotizacion).HasColumnType("datetime");
            entity.Property(e => e.FormaDePago).IsUnicode(false);
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MargenTotal)
                .HasComputedColumnSql("([dbo].[MARGEN_TOTAL_COTIZACION]([Cotizacion_Id]))", false)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreCliente)
                .IsUnicode(false)
                .HasColumnName("Nombre_Cliente");
        });

        modelBuilder.Entity<SmmCotizacionCajasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetCotizacion);

            entity.ToTable("SMM_Cotizacion_Cajas_Detalle");

            entity.Property(e => e.IdDetCotizacion).HasColumnName("Id_Det_Cotizacion");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoKitPred)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CostoTotal).HasComputedColumnSql("([dbo].[COSTO_TOTAL_COTIZACION]([Id_Det_Cotizacion],[CodProducto]))", false);
            entity.Property(e => e.CostoUnitario)
                .HasComputedColumnSql("(case [CodProducto] when 'COSxCAJA-1' then (600) when 'COSxCAJA-2' then (550) else [dbo].[COSTO_UNITARIO_COTIZACION]([CodProducto]) end)", false)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_Id");
            entity.Property(e => e.MargenProducto)
                .HasComputedColumnSql("([dbo].[MARGEN_DET_COTIZACION]([Id_Det_Cotizacion]))", false)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Precio)
                .HasComputedColumnSql("([dbo].[COSTO_UNITARIO_COTIZACION]([CodProducto]))", false)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PrecioTotal).HasComputedColumnSql("([dbo].[PrecioTotal]([Id_Det_Cotizacion]))", false);
        });

        modelBuilder.Entity<SmmCotizacionCajasDireccion>(entity =>
        {
            entity.HasKey(e => e.IdDireccionCoti);

            entity.ToTable("SMM_Cotizacion_Cajas_Direccion");

            entity.Property(e => e.IdDireccionCoti).HasColumnName("Id_Direccion_Coti");
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.IdCotizacion).HasColumnName("Id_Cotizacion");
            entity.Property(e => e.TipoDireccion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmCumpReposicionSala>(entity =>
        {
            entity.HasKey(e => e.IdCumplimiento);

            entity.ToTable("SMM_Cump_Reposicion_Sala");

            entity.Property(e => e.IdCumplimiento).HasColumnName("Id_Cumplimiento");
            entity.Property(e => e.CodBarra).IsUnicode(false);
            entity.Property(e => e.CodProducto).IsUnicode(false);
            entity.Property(e => e.DispoProducto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FeFo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVencProd).HasColumnType("datetime");
            entity.Property(e => e.Fleje)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Limpieza)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PrcCumpl).HasComputedColumnSql("([dbo].[PrcCumplimiento]([Id_Cumplimiento]))", false);
        });

        modelBuilder.Entity<SmmDetalleOrdenXam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_Detalle_Orden_Xam");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImptoProcentaje).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ImptoTipo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Margen).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcDescuento).HasColumnName("Porc_Descuento");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalImpto).HasColumnType("numeric(33, 6)");
        });

        modelBuilder.Entity<SmmExhibicionSala>(entity =>
        {
            entity.HasKey(e => e.IdExhibicion);

            entity.ToTable("SMM_ExhibicionSala");

            entity.Property(e => e.IdExhibicion).HasColumnName("id_exhibicion");
            entity.Property(e => e.CodBarra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pasillo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmFoliosInventariosXamarin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_FOLIOS_INVENTARIOS_XAMARIN");

            entity.Property(e => e.InventarioId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Inventario_Id");
        });

        modelBuilder.Entity<SmmHistorialArqueo>(entity =>
        {
            entity.HasKey(e => new { e.IdArqueo, e.FechaArqueo }).HasName("PK_SMM_Historial_Arqueo_1");

            entity.ToTable("SMM_Historial_Arqueo");

            entity.Property(e => e.IdArqueo).ValueGeneratedOnAdd();
            entity.Property(e => e.FechaArqueo).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistroArqueo).HasColumnType("datetime");
            entity.Property(e => e.Moneda)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmInventarioCabecera>(entity =>
        {
            entity.HasKey(e => e.InventarioId).HasName("PK_CVT_CabeceraInventario");

            entity.ToTable("SMM_InventarioCabecera");

            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdUsuarioEncargado).HasColumnName("Id_UsuarioEncargado");
        });

        modelBuilder.Entity<SmmInventarioDetalle>(entity =>
        {
            entity.HasKey(e => e.InventarioDetId).HasName("PK_CVT_DetalleInventario");

            entity.ToTable("SMM_InventarioDetalle");

            entity.Property(e => e.InventarioDetId).HasColumnName("InventarioDet_Id");
            entity.Property(e => e.CantEmp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dun14).IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.LocationId).HasColumnName("Location_Id");
            entity.Property(e => e.PackageSscc).HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.TipoEmpaque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UbiPasillo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmLogCaja>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK_SMM_LogPreventas");

            entity.ToTable("SMM_LogCaja");

            entity.Property(e => e.IdLog).HasColumnName("ID_log");
            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.FecharError).HasColumnType("datetime");
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.Usuario).IsUnicode(false);
        });

        modelBuilder.Entity<SmmLogErrorPo>(entity =>
        {
            entity.HasKey(e => e.IdErr);

            entity.ToTable("SMM_LogErrorPOS");

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Modulo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmMedicionArmadoPedido>(entity =>
        {
            entity.HasKey(e => new { e.IdMedicionArmado, e.Norden, e.CodProducto });

            entity.ToTable("SMM_MedicionArmadoPedido");

            entity.Property(e => e.IdMedicionArmado)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_MedicionArmado");
            entity.Property(e => e.Norden).HasColumnName("NOrden");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CantCorrecta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodBarras).IsUnicode(false);
            entity.Property(e => e.CondPallet)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Enfilado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Estibado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.PrcCumpl).HasComputedColumnSql("([dbo].[PrcCumplimientoArmPed]([Id_MedicionArmado]))", false);
            entity.Property(e => e.UniMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VencCorrecto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SmmNotaCreditoDatoCliente>(entity =>
        {
            entity.HasKey(e => e.IdNotaCredito);

            entity.ToTable("SMM_NotaCredito_DatoCliente");

            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DireccionDespacho)
                .IsUnicode(false)
                .HasColumnName("Direccion_Despacho");
            entity.Property(e => e.DireccionFacturacion)
                .IsUnicode(false)
                .HasColumnName("Direccion_Facturacion");
            entity.Property(e => e.FechaCreacionRegistoNota).HasColumnType("datetime");
            entity.Property(e => e.FechaDocumento).HasColumnType("datetime");
            entity.Property(e => e.NombreCliente).IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoNc).HasColumnName("TipoNC");
        });

        modelBuilder.Entity<SmmNotaCreditoDatoCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdNotaCredito, e.CodProducto });

            entity.ToTable("SMM_NotaCredito_DatoCompra");

            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Total)
                .HasComputedColumnSql("(round([Cantidad]*[Precio]-(([Cantidad]*[Precio])*isnull([Descuento],(0)))/(100),(0)))", false)
                .HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<SmmNotaCreditoDetallePago>(entity =>
        {
            entity.HasKey(e => e.IdDetallePagoNota);

            entity.ToTable("SMM_NotaCredito_DetallePago");

            entity.Property(e => e.IdDetallePagoNota).HasColumnName("ID_Detalle_PagoNota");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
        });

        modelBuilder.Entity<SmmObtieneDatosCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_ObtieneDatosCliente");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Giro).IsUnicode(false);
            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.RazonSocial).IsUnicode(false);
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmObtieneDatosDereccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_ObtieneDatosDerecciones");

            entity.Property(e => e.Ciudad).IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDireccion).ValueGeneratedOnAdd();
            entity.Property(e => e.Comuna).IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.TipoDir)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmObtieneDatosDireccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_ObtieneDatosDirecciones");

            entity.Property(e => e.Ciudad).IsUnicode(false);
            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDireccion).ValueGeneratedOnAdd();
            entity.Property(e => e.Comuna).IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.TipoDir)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmOrdenDeVenta>(entity =>
        {
            entity.HasKey(e => e.IdOrdenVentas).HasName("PK_CVT_Orden_de_Ventas");

            entity.ToTable("SMM_Orden_de_Ventas");

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

        modelBuilder.Entity<SmmOrdenDeVentasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalleOrden);

            entity.ToTable("SMM_Orden_de_Ventas_Detalle");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImptoProcentaje)
                .HasComputedColumnSql("([dbo].[valorimpuesto]([codproducto]))", false)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ImptoTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[TipoImpuesto]([codproducto]))", false);
            entity.Property(e => e.Margen)
                .HasComputedColumnSql("([dbo].[valormargen]([codproducto]))", false)
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PorcDescuento).HasColumnName("Porc_Descuento");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalContrib).HasComputedColumnSql("([Cantidad]*[Contribucion])", false);
            entity.Property(e => e.TotalImpto)
                .HasComputedColumnSql("(([dbo].[valorimpuesto]([codproducto])/(100))*([Cantidad]*[PrecioVenta]))", false)
                .HasColumnType("numeric(33, 6)");
            entity.Property(e => e.TotalLinea).HasComputedColumnSql("([Cantidad]*[PrecioVenta])", false);
        });

        modelBuilder.Entity<SmmPickingConsolidado>(entity =>
        {
            entity.HasKey(e => e.IdPickingSmm);

            entity.ToTable("SMM_PickingConsolidado");

            entity.Property(e => e.IdPickingSmm).HasColumnName("Id_PickingSMM");
            entity.Property(e => e.DeptoVentas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaConsolidado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Consolidado");
            entity.Property(e => e.FechaPickeada)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Pickeada");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmPreventaDatoPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoPago).HasName("PK_SMM_Preventa_DatoPago_1");

            entity.ToTable("SMM_Preventa_DatoPago");

            entity.Property(e => e.IdTipoPago).HasColumnName("ID_TipoPago");
            entity.Property(e => e.FechaDocumento).HasColumnType("datetime");
            entity.Property(e => e.NBoucher).HasColumnName("nBoucher");
            entity.Property(e => e.Ncheque).HasColumnName("NCheque");
            entity.Property(e => e.Ntarjeta)
                .IsUnicode(false)
                .HasColumnName("NTarjeta");
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoPago)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmPreventaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.PreventaId, e.CodProducto, e.UniMedida });

            entity.ToTable("SMM_Preventa_Detalle");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniMedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodBarra).IsUnicode(false);
            entity.Property(e => e.Producto).IsUnicode(false);
            entity.Property(e => e.Total)
                .HasComputedColumnSql("(round([Cantidad]*[Precio]-(([Cantidad]*[Precio])*isnull([Descuento],(0)))/(100),(0)))", false)
                .HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<SmmPreventum>(entity =>
        {
            entity.HasKey(e => e.PreventaId);

            entity.ToTable("SMM_Preventa");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DireccionEnvio).IsUnicode(false);
            entity.Property(e => e.DireccionFact).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.RunCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalPreventa).HasComputedColumnSql("([dbo].[TotalPreventaDet]([Preventa_ID]))", false);
        });

        modelBuilder.Entity<SmmRegImpEtiquetum>(entity =>
        {
            entity.HasKey(e => e.IdRegImpEtiq);

            entity.ToTable("SMM_RegImpEtiqueta");

            entity.Property(e => e.CodProd)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmRegPalletSala>(entity =>
        {
            entity.HasKey(e => e.IdRegPallet);

            entity.ToTable("SMM_RegPalletSala");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetProducto).IsUnicode(false);
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
        });

        modelBuilder.Entity<SmmReponedore>(entity =>
        {
            entity.HasKey(e => e.IdReponedor);

            entity.ToTable("SMM_Reponedores");

            entity.Property(e => e.Nombre).IsUnicode(false);
            entity.Property(e => e.Run)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("run");
        });

        modelBuilder.Entity<SmmSolicitudTransferencium>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.ToTable("SMM_Solicitud_Transferencia");

            entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            entity.Property(e => e.Comentarios).IsUnicode(false);
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
        });

        modelBuilder.Entity<SmmStockFecha>(entity =>
        {
            entity.HasKey(e => new { e.Bodega, e.Producto, e.FechaProduccion });

            entity.ToTable("SMM_StockFecha");

            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaProduccion).HasColumnType("datetime");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SmmTotalArqueoReal>(entity =>
        {
            entity.HasKey(e => e.IdArqCaja);

            entity.ToTable("SMM_TotalArqueoReal");

            entity.Property(e => e.IdArqCaja).HasColumnName("IdArq_Caja");
            entity.Property(e => e.FechArqCaja)
                .HasColumnType("datetime")
                .HasColumnName("FechArq_Caja");
            entity.Property(e => e.FechaHistArqueo)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_hist_Arqueo");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.TotCheqCaja).HasColumnName("TotCheq_Caja");
            entity.Property(e => e.TotCheqSist).HasColumnName("TotCheq_Sist");
            entity.Property(e => e.TotEfecCaja).HasColumnName("TotEfec_CAja");
            entity.Property(e => e.TotEfecSist).HasColumnName("TotEfec_Sist");
            entity.Property(e => e.TotGenCaja).HasColumnName("TotGen_Caja");
            entity.Property(e => e.TotGenSist).HasColumnName("TotGen_Sist");
            entity.Property(e => e.TotTarjCaja).HasColumnName("TotTarj_Caja");
            entity.Property(e => e.TotTarjSist).HasColumnName("TotTarj_Sist");
            entity.Property(e => e.TotTransfCaja).HasColumnName("TotTransf_Caja");
            entity.Property(e => e.TotTransfSist).HasColumnName("TotTransf_Sist");
        });

        modelBuilder.Entity<SmmTransformacione>(entity =>
        {
            entity.HasKey(e => e.SmmTransformacionId);

            entity.ToTable("SMM_Transformaciones");

            entity.Property(e => e.SmmTransformacionId).HasColumnName("SMM_TransformacionID");
            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("Site_ID");
        });

        modelBuilder.Entity<SmmVentaPersonal>(entity =>
        {
            entity.HasKey(e => e.IdVenta);

            entity.ToTable("SMM_VentaPersonal");

            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompra).HasColumnType("datetime");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RunCliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalCompra).HasComputedColumnSql("([dbo].[TotalVentaCliente]([Id_Venta]))", false);
        });

        modelBuilder.Entity<SmmVentaPersonalDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdVenta, e.CodProducto, e.UniMedida });

            entity.ToTable("SMM_VentaPersonal_Detalle");

            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cod_Producto");
            entity.Property(e => e.UniMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodBarra).IsUnicode(false);
            entity.Property(e => e.Producto).IsUnicode(false);
            entity.Property(e => e.Total).HasComputedColumnSql("(round([Cantidad]*[Precio]-(([Cantidad]*[Precio])*isnull([Descuento],(0)))/(100),(0)))", false);
        });

        modelBuilder.Entity<SmmVwClientesOrdenVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_CLIENTES_ORDEN_VENTAS");

            entity.Property(e => e.RutCliente).HasMaxLength(50);
        });

        modelBuilder.Entity<SmmVwDeptoVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DeptoVentas");

            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwDetalleCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DETALLE_CLIENTE");

            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DireccionEnvio).IsUnicode(false);
            entity.Property(e => e.DireccionFact).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.RunCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwDetallePago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DETALLE_PAGO");

            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaDocumento).HasColumnType("datetime");
            entity.Property(e => e.NBoucher).HasColumnName("nBoucher");
            entity.Property(e => e.Ncheque).HasColumnName("NCheque");
            entity.Property(e => e.Ntarjeta)
                .IsUnicode(false)
                .HasColumnName("NTarjeta");
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoPago)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoVenta)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwDetallePreventum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DETALLE_PREVENTA");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.Producto).IsUnicode(false);
            entity.Property(e => e.UniMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwDetalleRecepcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DetalleRecepcion");

            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.NumDocSap).HasColumnName("NumDocSAP");
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ReceptionDocNumber).HasColumnName("Reception_DocNumber");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.ReceptionNote)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("Reception_Note");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.TipoDocSap).HasColumnName("TipoDocSAP");
        });

        modelBuilder.Entity<SmmVwDetalleRecepcionTransferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DetalleRecepcion_Transferencia");

            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.NumDocSap).HasColumnName("NumDocSAP");
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ReceptionDocNumber).HasColumnName("Reception_DocNumber");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.ReceptionNote)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("Reception_Note");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.TipoDocSap).HasColumnName("TipoDocSAP");
        });

        modelBuilder.Entity<SmmVwDirDespachoOrdenVentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DIR_DESPACHO_ORDEN_VENTA");

            entity.Property(e => e.RutCliente).HasMaxLength(50);
        });

        modelBuilder.Entity<SmmVwDirFacturacionOrdenVentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DIR_FACTURACION_ORDEN_VENTA");

            entity.Property(e => e.RutCliente).HasMaxLength(50);
        });

        modelBuilder.Entity<SmmVwDocAjustada>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DocAjustadas");

            entity.Property(e => e.Codproducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAjuste).HasColumnType("datetime");
            entity.Property(e => e.NomProd).IsUnicode(false);
            entity.Property(e => e.PreventaId).HasColumnName("PreventaID");
            entity.Property(e => e.UsuarioSistema)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwDuplicadosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_DuplicadosInventario");

            entity.Property(e => e.Dun14).IsUnicode(false);
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
        });

        modelBuilder.Entity<SmmVwExpedicionDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_ExpedicionDetalle");

            entity.Property(e => e.AvgPrice).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");
            entity.Property(e => e.ExpeditionMotivo).HasColumnName("Expedition_Motivo");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.SaleCostAc)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
        });

        modelBuilder.Entity<SmmVwExpeditionDetailLotSync>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_ExpeditionDetailLotSync");

            entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<SmmVwExpeditiondetailexport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_EXPEDITIONDETAILEXPORT");

            entity.Property(e => e.CantUniTot).HasColumnType("decimal(29, 0)");
            entity.Property(e => e.ExpeditionDetailQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ExpeditionDetail_Quantity");
            entity.Property(e => e.ExpeditionId).HasColumnName("Expedition_Id");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.UomCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwInfArqueocaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_INF_ARQUEOCAJA");

            entity.Property(e => e.FechArqCaja).HasColumnName("FechArq_Caja");
            entity.Property(e => e.Observacion).IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwInfInventarioSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_INF_INVENTARIO_SMM");

            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwInfInventarioxUserSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_INF_INVENTARIOxUSER_SMM");

            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwInfoClientePreventum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_INFO_CLIENTE_PREVENTA");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("E_Mail");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.RutCliente)
                .HasMaxLength(32)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwInventarioCantidadDiferente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_InventarioCantidadDiferente");

            entity.Property(e => e.CantidadSistema)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cantidad Sistema");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dun14).IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.LoteSistema)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<SmmVwMontoEfectivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_MontoEfectivo");

            entity.Property(e => e.PreventaId).HasColumnName("preventa_id");
        });

        modelBuilder.Entity<SmmVwMontoEfectivoNc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_MontoEfectivoNC");

            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
        });

        modelBuilder.Entity<SmmVwMontoNotaCredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_MontoNotaCredito");

            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<SmmVwMontoNotaCreditoPrueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_MontoNotaCreditoPrueba");

            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<SmmVwNotacreditoDetalleCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_NOTACREDITO_DETALLE_CLIENTE");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DireccionDespacho)
                .IsUnicode(false)
                .HasColumnName("Direccion_Despacho");
            entity.Property(e => e.DireccionFacturacion)
                .IsUnicode(false)
                .HasColumnName("Direccion_Facturacion");
            entity.Property(e => e.FechaCreacionRegistoNota).HasColumnType("datetime");
            entity.Property(e => e.FechaDocumento).HasColumnType("datetime");
            entity.Property(e => e.IdNotaCredito)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_NotaCredito");
            entity.Property(e => e.NombreCliente).IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoNc).HasColumnName("TipoNC");
        });

        modelBuilder.Entity<SmmVwNotacreditoDetalleCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_NOTACREDITO_DETALLE_COMPRA");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Total).HasColumnType("decimal(37, 0)");
        });

        modelBuilder.Entity<SmmVwNotacreditoDetallePago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_NOTACREDITO_DETALLE_PAGO");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdDetallePagoNota).HasColumnName("ID_Detalle_PagoNota");
            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
        });

        modelBuilder.Entity<SmmVwPickingConsolidado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_PICKING_CONSOLIDADO");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.DeptoVentas)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwProductoPreventaTodosLs11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_PRODUCTO_PREVENTA_TODOS_LS11");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwProductosCotizacionCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_Productos_Cotizacion_Cajas");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<SmmVwRecepcionDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_RecepcionDetalle");

            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.NumDocSap).HasColumnName("NumDocSAP");
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ReceptionDocNumber).HasColumnName("Reception_DocNumber");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.ReceptionNote)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("Reception_Note");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.TipoDocSap).HasColumnName("TipoDocSAP");
        });

        modelBuilder.Entity<SmmVwTipoPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TipoPago");

            entity.Property(e => e.PreventaId).HasColumnName("preventa_id");
        });

        modelBuilder.Entity<SmmVwTotalConsolidadoPicking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TOTAL_CONSOLIDADO_PICKING");

            entity.Property(e => e.FechaConsolidado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Consolidado");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwTotaldocumentoorigen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TOTALDOCUMENTOORIGEN");

            entity.Property(e => e.DocSubType)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Totalineas)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TOTALINEAS");
        });

        modelBuilder.Entity<SmmVwTransferDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TransferDetail");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<SmmVwTrazabilidadBultosConReserva>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TRAZABILIDAD_BULTOS_CON_RESERVA");

            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Npallet)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PackageReserveQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_ReserveQuantity");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<SmmVwTrazabilidadBusquedum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TRAZABILIDAD_BUSQUEDA");

            entity.Property(e => e.CantInicial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CantReserva).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodBarr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Frecepcion)
                .HasColumnType("datetime")
                .HasColumnName("FRecepcion");
            entity.Property(e => e.Info1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Info2).IsUnicode(false);
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npallet)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("NPallet");
            entity.Property(e => e.Nrecepcion).HasColumnName("NRecepcion");
            entity.Property(e => e.PackageExpiresDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ExpiresDate");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageInDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_InDate");
            entity.Property(e => e.PackageOutDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_OutDate");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwTrazabilidadPallet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_TRAZABILIDAD_PALLET");

            entity.Property(e => e.ArticleDescription)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("Article_Description");
            entity.Property(e => e.Bodega)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CantidadInicial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Entidad)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Identidad).HasColumnName("IDentidad");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Npallet)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NPallet");
            entity.Property(e => e.Operacion).HasMaxLength(178);
            entity.Property(e => e.PackageExpiresDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ExpiresDate");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.ReceptionNote)
                .HasMaxLength(2550)
                .HasColumnName("Reception_Note");
            entity.Property(e => e.Tipo)
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmmVwVwDiferenciasDuplicado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMM_VW_VW_DiferenciasDuplicados");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dun14).IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioDetId).HasColumnName("InventarioDet_Id");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
        });

        modelBuilder.Entity<SmmsolicitudTransferenciaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetSolicitud);

            entity.ToTable("SMMSolicitudTransferencia_Detalles");

            entity.Property(e => e.IdDetSolicitud).HasColumnName("Id_Det_Solicitud");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK_Transfer_1");

            entity.ToTable("Transfer");

            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteIdDestiny).HasColumnName("Site_Id_Destiny");
            entity.Property(e => e.TransferComentario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Transfer_Comentario");
            entity.Property(e => e.TransferEntidad).HasColumnName("Transfer_Entidad");
            entity.Property(e => e.TransferFechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_FechaCierre");
            entity.Property(e => e.TransferFolioEntidad).HasColumnName("Transfer_Folio_Entidad");
        });

        modelBuilder.Entity<TransferDetail>(entity =>
        {
            entity.HasKey(e => new { e.SiteId, e.TransferId, e.PackageId });

            entity.ToTable("Transfer_Detail");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LayoutIdActual).HasColumnName("Layout_Id_Actual");
            entity.Property(e => e.PackageConfirm).HasColumnName("Package_Confirm");
            entity.Property(e => e.PackageQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_Quantity");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.Error).IsUnicode(false);
            entity.Property(e => e.FecharError).HasColumnType("datetime");
            entity.Property(e => e.IdLog)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_log");
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwCalculoMontoVentaSinRedondeo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Calculo_monto_venta_sin_Redondeo");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwCalculoMontoVentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Calculo_monto_venta");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwClientesOvXamarin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ClientesOV_Xamarin");
        });

        modelBuilder.Entity<VwDatosPackageXamrin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DATOS_PACKAGE_XAMRIN");

            entity.Property(e => e.FechaProduccion).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.LayoutId).HasColumnName("Layout_Id");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.PackageLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Package_Lot");
            entity.Property(e => e.PackageQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Package_Quantity");
            entity.Property(e => e.PackageSscc)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("Package_SSCC");
            entity.Property(e => e.SiteDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Site_Description");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<VwDepartamentosVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DEPARTAMENTOS_VENTAS");

            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<VwDireccionesClientesSap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DIRECCIONES_CLIENTES_SAP");

            entity.Property(e => e.AdresType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.CodDireccion)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.County)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Direccioncompleta)
                .HasMaxLength(304)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<VwListTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LIST_TRANSFER");

            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
            entity.Property(e => e.SiteIdDestiny).HasColumnName("Site_Id_Destiny");
            entity.Property(e => e.TransferId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<VwListadoProductosSolicitud>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_LISTADO_PRODUCTOS_SOLICITUD");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<VwMontoNotacredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MONTO_NOTACREDITO");

            entity.Property(e => e.IdNotaCredito).HasColumnName("ID_NotaCredito");
            entity.Property(e => e.MontoCompra).HasColumnType("decimal(38, 0)");
        });

        modelBuilder.Entity<VwMontoVentaSinRedondeoSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MONTO_VENTA_SIN_REDONDEO_SMM");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwMontoVentaSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MONTO_VENTA_SMM");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwPackCajasSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PACK_CAJAS_SMM");

            entity.Property(e => e.Cantidad).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.CodPadre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Costo).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<VwPromoTotalxProvee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Promo_TotalxProvee");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.Total).HasColumnType("decimal(38, 6)");
        });

        modelBuilder.Entity<VwRecepcionResumenSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RecepcionResumenSMM");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.UniTotal).HasColumnType("decimal(38, 0)");
        });

        modelBuilder.Entity<VwRptCotizacionCajasKit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_RPT_COTIZACION_CAJAS_KIT");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CotizacionId).HasColumnName("Cotizacion_Id");
            entity.Property(e => e.FechaCotizacion).HasColumnType("datetime");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.NomCaja)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.NombreCliente)
                .IsUnicode(false)
                .HasColumnName("Nombre_Cliente");
        });

        modelBuilder.Entity<VwRptPalletEnSala>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_Rpt_PalletEnSala");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetProducto).IsUnicode(false);
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.IdRegPallet).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwSmmClientesDescPromo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_ClientesDescPromo");

            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalCom).HasColumnName("totalCom");
        });

        modelBuilder.Entity<VwSmmClientesTicketPromo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_ClientesTicket_PROMO");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
        });

        modelBuilder.Entity<VwSmmConsolidadoCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_ConsolidadoCompras");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProveedor)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Producto)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.SaldoSap).HasColumnName("SaldoSAP");
            entity.Property(e => e.StockSap).HasColumnName("StockSAP");
        });

        modelBuilder.Entity<VwSmmDatoClientesNotacredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_DATO_CLIENTES_NOTACREDITO");

            entity.Property(e => e.CardCode)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.CardName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.DireccionDespacho)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("Direccion_Despacho");
            entity.Property(e => e.DireccionFacturacion)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("Direccion_Facturacion");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocSubType)
                .HasMaxLength(2)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
        });

        modelBuilder.Entity<VwSmmDatoProductosNotacredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_DATO_PRODUCTOS_NOTACREDITO");

            entity.Property(e => e.Descuento).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Dscription)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Price).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Quantity).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Total).HasColumnType("numeric(19, 6)");
        });

        modelBuilder.Entity<VwSmmDiferenciasDuplicadosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_DiferenciasDuplicados_inventario");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.InventarioDetId).HasColumnName("InventarioDet_Id");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Npallet).HasColumnName("NPallet");
            entity.Property(e => e.TipoEmpaque)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSmmFoliosSolicitudTransferencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_FOLIOS_SOLICITUD_TRANSFERENCIAS");

            entity.Property(e => e.IdSolicitud)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Solicitud");
        });

        modelBuilder.Entity<VwSmmInventarioCantidadDiferenteInf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_InventarioCantidadDiferenteInf");

            entity.Property(e => e.BodegaInv)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BodegaSist)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CantSistema).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CodBarInv).IsUnicode(false);
            entity.Property(e => e.CodBarSist)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProdInv)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProdSist).HasMaxLength(50);
            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodUbicacionSist).HasColumnName("codUbicacionSist");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.InventarioId).HasColumnName("Inventario_Id");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.PackageSscc).HasColumnName("Package_SSCC");
            entity.Property(e => e.TipoEmpSist)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoEmpaqueInv)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSmmVencimientoProyectadoBma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SMM_VencimientoProyectadoBmas");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Costo).HasColumnType("decimal(38, 0)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.UCategoria)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS")
                .HasColumnName("U_Categoria");
        });

        modelBuilder.Entity<VwStockFechaRecepcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_STOCK_FECHA_RECEPCION");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.ReceptionId).HasColumnName("Reception_Id");
            entity.Property(e => e.SiteId).HasColumnName("Site_Id");
        });

        modelBuilder.Entity<VwStockFechaTransferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_STOCK_FECHA_TRANSFERENCIA");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.PackageProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("Package_ProductionDate");
            entity.Property(e => e.SiteIdDestiny).HasColumnName("Site_Id_Destiny");
            entity.Property(e => e.TransferId).HasColumnName("Transfer_Id");
        });

        modelBuilder.Entity<VwStockSmm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_STOCK_SMM");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CantidadInicial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodProducto).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP850_CI_AS");
            entity.Property(e => e.DocType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fproduccion).HasColumnName("FProduccion");
            entity.Property(e => e.Frecepcion).HasColumnName("FRecepcion");
            entity.Property(e => e.Fvencimiento).HasColumnName("FVencimiento");
            entity.Property(e => e.LayoutDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Layout_Description");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Npallet)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Nrecepcion).HasColumnName("NRecepcion");
            entity.Property(e => e.PackageId).HasColumnName("Package_Id");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTotalCantReqCotizacionKit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TotalCant_Req_Cotizacion_Kit");

            entity.Property(e => e.CodProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTotalPreventum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_total_Preventa");

            entity.Property(e => e.PreventaId).HasColumnName("Preventa_ID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("total");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
