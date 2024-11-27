namespace ProyectoPharmTrack
{
    partial class PedidoProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpInformacionMedicamento = new System.Windows.Forms.GroupBox();
            this.txtTipoMedicamento = new System.Windows.Forms.TextBox();
            this.txtDescripcionMedicamento = new System.Windows.Forms.TextBox();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCantidadPresentacion = new System.Windows.Forms.GroupBox();
            this.txtCantidadEmpaque = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.lblCantidadEmpaque = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.grpInformacionPrecioVenta = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.grpInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.mtxtContacto = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblContactoProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.grpFechasImportantes = new System.Windows.Forms.GroupBox();
            this.mtxtFechaCaducidad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblFechaCaducidad = new System.Windows.Forms.Label();
            this.grpInformacionMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCantidadPresentacion.SuspendLayout();
            this.grpInformacionPrecioVenta.SuspendLayout();
            this.grpInformacionProveedor.SuspendLayout();
            this.grpFechasImportantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PharmTrack";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 101);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(43, 155);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // grpInformacionMedicamento
            // 
            this.grpInformacionMedicamento.Controls.Add(this.txtTipoMedicamento);
            this.grpInformacionMedicamento.Controls.Add(this.txtDescripcionMedicamento);
            this.grpInformacionMedicamento.Controls.Add(this.txtNombreMedicamento);
            this.grpInformacionMedicamento.Controls.Add(this.txtCodigoMedicamento);
            this.grpInformacionMedicamento.Controls.Add(this.lblDescripcion);
            this.grpInformacionMedicamento.Controls.Add(this.lblTipo);
            this.grpInformacionMedicamento.Controls.Add(this.lblCodigo);
            this.grpInformacionMedicamento.Controls.Add(this.lblNombre);
            this.grpInformacionMedicamento.Location = new System.Drawing.Point(12, 70);
            this.grpInformacionMedicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionMedicamento.Name = "grpInformacionMedicamento";
            this.grpInformacionMedicamento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionMedicamento.Size = new System.Drawing.Size(399, 185);
            this.grpInformacionMedicamento.TabIndex = 5;
            this.grpInformacionMedicamento.TabStop = false;
            this.grpInformacionMedicamento.Text = "Información del Medicamento";
            this.grpInformacionMedicamento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTipoMedicamento
            // 
            this.txtTipoMedicamento.Location = new System.Drawing.Point(109, 151);
            this.txtTipoMedicamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoMedicamento.Name = "txtTipoMedicamento";
            this.txtTipoMedicamento.Size = new System.Drawing.Size(132, 22);
            this.txtTipoMedicamento.TabIndex = 7;
            // 
            // txtDescripcionMedicamento
            // 
            this.txtDescripcionMedicamento.Location = new System.Drawing.Point(133, 97);
            this.txtDescripcionMedicamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionMedicamento.Multiline = true;
            this.txtDescripcionMedicamento.Name = "txtDescripcionMedicamento";
            this.txtDescripcionMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionMedicamento.Size = new System.Drawing.Size(240, 37);
            this.txtDescripcionMedicamento.TabIndex = 6;
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(109, 60);
            this.txtNombreMedicamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(187, 22);
            this.txtNombreMedicamento.TabIndex = 5;
            // 
            // txtCodigoMedicamento
            // 
            this.txtCodigoMedicamento.Location = new System.Drawing.Point(109, 22);
            this.txtCodigoMedicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            this.txtCodigoMedicamento.Size = new System.Drawing.Size(99, 22);
            this.txtCodigoMedicamento.TabIndex = 4;
            this.txtCodigoMedicamento.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // grpCantidadPresentacion
            // 
            this.grpCantidadPresentacion.Controls.Add(this.txtCantidadEmpaque);
            this.grpCantidadPresentacion.Controls.Add(this.txtUnidadMedida);
            this.grpCantidadPresentacion.Controls.Add(this.txtCantidadStock);
            this.grpCantidadPresentacion.Controls.Add(this.lblCantidadEmpaque);
            this.grpCantidadPresentacion.Controls.Add(this.lblStock);
            this.grpCantidadPresentacion.Controls.Add(this.lblMedida);
            this.grpCantidadPresentacion.Location = new System.Drawing.Point(12, 274);
            this.grpCantidadPresentacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCantidadPresentacion.Name = "grpCantidadPresentacion";
            this.grpCantidadPresentacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCantidadPresentacion.Size = new System.Drawing.Size(399, 185);
            this.grpCantidadPresentacion.TabIndex = 7;
            this.grpCantidadPresentacion.TabStop = false;
            this.grpCantidadPresentacion.Text = "Datos de Cantidad y Presentación";
            // 
            // txtCantidadEmpaque
            // 
            this.txtCantidadEmpaque.Location = new System.Drawing.Point(221, 119);
            this.txtCantidadEmpaque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadEmpaque.Name = "txtCantidadEmpaque";
            this.txtCantidadEmpaque.Size = new System.Drawing.Size(84, 22);
            this.txtCantidadEmpaque.TabIndex = 6;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(196, 76);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(84, 22);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(196, 34);
            this.txtCantidadStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(84, 22);
            this.txtCantidadStock.TabIndex = 4;
            // 
            // lblCantidadEmpaque
            // 
            this.lblCantidadEmpaque.AutoSize = true;
            this.lblCantidadEmpaque.Location = new System.Drawing.Point(43, 123);
            this.lblCantidadEmpaque.Name = "lblCantidadEmpaque";
            this.lblCantidadEmpaque.Size = new System.Drawing.Size(149, 16);
            this.lblCantidadEmpaque.TabIndex = 3;
            this.lblCantidadEmpaque.Text = "Cantidad por Empaque:";
            this.lblCantidadEmpaque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(43, 39);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(119, 16);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Cantidad en Stock:";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(43, 80);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(122, 16);
            this.lblMedida.TabIndex = 2;
            this.lblMedida.Text = "Unidad de Medida:";
            // 
            // grpInformacionPrecioVenta
            // 
            this.grpInformacionPrecioVenta.Controls.Add(this.radNo);
            this.grpInformacionPrecioVenta.Controls.Add(this.txtPrecioVenta);
            this.grpInformacionPrecioVenta.Controls.Add(this.radSi);
            this.grpInformacionPrecioVenta.Controls.Add(this.txtPrecioCompra);
            this.grpInformacionPrecioVenta.Controls.Add(this.lblDescuento);
            this.grpInformacionPrecioVenta.Controls.Add(this.lblPrecioCompra);
            this.grpInformacionPrecioVenta.Controls.Add(this.lblPrecioVenta);
            this.grpInformacionPrecioVenta.Location = new System.Drawing.Point(653, 70);
            this.grpInformacionPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionPrecioVenta.Name = "grpInformacionPrecioVenta";
            this.grpInformacionPrecioVenta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionPrecioVenta.Size = new System.Drawing.Size(399, 185);
            this.grpInformacionPrecioVenta.TabIndex = 8;
            this.grpInformacionPrecioVenta.TabStop = false;
            this.grpInformacionPrecioVenta.Text = "Información de Precio y Venta";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(280, 121);
            this.radNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(46, 20);
            this.radNo.TabIndex = 12;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(175, 76);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(79, 22);
            this.txtPrecioVenta.TabIndex = 5;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Location = new System.Drawing.Point(209, 121);
            this.radSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(40, 20);
            this.radSi.TabIndex = 11;
            this.radSi.TabStop = true;
            this.radSi.Text = "Si";
            this.radSi.UseVisualStyleBackColor = true;
            this.radSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(175, 36);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(79, 22);
            this.txtPrecioCompra.TabIndex = 4;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(43, 123);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(134, 16);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "Descuento aplicable:";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(43, 39);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(119, 16);
            this.lblPrecioCompra.TabIndex = 1;
            this.lblPrecioCompra.Text = "Precio de Compra:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(43, 80);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(106, 16);
            this.lblPrecioVenta.TabIndex = 2;
            this.lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // grpInformacionProveedor
            // 
            this.grpInformacionProveedor.Controls.Add(this.mtxtContacto);
            this.grpInformacionProveedor.Controls.Add(this.txtCodigoProveedor);
            this.grpInformacionProveedor.Controls.Add(this.txtNombreProveedor);
            this.grpInformacionProveedor.Controls.Add(this.lblContactoProveedor);
            this.grpInformacionProveedor.Controls.Add(this.lblNombreProveedor);
            this.grpInformacionProveedor.Controls.Add(this.lblCodigoProveedor);
            this.grpInformacionProveedor.Location = new System.Drawing.Point(653, 274);
            this.grpInformacionProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionProveedor.Name = "grpInformacionProveedor";
            this.grpInformacionProveedor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformacionProveedor.Size = new System.Drawing.Size(399, 185);
            this.grpInformacionProveedor.TabIndex = 9;
            this.grpInformacionProveedor.TabStop = false;
            this.grpInformacionProveedor.Text = "Información del Proveedor";
            // 
            // mtxtContacto
            // 
            this.mtxtContacto.Location = new System.Drawing.Point(121, 119);
            this.mtxtContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtContacto.Mask = "0000-0000";
            this.mtxtContacto.Name = "mtxtContacto";
            this.mtxtContacto.Size = new System.Drawing.Size(116, 22);
            this.mtxtContacto.TabIndex = 8;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Location = new System.Drawing.Point(121, 76);
            this.txtCodigoProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(99, 22);
            this.txtCodigoProveedor.TabIndex = 7;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(121, 36);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(187, 22);
            this.txtNombreProveedor.TabIndex = 4;
            this.txtNombreProveedor.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // lblContactoProveedor
            // 
            this.lblContactoProveedor.AutoSize = true;
            this.lblContactoProveedor.Location = new System.Drawing.Point(43, 123);
            this.lblContactoProveedor.Name = "lblContactoProveedor";
            this.lblContactoProveedor.Size = new System.Drawing.Size(63, 16);
            this.lblContactoProveedor.TabIndex = 3;
            this.lblContactoProveedor.Text = "Contacto:";
            this.lblContactoProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(43, 39);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(59, 16);
            this.lblNombreProveedor.TabIndex = 1;
            this.lblNombreProveedor.Text = "Nombre:";
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Location = new System.Drawing.Point(43, 80);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoProveedor.TabIndex = 2;
            this.lblCodigoProveedor.Text = "Código:";
            // 
            // grpFechasImportantes
            // 
            this.grpFechasImportantes.Controls.Add(this.mtxtFechaCaducidad);
            this.grpFechasImportantes.Controls.Add(this.mtxtFechaEntrada);
            this.grpFechasImportantes.Controls.Add(this.lblFechaEntrada);
            this.grpFechasImportantes.Controls.Add(this.lblFechaCaducidad);
            this.grpFechasImportantes.Location = new System.Drawing.Point(429, 373);
            this.grpFechasImportantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFechasImportantes.Name = "grpFechasImportantes";
            this.grpFechasImportantes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFechasImportantes.Size = new System.Drawing.Size(201, 185);
            this.grpFechasImportantes.TabIndex = 10;
            this.grpFechasImportantes.TabStop = false;
            this.grpFechasImportantes.Text = "Fechas Importantes";
            // 
            // mtxtFechaCaducidad
            // 
            this.mtxtFechaCaducidad.Location = new System.Drawing.Point(33, 130);
            this.mtxtFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtFechaCaducidad.Mask = "00/00/0000";
            this.mtxtFechaCaducidad.Name = "mtxtFechaCaducidad";
            this.mtxtFechaCaducidad.Size = new System.Drawing.Size(132, 22);
            this.mtxtFechaCaducidad.TabIndex = 4;
            this.mtxtFechaCaducidad.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtFechaEntrada
            // 
            this.mtxtFechaEntrada.Location = new System.Drawing.Point(33, 54);
            this.mtxtFechaEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtFechaEntrada.Mask = "00/00/0000";
            this.mtxtFechaEntrada.Name = "mtxtFechaEntrada";
            this.mtxtFechaEntrada.Size = new System.Drawing.Size(132, 22);
            this.mtxtFechaEntrada.TabIndex = 3;
            this.mtxtFechaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Location = new System.Drawing.Point(29, 34);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(117, 16);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha de Entrada:";
            // 
            // lblFechaCaducidad
            // 
            this.lblFechaCaducidad.AutoSize = true;
            this.lblFechaCaducidad.Location = new System.Drawing.Point(29, 111);
            this.lblFechaCaducidad.Name = "lblFechaCaducidad";
            this.lblFechaCaducidad.Size = new System.Drawing.Size(136, 16);
            this.lblFechaCaducidad.TabIndex = 2;
            this.lblFechaCaducidad.Text = "Fecha de Caducidad:";
            // 
            // PedidoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 574);
            this.Controls.Add(this.grpFechasImportantes);
            this.Controls.Add(this.grpInformacionProveedor);
            this.Controls.Add(this.grpInformacionPrecioVenta);
            this.Controls.Add(this.grpCantidadPresentacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInformacionMedicamento);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PedidoProducto";
            this.Text = "PharmTrack";
            this.grpInformacionMedicamento.ResumeLayout(false);
            this.grpInformacionMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCantidadPresentacion.ResumeLayout(false);
            this.grpCantidadPresentacion.PerformLayout();
            this.grpInformacionPrecioVenta.ResumeLayout(false);
            this.grpInformacionPrecioVenta.PerformLayout();
            this.grpInformacionProveedor.ResumeLayout(false);
            this.grpInformacionProveedor.PerformLayout();
            this.grpFechasImportantes.ResumeLayout(false);
            this.grpFechasImportantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grpInformacionMedicamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpCantidadPresentacion;
        private System.Windows.Forms.Label lblCantidadEmpaque;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.GroupBox grpInformacionPrecioVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.GroupBox grpInformacionProveedor;
        private System.Windows.Forms.Label lblContactoProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.GroupBox grpFechasImportantes;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Label lblFechaCaducidad;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.TextBox txtTipoMedicamento;
        private System.Windows.Forms.TextBox txtDescripcionMedicamento;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtCantidadEmpaque;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.MaskedTextBox mtxtFechaCaducidad;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEntrada;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.MaskedTextBox mtxtContacto;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.RadioButton radNo;
    }
}

