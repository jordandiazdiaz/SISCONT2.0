﻿namespace Presentacion
{
    partial class FrmProgramaLibrosElectronicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRutaTXT = new System.Windows.Forms.TextBox();
            this.btnGenerarTXT = new System.Windows.Forms.Button();
            this.btnCargarCarpeta = new System.Windows.Forms.Button();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRuc = new System.Windows.Forms.TextBox();
            this.txtNombreAnio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRegistroCompras = new System.Windows.Forms.DataGridView();
            this.spallcurrentmonthcomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRegistroCompras = new Presentacion.DSRegistroCompras();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRegistroVentas = new System.Windows.Forms.DataGridView();
            this.spallmonthventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRegistroVentas = new Presentacion.DSRegistroVentas();
            this.sp_all_current_month_comprasTableAdapter = new Presentacion.DSRegistroComprasTableAdapters.sp_all_current_month_comprasTableAdapter();
            this.sp_all_month_ventasTableAdapter = new Presentacion.DSRegistroVentasTableAdapters.sp_all_month_ventasTableAdapter();
            this.ventasId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ventasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasValorExportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalExonerada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalInafecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDolaresConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgvRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuentaDestinoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDetraccionSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNoGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConversionDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPercepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionBco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRegistros.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spallcurrentmonthcomprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRegistroCompras)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spallmonthventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRegistroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNombreMes);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreRuc);
            this.panel1.Controls.Add(this.txtNombreAnio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 58);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtRutaTXT);
            this.panel2.Controls.Add(this.btnGenerarTXT);
            this.panel2.Controls.Add(this.btnCargarCarpeta);
            this.panel2.Location = new System.Drawing.Point(854, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 58);
            this.panel2.TabIndex = 5;
            // 
            // txtRutaTXT
            // 
            this.txtRutaTXT.Location = new System.Drawing.Point(21, 18);
            this.txtRutaTXT.Name = "txtRutaTXT";
            this.txtRutaTXT.ReadOnly = true;
            this.txtRutaTXT.Size = new System.Drawing.Size(150, 20);
            this.txtRutaTXT.TabIndex = 5;
            this.txtRutaTXT.Text = "C:\\Users\\Public\\Documents\\";
            // 
            // btnGenerarTXT
            // 
            this.btnGenerarTXT.BackColor = System.Drawing.Color.Teal;
            this.btnGenerarTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTXT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerarTXT.Location = new System.Drawing.Point(284, 16);
            this.btnGenerarTXT.Name = "btnGenerarTXT";
            this.btnGenerarTXT.Size = new System.Drawing.Size(92, 22);
            this.btnGenerarTXT.TabIndex = 1;
            this.btnGenerarTXT.Text = "Generar TXT";
            this.btnGenerarTXT.UseVisualStyleBackColor = false;
            this.btnGenerarTXT.Click += new System.EventHandler(this.btnGenerarTXT_Click);
            // 
            // btnCargarCarpeta
            // 
            this.btnCargarCarpeta.BackColor = System.Drawing.Color.Aqua;
            this.btnCargarCarpeta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCargarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCarpeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarCarpeta.Location = new System.Drawing.Point(170, 18);
            this.btnCargarCarpeta.Name = "btnCargarCarpeta";
            this.btnCargarCarpeta.Size = new System.Drawing.Size(34, 20);
            this.btnCargarCarpeta.TabIndex = 6;
            this.btnCargarCarpeta.Text = "***";
            this.btnCargarCarpeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarCarpeta.UseVisualStyleBackColor = false;
            this.btnCargarCarpeta.Click += new System.EventHandler(this.btnCargarCarpeta_Click);
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(190, 20);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(68, 20);
            this.txtNombreMes.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(264, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 22);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Año";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreRuc
            // 
            this.txtNombreRuc.Location = new System.Drawing.Point(10, 20);
            this.txtNombreRuc.Name = "txtNombreRuc";
            this.txtNombreRuc.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRuc.TabIndex = 7;
            // 
            // txtNombreAnio
            // 
            this.txtNombreAnio.Location = new System.Drawing.Point(116, 20);
            this.txtNombreAnio.Name = "txtNombreAnio";
            this.txtNombreAnio.Size = new System.Drawing.Size(68, 20);
            this.txtNombreAnio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "RUC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRegistros.Controls.Add(this.tabCompras);
            this.tabRegistros.Controls.Add(this.tabVentas);
            this.tabRegistros.Location = new System.Drawing.Point(12, 65);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(1244, 602);
            this.tabRegistros.TabIndex = 3;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.panel4);
            this.tabCompras.Controls.Add(this.panel3);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(1236, 576);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "Compras";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvRegistroCompras);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1224, 504);
            this.panel4.TabIndex = 4;
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.AutoGenerateColumns = false;
            this.dgvRegistroCompras.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprasID,
            this.comprasMes,
            this.comprasNumeroRegistro,
            this.comprasFechaEmision,
            this.comprasFechaPago,
            this.comprasCdpTipo,
            this.comprasCdpSerie,
            this.comprasCdpNumeroDocumento,
            this.comprasProveedorTipo,
            this.comprasProveedorNumeroDocumento,
            this.comprasProveedorTipoDocumento,
            this.comprasProveedorRazonSocial,
            this.comprasCuenta,
            this.comprasDescripcion,
            this.comprasBaseImponible,
            this.comprasIgv,
            this.comprasNoGravada,
            this.comprasDescuento,
            this.comprasImporteTotal,
            this.comprasDolares,
            this.comprasTipoCambio,
            this.comprasConversionDolares,
            this.comprasPercepcion,
            this.comprasDestino,
            this.comprasDescripcionDestino,
            this.comprasCuentaDestino,
            this.comprasPago,
            this.comprasCodigo,
            this.comprasConstanciaNumero,
            this.comprasConstanciaFechaPago,
            this.comprasConstanciaMonto,
            this.comprasConstanciaReferencia,
            this.BancarizacionFecha,
            this.BancarizacionBco,
            this.BancarizacionOperacion,
            this.comprasReferenciaFecha,
            this.comprasReferenciaTipo,
            this.comprasReferenciaSerie,
            this.comprasReferenciaNumero});
            this.dgvRegistroCompras.DataSource = this.spallcurrentmonthcomprasBindingSource;
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1224, 504);
            this.dgvRegistroCompras.TabIndex = 0;
            this.dgvRegistroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellEndEdit);
            this.dgvRegistroCompras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.dgvRegistroCompras.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCompras_DefaultValuesNeeded);
            this.dgvRegistroCompras.TabIndexChanged += new System.EventHandler(this.tabIndexChangedEvent);
            this.dgvRegistroCompras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegistroCompras_KeyDown);
            // 
            // spallcurrentmonthcomprasBindingSource
            // 
            this.spallcurrentmonthcomprasBindingSource.DataMember = "sp_all_current_month_compras";
            this.spallcurrentmonthcomprasBindingSource.DataSource = this.dSRegistroCompras;
            // 
            // dSRegistroCompras
            // 
            this.dSRegistroCompras.DataSetName = "DSRegistroCompras";
            this.dSRegistroCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnGuardarCompras);
            this.panel3.Controls.Add(this.btnEliminarCompras);
            this.panel3.Location = new System.Drawing.Point(6, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1224, 54);
            this.panel3.TabIndex = 3;
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompras.Location = new System.Drawing.Point(15, 17);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarCompras.TabIndex = 0;
            this.btnGuardarCompras.Text = "Guardar";
            this.btnGuardarCompras.UseVisualStyleBackColor = false;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCompras.Location = new System.Drawing.Point(142, 17);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarCompras.TabIndex = 0;
            this.btnEliminarCompras.Text = "Eliminar";
            this.btnEliminarCompras.UseVisualStyleBackColor = false;
            this.btnEliminarCompras.Click += new System.EventHandler(this.btnEliminarCompras_Click);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.panel6);
            this.tabVentas.Controls.Add(this.panel5);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(1236, 576);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btnEliminarVentas);
            this.panel6.Controls.Add(this.btnGuardarVentas);
            this.panel6.Location = new System.Drawing.Point(6, 516);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1227, 54);
            this.panel6.TabIndex = 4;
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.Color.Red;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVentas.Location = new System.Drawing.Point(152, 17);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarVentas.TabIndex = 2;
            this.btnEliminarVentas.Text = "Eliminar";
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVentas.Location = new System.Drawing.Point(15, 17);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(119, 23);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar";
            this.btnGuardarVentas.UseVisualStyleBackColor = false;
            this.btnGuardarVentas.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvRegistroVentas);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1227, 496);
            this.panel5.TabIndex = 2;
            // 
            // dgvRegistroVentas
            // 
            this.dgvRegistroVentas.AutoGenerateColumns = false;
            this.dgvRegistroVentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventasId,
            this.ventasMes,
            this.ventasNumeroRegistro,
            this.ventasFechaEmision,
            this.ventasFechapago,
            this.ventasCdpTipo,
            this.ventasCdpSerie,
            this.ventasCdpNumero,
            this.ventasProveedorTipo,
            this.ventasProveedorNumero,
            this.ventasProveedorRazonSocial,
            this.ventasCuenta,
            this.ventasDescripcion,
            this.ventasValorExportacion,
            this.ventasBaseImponible,
            this.ventasImporteTotalExonerada,
            this.ventasImporteTotalInafecta,
            this.ventasIgv,
            this.ventasImporteTotal,
            this.ventasTipoCambio,
            this.ventasDolares,
            this.ventasDolaresConversion,
            this.ventasIgvRetencion,
            this.ventasCuentaDestino,
            this.ventasCuentaDestinoDescripcion,
            this.ventasPago,
            this.ventasReferenciaFecha,
            this.ventasReferenciaTipo,
            this.ventasReferenciaSerie,
            this.ventasReferenciaNumero,
            this.ventasCodigo,
            this.ventasConstanciaNumero,
            this.ventasConstanciaFechaPago,
            this.ventasDetraccionSoles,
            this.ventasReferencia,
            this.ventasObservacion});
            this.dgvRegistroVentas.DataSource = this.spallmonthventasBindingSource;
            this.dgvRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRegistroVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroVentas.Name = "dgvRegistroVentas";
            this.dgvRegistroVentas.Size = new System.Drawing.Size(1227, 496);
            this.dgvRegistroVentas.TabIndex = 1;
            this.dgvRegistroVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVentas_CellEndEdit);
            this.dgvRegistroVentas.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvVentas_DefaultValuesNeeded);
            // 
            // spallmonthventasBindingSource
            // 
            this.spallmonthventasBindingSource.DataMember = "sp_all_month_ventas";
            this.spallmonthventasBindingSource.DataSource = this.dSRegistroVentas;
            // 
            // dSRegistroVentas
            // 
            this.dSRegistroVentas.DataSetName = "DSRegistroVentas";
            this.dSRegistroVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_all_current_month_comprasTableAdapter
            // 
            this.sp_all_current_month_comprasTableAdapter.ClearBeforeFill = true;
            // 
            // sp_all_month_ventasTableAdapter
            // 
            this.sp_all_month_ventasTableAdapter.ClearBeforeFill = true;
            // 
            // ventasId
            // 
            this.ventasId.DataPropertyName = "idLibroVentas";
            this.ventasId.HeaderText = "#";
            this.ventasId.Name = "ventasId";
            this.ventasId.ReadOnly = true;
            this.ventasId.Width = 40;
            // 
            // ventasMes
            // 
            this.ventasMes.DataPropertyName = "Mes";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Aqua;
            this.ventasMes.DefaultCellStyle = dataGridViewCellStyle11;
            this.ventasMes.HeaderText = "Mes";
            this.ventasMes.Name = "ventasMes";
            // 
            // ventasNumeroRegistro
            // 
            this.ventasNumeroRegistro.DataPropertyName = "NReg";
            this.ventasNumeroRegistro.HeaderText = "N° Registro";
            this.ventasNumeroRegistro.Name = "ventasNumeroRegistro";
            // 
            // ventasFechaEmision
            // 
            this.ventasFechaEmision.DataPropertyName = "FechaEmision";
            this.ventasFechaEmision.HeaderText = "Fecha de Emisión";
            this.ventasFechaEmision.Name = "ventasFechaEmision";
            // 
            // ventasFechapago
            // 
            this.ventasFechapago.DataPropertyName = "FechaPago";
            this.ventasFechapago.HeaderText = "Fecha de Pago";
            this.ventasFechapago.Name = "ventasFechapago";
            // 
            // ventasCdpTipo
            // 
            this.ventasCdpTipo.DataPropertyName = "CTipo";
            this.ventasCdpTipo.HeaderText = "Comprobante Tipo";
            this.ventasCdpTipo.Name = "ventasCdpTipo";
            this.ventasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ventasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ventasCdpSerie
            // 
            this.ventasCdpSerie.DataPropertyName = "CSerie";
            this.ventasCdpSerie.HeaderText = "Comprobante Serie";
            this.ventasCdpSerie.Name = "ventasCdpSerie";
            // 
            // ventasCdpNumero
            // 
            this.ventasCdpNumero.DataPropertyName = "CNDocumento";
            this.ventasCdpNumero.HeaderText = "Comprobante Número Documento";
            this.ventasCdpNumero.Name = "ventasCdpNumero";
            // 
            // ventasProveedorTipo
            // 
            this.ventasProveedorTipo.DataPropertyName = "PTipo";
            this.ventasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.ventasProveedorTipo.Name = "ventasProveedorTipo";
            // 
            // ventasProveedorNumero
            // 
            this.ventasProveedorNumero.DataPropertyName = "PNumero";
            this.ventasProveedorNumero.HeaderText = "Proveedor Numero Documento";
            this.ventasProveedorNumero.Name = "ventasProveedorNumero";
            // 
            // ventasProveedorRazonSocial
            // 
            this.ventasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.ventasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.ventasProveedorRazonSocial.Name = "ventasProveedorRazonSocial";
            // 
            // ventasCuenta
            // 
            this.ventasCuenta.DataPropertyName = "Cuenta";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Aqua;
            this.ventasCuenta.DefaultCellStyle = dataGridViewCellStyle12;
            this.ventasCuenta.HeaderText = "Cuenta";
            this.ventasCuenta.Name = "ventasCuenta";
            // 
            // ventasDescripcion
            // 
            this.ventasDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Aqua;
            this.ventasDescripcion.DefaultCellStyle = dataGridViewCellStyle13;
            this.ventasDescripcion.HeaderText = "Descripción";
            this.ventasDescripcion.Name = "ventasDescripcion";
            // 
            // ventasValorExportacion
            // 
            this.ventasValorExportacion.DataPropertyName = "ValorExportacion";
            this.ventasValorExportacion.HeaderText = "Valor de Exportación";
            this.ventasValorExportacion.Name = "ventasValorExportacion";
            // 
            // ventasBaseImponible
            // 
            this.ventasBaseImponible.DataPropertyName = "BaseImponible";
            this.ventasBaseImponible.HeaderText = "Base Imponible";
            this.ventasBaseImponible.Name = "ventasBaseImponible";
            // 
            // ventasImporteTotalExonerada
            // 
            this.ventasImporteTotalExonerada.DataPropertyName = "ImporteTotalExonerada";
            this.ventasImporteTotalExonerada.HeaderText = "Importe Total Exonerada";
            this.ventasImporteTotalExonerada.Name = "ventasImporteTotalExonerada";
            // 
            // ventasImporteTotalInafecta
            // 
            this.ventasImporteTotalInafecta.DataPropertyName = "ImporteTotalInafecta";
            this.ventasImporteTotalInafecta.HeaderText = "Importe Total Inafecta";
            this.ventasImporteTotalInafecta.Name = "ventasImporteTotalInafecta";
            // 
            // ventasIgv
            // 
            this.ventasIgv.DataPropertyName = "IGV";
            this.ventasIgv.HeaderText = "IGV";
            this.ventasIgv.Name = "ventasIgv";
            // 
            // ventasImporteTotal
            // 
            this.ventasImporteTotal.DataPropertyName = "ImporteTotal";
            this.ventasImporteTotal.HeaderText = "Importe Total";
            this.ventasImporteTotal.Name = "ventasImporteTotal";
            // 
            // ventasTipoCambio
            // 
            this.ventasTipoCambio.DataPropertyName = "TC";
            this.ventasTipoCambio.HeaderText = "Tipo de Cambio";
            this.ventasTipoCambio.Name = "ventasTipoCambio";
            // 
            // ventasDolares
            // 
            this.ventasDolares.DataPropertyName = "Dolares";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Aqua;
            this.ventasDolares.DefaultCellStyle = dataGridViewCellStyle14;
            this.ventasDolares.HeaderText = "Dólares";
            this.ventasDolares.Name = "ventasDolares";
            // 
            // ventasDolaresConversion
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Aqua;
            this.ventasDolaresConversion.DefaultCellStyle = dataGridViewCellStyle15;
            this.ventasDolaresConversion.HeaderText = "Dolares Conversión";
            this.ventasDolaresConversion.Name = "ventasDolaresConversion";
            this.ventasDolaresConversion.ReadOnly = true;
            // 
            // ventasIgvRetencion
            // 
            this.ventasIgvRetencion.DataPropertyName = "IgvRetencion";
            this.ventasIgvRetencion.HeaderText = "IGV Retención";
            this.ventasIgvRetencion.Name = "ventasIgvRetencion";
            // 
            // ventasCuentaDestino
            // 
            this.ventasCuentaDestino.DataPropertyName = "CuentaDestino";
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Aqua;
            this.ventasCuentaDestino.DefaultCellStyle = dataGridViewCellStyle16;
            this.ventasCuentaDestino.HeaderText = "Cuenta Destino";
            this.ventasCuentaDestino.Name = "ventasCuentaDestino";
            // 
            // ventasCuentaDestinoDescripcion
            // 
            this.ventasCuentaDestinoDescripcion.DataPropertyName = "CuentaDestinoDescripcion";
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Aqua;
            this.ventasCuentaDestinoDescripcion.DefaultCellStyle = dataGridViewCellStyle17;
            this.ventasCuentaDestinoDescripcion.HeaderText = "Cuenta Destino Descripción";
            this.ventasCuentaDestinoDescripcion.Name = "ventasCuentaDestinoDescripcion";
            // 
            // ventasPago
            // 
            this.ventasPago.DataPropertyName = "Pago";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Aqua;
            this.ventasPago.DefaultCellStyle = dataGridViewCellStyle18;
            this.ventasPago.HeaderText = "Pago";
            this.ventasPago.Name = "ventasPago";
            // 
            // ventasReferenciaFecha
            // 
            this.ventasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
            this.ventasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.ventasReferenciaFecha.Name = "ventasReferenciaFecha";
            // 
            // ventasReferenciaTipo
            // 
            this.ventasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
            this.ventasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.ventasReferenciaTipo.Name = "ventasReferenciaTipo";
            // 
            // ventasReferenciaSerie
            // 
            this.ventasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
            this.ventasReferenciaSerie.HeaderText = "Referencia Serie";
            this.ventasReferenciaSerie.Name = "ventasReferenciaSerie";
            // 
            // ventasReferenciaNumero
            // 
            this.ventasReferenciaNumero.DataPropertyName = "ReferenciaNumeroDocumento";
            this.ventasReferenciaNumero.HeaderText = "Referencia Número";
            this.ventasReferenciaNumero.Name = "ventasReferenciaNumero";
            // 
            // ventasCodigo
            // 
            this.ventasCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Aqua;
            this.ventasCodigo.DefaultCellStyle = dataGridViewCellStyle19;
            this.ventasCodigo.HeaderText = "Código";
            this.ventasCodigo.Name = "ventasCodigo";
            // 
            // ventasConstanciaNumero
            // 
            this.ventasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.ventasConstanciaNumero.HeaderText = "Constancia Número";
            this.ventasConstanciaNumero.Name = "ventasConstanciaNumero";
            // 
            // ventasConstanciaFechaPago
            // 
            this.ventasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.ventasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.ventasConstanciaFechaPago.Name = "ventasConstanciaFechaPago";
            // 
            // ventasDetraccionSoles
            // 
            this.ventasDetraccionSoles.DataPropertyName = "DetraccionSoles";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Aqua;
            this.ventasDetraccionSoles.DefaultCellStyle = dataGridViewCellStyle20;
            this.ventasDetraccionSoles.HeaderText = "Detracción en Soles";
            this.ventasDetraccionSoles.Name = "ventasDetraccionSoles";
            // 
            // ventasReferencia
            // 
            this.ventasReferencia.DataPropertyName = "Referencia";
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Aqua;
            this.ventasReferencia.DefaultCellStyle = dataGridViewCellStyle21;
            this.ventasReferencia.HeaderText = "Referencia";
            this.ventasReferencia.Name = "ventasReferencia";
            // 
            // ventasObservacion
            // 
            this.ventasObservacion.DataPropertyName = "Observacion";
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Aqua;
            this.ventasObservacion.DefaultCellStyle = dataGridViewCellStyle22;
            this.ventasObservacion.HeaderText = "Observación";
            this.ventasObservacion.Name = "ventasObservacion";
            // 
            // comprasID
            // 
            this.comprasID.DataPropertyName = "idLibroCompras";
            this.comprasID.HeaderText = "#";
            this.comprasID.Name = "comprasID";
            this.comprasID.ReadOnly = true;
            this.comprasID.Width = 40;
            // 
            // comprasMes
            // 
            this.comprasMes.DataPropertyName = "Mes";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.comprasMes.DefaultCellStyle = dataGridViewCellStyle1;
            this.comprasMes.HeaderText = "Mes";
            this.comprasMes.Name = "comprasMes";
            this.comprasMes.Width = 40;
            // 
            // comprasNumeroRegistro
            // 
            this.comprasNumeroRegistro.DataPropertyName = "NReg";
            this.comprasNumeroRegistro.HeaderText = "N° Registro";
            this.comprasNumeroRegistro.Name = "comprasNumeroRegistro";
            // 
            // comprasFechaEmision
            // 
            this.comprasFechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.comprasFechaEmision.DefaultCellStyle = dataGridViewCellStyle2;
            this.comprasFechaEmision.HeaderText = "Fecha de Emisión";
            this.comprasFechaEmision.Name = "comprasFechaEmision";
            this.comprasFechaEmision.Width = 80;
            // 
            // comprasFechaPago
            // 
            this.comprasFechaPago.DataPropertyName = "FechaPago";
            this.comprasFechaPago.HeaderText = "Fecha de Pago";
            this.comprasFechaPago.Name = "comprasFechaPago";
            this.comprasFechaPago.Width = 80;
            // 
            // comprasCdpTipo
            // 
            this.comprasCdpTipo.DataPropertyName = "CTipo";
            this.comprasCdpTipo.HeaderText = "Comprobante Tipo";
            this.comprasCdpTipo.Name = "comprasCdpTipo";
            this.comprasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comprasCdpTipo.Width = 120;
            // 
            // comprasCdpSerie
            // 
            this.comprasCdpSerie.DataPropertyName = "CSerie";
            this.comprasCdpSerie.HeaderText = "Comprobante Serie";
            this.comprasCdpSerie.Name = "comprasCdpSerie";
            // 
            // comprasCdpNumeroDocumento
            // 
            this.comprasCdpNumeroDocumento.DataPropertyName = "CNDocumento";
            this.comprasCdpNumeroDocumento.HeaderText = "Comprobante Número Documento";
            this.comprasCdpNumeroDocumento.Name = "comprasCdpNumeroDocumento";
            // 
            // comprasProveedorTipo
            // 
            this.comprasProveedorTipo.DataPropertyName = "PTipo";
            this.comprasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.comprasProveedorTipo.Name = "comprasProveedorTipo";
            // 
            // comprasProveedorNumeroDocumento
            // 
            this.comprasProveedorNumeroDocumento.DataPropertyName = "PNumero";
            this.comprasProveedorNumeroDocumento.HeaderText = "Proveedor Numero Documento";
            this.comprasProveedorNumeroDocumento.Name = "comprasProveedorNumeroDocumento";
            // 
            // comprasProveedorTipoDocumento
            // 
            this.comprasProveedorTipoDocumento.DataPropertyName = "PDocumento";
            this.comprasProveedorTipoDocumento.HeaderText = "Proveedor Tipo Documento";
            this.comprasProveedorTipoDocumento.Name = "comprasProveedorTipoDocumento";
            // 
            // comprasProveedorRazonSocial
            // 
            this.comprasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.comprasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.comprasProveedorRazonSocial.Name = "comprasProveedorRazonSocial";
            this.comprasProveedorRazonSocial.Width = 200;
            // 
            // comprasCuenta
            // 
            this.comprasCuenta.DataPropertyName = "Cuenta";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            this.comprasCuenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.comprasCuenta.HeaderText = "Cuenta";
            this.comprasCuenta.Name = "comprasCuenta";
            // 
            // comprasDescripcion
            // 
            this.comprasDescripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.comprasDescripcion.HeaderText = "Descripción";
            this.comprasDescripcion.Name = "comprasDescripcion";
            // 
            // comprasBaseImponible
            // 
            this.comprasBaseImponible.DataPropertyName = "BaseImponible";
            this.comprasBaseImponible.HeaderText = "Base Imponible";
            this.comprasBaseImponible.Name = "comprasBaseImponible";
            // 
            // comprasIgv
            // 
            this.comprasIgv.DataPropertyName = "IGV";
            this.comprasIgv.HeaderText = "IGV";
            this.comprasIgv.Name = "comprasIgv";
            // 
            // comprasNoGravada
            // 
            this.comprasNoGravada.DataPropertyName = "NoGravada";
            this.comprasNoGravada.HeaderText = "No Gravada";
            this.comprasNoGravada.Name = "comprasNoGravada";
            // 
            // comprasDescuento
            // 
            this.comprasDescuento.DataPropertyName = "Descuentos";
            this.comprasDescuento.HeaderText = "Descuento";
            this.comprasDescuento.Name = "comprasDescuento";
            // 
            // comprasImporteTotal
            // 
            this.comprasImporteTotal.DataPropertyName = "ImporteTotal";
            this.comprasImporteTotal.HeaderText = "Importe Total";
            this.comprasImporteTotal.Name = "comprasImporteTotal";
            // 
            // comprasDolares
            // 
            this.comprasDolares.DataPropertyName = "Dolares";
            this.comprasDolares.HeaderText = "Dolares";
            this.comprasDolares.Name = "comprasDolares";
            // 
            // comprasTipoCambio
            // 
            this.comprasTipoCambio.DataPropertyName = "TipoCambio";
            this.comprasTipoCambio.HeaderText = "Tipo de Cambio";
            this.comprasTipoCambio.Name = "comprasTipoCambio";
            // 
            // comprasConversionDolares
            // 
            this.comprasConversionDolares.DataPropertyName = "ConversionDolar";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            this.comprasConversionDolares.DefaultCellStyle = dataGridViewCellStyle5;
            this.comprasConversionDolares.HeaderText = "Conversión Dólares (S/.)";
            this.comprasConversionDolares.Name = "comprasConversionDolares";
            this.comprasConversionDolares.ReadOnly = true;
            // 
            // comprasPercepcion
            // 
            this.comprasPercepcion.DataPropertyName = "Percepcion";
            this.comprasPercepcion.HeaderText = "Percepción";
            this.comprasPercepcion.Name = "comprasPercepcion";
            // 
            // comprasDestino
            // 
            this.comprasDestino.DataPropertyName = "Destino";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            this.comprasDestino.DefaultCellStyle = dataGridViewCellStyle6;
            this.comprasDestino.HeaderText = "Destino";
            this.comprasDestino.Name = "comprasDestino";
            // 
            // comprasDescripcionDestino
            // 
            this.comprasDescripcionDestino.DataPropertyName = "DescripcionDestino";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Aqua;
            this.comprasDescripcionDestino.DefaultCellStyle = dataGridViewCellStyle7;
            this.comprasDescripcionDestino.HeaderText = "Descripción Destino";
            this.comprasDescripcionDestino.Name = "comprasDescripcionDestino";
            // 
            // comprasCuentaDestino
            // 
            this.comprasCuentaDestino.DataPropertyName = "CuentaDestino";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Aqua;
            this.comprasCuentaDestino.DefaultCellStyle = dataGridViewCellStyle8;
            this.comprasCuentaDestino.HeaderText = "Cuenta Destino";
            this.comprasCuentaDestino.Name = "comprasCuentaDestino";
            // 
            // comprasPago
            // 
            this.comprasPago.DataPropertyName = "Pgo";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Aqua;
            this.comprasPago.DefaultCellStyle = dataGridViewCellStyle9;
            this.comprasPago.HeaderText = "Pago";
            this.comprasPago.Name = "comprasPago";
            // 
            // comprasCodigo
            // 
            this.comprasCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Aqua;
            this.comprasCodigo.DefaultCellStyle = dataGridViewCellStyle10;
            this.comprasCodigo.HeaderText = "Código";
            this.comprasCodigo.Name = "comprasCodigo";
            // 
            // comprasConstanciaNumero
            // 
            this.comprasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.comprasConstanciaNumero.HeaderText = "Constancia Número";
            this.comprasConstanciaNumero.Name = "comprasConstanciaNumero";
            // 
            // comprasConstanciaFechaPago
            // 
            this.comprasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.comprasConstanciaFechaPago.HeaderText = "Constancia de Fecha de Pago";
            this.comprasConstanciaFechaPago.Name = "comprasConstanciaFechaPago";
            this.comprasConstanciaFechaPago.Width = 80;
            // 
            // comprasConstanciaMonto
            // 
            this.comprasConstanciaMonto.DataPropertyName = "ConstanciaMonto";
            this.comprasConstanciaMonto.HeaderText = "Constancia Monto";
            this.comprasConstanciaMonto.Name = "comprasConstanciaMonto";
            // 
            // comprasConstanciaReferencia
            // 
            this.comprasConstanciaReferencia.DataPropertyName = "ConstanciaReferencia";
            this.comprasConstanciaReferencia.HeaderText = "Constancia Referencia";
            this.comprasConstanciaReferencia.Name = "comprasConstanciaReferencia";
            // 
            // BancarizacionFecha
            // 
            this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
            this.BancarizacionFecha.HeaderText = "Bancarizacion Fecha";
            this.BancarizacionFecha.Name = "BancarizacionFecha";
            this.BancarizacionFecha.Width = 80;
            // 
            // BancarizacionBco
            // 
            this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
            this.BancarizacionBco.HeaderText = "Bancarizacion Bco";
            this.BancarizacionBco.Name = "BancarizacionBco";
            // 
            // BancarizacionOperacion
            // 
            this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
            this.BancarizacionOperacion.HeaderText = "Bancarizacion Operacion";
            this.BancarizacionOperacion.Name = "BancarizacionOperacion";
            // 
            // comprasReferenciaFecha
            // 
            this.comprasReferenciaFecha.DataPropertyName = "ReferenciaFecha";
            this.comprasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.comprasReferenciaFecha.Name = "comprasReferenciaFecha";
            // 
            // comprasReferenciaTipo
            // 
            this.comprasReferenciaTipo.DataPropertyName = "ReferenciaTipo";
            this.comprasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.comprasReferenciaTipo.Name = "comprasReferenciaTipo";
            // 
            // comprasReferenciaSerie
            // 
            this.comprasReferenciaSerie.DataPropertyName = "ReferenciaSerie";
            this.comprasReferenciaSerie.HeaderText = "Referencia Serie";
            this.comprasReferenciaSerie.Name = "comprasReferenciaSerie";
            // 
            // comprasReferenciaNumero
            // 
            this.comprasReferenciaNumero.DataPropertyName = "ReferenciaNumero";
            this.comprasReferenciaNumero.HeaderText = "Referencia Numero";
            this.comprasReferenciaNumero.Name = "comprasReferenciaNumero";
            // 
            // FrmProgramaLibrosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabRegistros);
            this.Name = "FrmProgramaLibrosElectronicos";
            this.Text = "Programa Libros Electronicos";
            this.Load += new System.EventHandler(this.FrmProgramaLibrosElectronicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabRegistros.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spallcurrentmonthcomprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRegistroCompras)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spallmonthventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRegistroVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvRegistroVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private DSRegistroCompras dSRegistroCompras;
        private System.Windows.Forms.BindingSource spallcurrentmonthcomprasBindingSource;
        private DSRegistroComprasTableAdapters.sp_all_current_month_comprasTableAdapter sp_all_current_month_comprasTableAdapter;
        private DSRegistroVentas dSRegistroVentas;
        private System.Windows.Forms.BindingSource spallmonthventasBindingSource;
        private DSRegistroVentasTableAdapters.sp_all_month_ventasTableAdapter sp_all_month_ventasTableAdapter;
        private System.Windows.Forms.Button btnGenerarTXT;
        private System.Windows.Forms.TextBox txtRutaTXT;
        private System.Windows.Forms.Button btnCargarCarpeta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRuc;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.TextBox txtNombreAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechapago;
        private System.Windows.Forms.DataGridViewComboBoxColumn ventasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasValorExportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalExonerada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalInafecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDolaresConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgvRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestinoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDetraccionSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaPago;
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNoGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConversionDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPercepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionBco;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasReferenciaNumero;
    }
}