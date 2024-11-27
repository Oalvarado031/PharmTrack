namespace PedidoDeProductoFarmTrack
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
            this.lblnombrecompleto = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldirecciondeentrega = new System.Windows.Forms.Label();
            this.lblcorreoelectronico = new System.Windows.Forms.Label();
            this.grpdatosdelcliente = new System.Windows.Forms.GroupBox();
            this.txtdirecciondeentrega = new System.Windows.Forms.TextBox();
            this.txtcorreoelectronico = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.grpdetallesdelproducto = new System.Windows.Forms.GroupBox();
            this.lblproductomedicamente = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblpresentacion = new System.Windows.Forms.Label();
            this.lblfechadepedido = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblopcionesdepago = new System.Windows.Forms.Label();
            this.lbldatosdepago = new System.Windows.Forms.Label();
            this.radefectivo = new System.Windows.Forms.RadioButton();
            this.radtransferencia = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnrealizarpedido = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grpdatosdelcliente.SuspendLayout();
            this.grpdetallesdelproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombrecompleto
            // 
            this.lblnombrecompleto.AutoSize = true;
            this.lblnombrecompleto.Location = new System.Drawing.Point(6, 35);
            this.lblnombrecompleto.Name = "lblnombrecompleto";
            this.lblnombrecompleto.Size = new System.Drawing.Size(159, 22);
            this.lblnombrecompleto.TabIndex = 0;
            this.lblnombrecompleto.Text = "Nombre Completo:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(6, 75);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(86, 22);
            this.lbltelefono.TabIndex = 1;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // lbldirecciondeentrega
            // 
            this.lbldirecciondeentrega.AutoSize = true;
            this.lbldirecciondeentrega.Location = new System.Drawing.Point(6, 117);
            this.lbldirecciondeentrega.Name = "lbldirecciondeentrega";
            this.lbldirecciondeentrega.Size = new System.Drawing.Size(183, 22);
            this.lbldirecciondeentrega.TabIndex = 2;
            this.lbldirecciondeentrega.Text = "Dirección de Entrega:";
            // 
            // lblcorreoelectronico
            // 
            this.lblcorreoelectronico.AutoSize = true;
            this.lblcorreoelectronico.Location = new System.Drawing.Point(6, 226);
            this.lblcorreoelectronico.Name = "lblcorreoelectronico";
            this.lblcorreoelectronico.Size = new System.Drawing.Size(164, 22);
            this.lblcorreoelectronico.TabIndex = 3;
            this.lblcorreoelectronico.Text = "Correo Eléctronico:";
            // 
            // grpdatosdelcliente
            // 
            this.grpdatosdelcliente.Controls.Add(this.txttelefono);
            this.grpdatosdelcliente.Controls.Add(this.txtnombrecompleto);
            this.grpdatosdelcliente.Controls.Add(this.txtcorreoelectronico);
            this.grpdatosdelcliente.Controls.Add(this.txtdirecciondeentrega);
            this.grpdatosdelcliente.Controls.Add(this.lblnombrecompleto);
            this.grpdatosdelcliente.Controls.Add(this.lblcorreoelectronico);
            this.grpdatosdelcliente.Controls.Add(this.lbltelefono);
            this.grpdatosdelcliente.Controls.Add(this.lbldirecciondeentrega);
            this.grpdatosdelcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdatosdelcliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grpdatosdelcliente.Location = new System.Drawing.Point(12, 12);
            this.grpdatosdelcliente.Name = "grpdatosdelcliente";
            this.grpdatosdelcliente.Size = new System.Drawing.Size(592, 270);
            this.grpdatosdelcliente.TabIndex = 4;
            this.grpdatosdelcliente.TabStop = false;
            this.grpdatosdelcliente.Text = "Datos del Cliente";
            // 
            // txtdirecciondeentrega
            // 
            this.txtdirecciondeentrega.Location = new System.Drawing.Point(195, 114);
            this.txtdirecciondeentrega.Multiline = true;
            this.txtdirecciondeentrega.Name = "txtdirecciondeentrega";
            this.txtdirecciondeentrega.Size = new System.Drawing.Size(391, 103);
            this.txtdirecciondeentrega.TabIndex = 4;
            // 
            // txtcorreoelectronico
            // 
            this.txtcorreoelectronico.Location = new System.Drawing.Point(195, 223);
            this.txtcorreoelectronico.Name = "txtcorreoelectronico";
            this.txtcorreoelectronico.Size = new System.Drawing.Size(391, 28);
            this.txtcorreoelectronico.TabIndex = 5;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.Location = new System.Drawing.Point(195, 32);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(391, 28);
            this.txtnombrecompleto.TabIndex = 6;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(195, 72);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(391, 28);
            this.txttelefono.TabIndex = 7;
            // 
            // grpdetallesdelproducto
            // 
            this.grpdetallesdelproducto.Controls.Add(this.dateTimePicker1);
            this.grpdetallesdelproducto.Controls.Add(this.comboBox1);
            this.grpdetallesdelproducto.Controls.Add(this.textBox1);
            this.grpdetallesdelproducto.Controls.Add(this.numericUpDown1);
            this.grpdetallesdelproducto.Controls.Add(this.lblfechadepedido);
            this.grpdetallesdelproducto.Controls.Add(this.lblpresentacion);
            this.grpdetallesdelproducto.Controls.Add(this.lblcantidad);
            this.grpdetallesdelproducto.Controls.Add(this.lblproductomedicamente);
            this.grpdetallesdelproducto.Location = new System.Drawing.Point(610, 12);
            this.grpdetallesdelproducto.Name = "grpdetallesdelproducto";
            this.grpdetallesdelproducto.Size = new System.Drawing.Size(531, 270);
            this.grpdetallesdelproducto.TabIndex = 5;
            this.grpdetallesdelproducto.TabStop = false;
            this.grpdetallesdelproducto.Text = "Detalles del Producto";
            // 
            // lblproductomedicamente
            // 
            this.lblproductomedicamente.AutoSize = true;
            this.lblproductomedicamente.Location = new System.Drawing.Point(6, 35);
            this.lblproductomedicamente.Name = "lblproductomedicamente";
            this.lblproductomedicamente.Size = new System.Drawing.Size(198, 22);
            this.lblproductomedicamente.TabIndex = 0;
            this.lblproductomedicamente.Text = "Producto/Medicamento:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(6, 75);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(87, 22);
            this.lblcantidad.TabIndex = 1;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // lblpresentacion
            // 
            this.lblpresentacion.AutoSize = true;
            this.lblpresentacion.Location = new System.Drawing.Point(6, 117);
            this.lblpresentacion.Name = "lblpresentacion";
            this.lblpresentacion.Size = new System.Drawing.Size(120, 22);
            this.lblpresentacion.TabIndex = 2;
            this.lblpresentacion.Text = "Presentación:";
            // 
            // lblfechadepedido
            // 
            this.lblfechadepedido.AutoSize = true;
            this.lblfechadepedido.Location = new System.Drawing.Point(6, 167);
            this.lblfechadepedido.Name = "lblfechadepedido";
            this.lblfechadepedido.Size = new System.Drawing.Size(151, 22);
            this.lblfechadepedido.TabIndex = 3;
            this.lblfechadepedido.Text = "Fecha de Pedido:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 28);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tabletas",
            "Jarabe",
            "Ampolla"});
            this.comboBox1.Location = new System.Drawing.Point(210, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 30);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 28);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radtransferencia);
            this.groupBox1.Controls.Add(this.radefectivo);
            this.groupBox1.Controls.Add(this.lbldatosdepago);
            this.groupBox1.Controls.Add(this.lblopcionesdepago);
            this.groupBox1.Location = new System.Drawing.Point(3, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método de Pago";
            // 
            // lblopcionesdepago
            // 
            this.lblopcionesdepago.AutoSize = true;
            this.lblopcionesdepago.Location = new System.Drawing.Point(15, 39);
            this.lblopcionesdepago.Name = "lblopcionesdepago";
            this.lblopcionesdepago.Size = new System.Drawing.Size(163, 22);
            this.lblopcionesdepago.TabIndex = 0;
            this.lblopcionesdepago.Text = "Opciones de Pago:";
            // 
            // lbldatosdepago
            // 
            this.lbldatosdepago.AutoSize = true;
            this.lbldatosdepago.Location = new System.Drawing.Point(15, 78);
            this.lbldatosdepago.Name = "lbldatosdepago";
            this.lbldatosdepago.Size = new System.Drawing.Size(134, 22);
            this.lbldatosdepago.TabIndex = 1;
            this.lbldatosdepago.Text = "Datos de Pago:";
            // 
            // radefectivo
            // 
            this.radefectivo.AutoSize = true;
            this.radefectivo.Location = new System.Drawing.Point(204, 39);
            this.radefectivo.Name = "radefectivo";
            this.radefectivo.Size = new System.Drawing.Size(95, 26);
            this.radefectivo.TabIndex = 2;
            this.radefectivo.TabStop = true;
            this.radefectivo.Text = "Efectivo";
            this.radefectivo.UseVisualStyleBackColor = true;
            // 
            // radtransferencia
            // 
            this.radtransferencia.AutoSize = true;
            this.radtransferencia.Location = new System.Drawing.Point(305, 39);
            this.radtransferencia.Name = "radtransferencia";
            this.radtransferencia.Size = new System.Drawing.Size(147, 26);
            this.radtransferencia.TabIndex = 3;
            this.radtransferencia.TabStop = true;
            this.radtransferencia.Text = "Transferencia ";
            this.radtransferencia.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(458, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(233, 26);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tarjeta de Crédito/Débito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnrealizarpedido
            // 
            this.btnrealizarpedido.Location = new System.Drawing.Point(728, 398);
            this.btnrealizarpedido.Name = "btnrealizarpedido";
            this.btnrealizarpedido.Size = new System.Drawing.Size(170, 39);
            this.btnrealizarpedido.TabIndex = 7;
            this.btnrealizarpedido.Text = "Realizar Pedido";
            this.btnrealizarpedido.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(938, 398);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(170, 39);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 663);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnrealizarpedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpdetallesdelproducto);
            this.Controls.Add(this.grpdatosdelcliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PharmTrack";
            this.grpdatosdelcliente.ResumeLayout(false);
            this.grpdatosdelcliente.PerformLayout();
            this.grpdetallesdelproducto.ResumeLayout(false);
            this.grpdetallesdelproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnombrecompleto;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldirecciondeentrega;
        private System.Windows.Forms.Label lblcorreoelectronico;
        private System.Windows.Forms.GroupBox grpdatosdelcliente;
        private System.Windows.Forms.TextBox txtdirecciondeentrega;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtcorreoelectronico;
        private System.Windows.Forms.GroupBox grpdetallesdelproducto;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblproductomedicamente;
        private System.Windows.Forms.Label lblfechadepedido;
        private System.Windows.Forms.Label lblpresentacion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldatosdepago;
        private System.Windows.Forms.Label lblopcionesdepago;
        private System.Windows.Forms.RadioButton radtransferencia;
        private System.Windows.Forms.RadioButton radefectivo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnrealizarpedido;
        private System.Windows.Forms.Button btncancelar;
    }
}

