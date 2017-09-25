namespace SISCOMIC_DESKTOP
{
    partial class AgregarPrecio
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
            System.Windows.Forms.Button btnEditar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPrecio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hidIdPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoPrecio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBanderaNuevo = new System.Windows.Forms.Label();
            this.tbcPrecios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRequeridoPrecioVenta = new System.Windows.Forms.Label();
            this.lblRequeridoPrecioCompra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHistoricoPrecio = new System.Windows.Forms.DataGridView();
            this.colPrecioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEditar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcPrecios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            btnEditar.Location = new System.Drawing.Point(266, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(72, 40);
            btnEditar.TabIndex = 10;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblClaveProducto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 33);
            this.panel2.TabIndex = 1;
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProducto.Location = new System.Drawing.Point(77, 7);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(103, 15);
            this.lblClaveProducto.TabIndex = 5;
            this.lblClaveProducto.Text = "Clave Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto:";
            // 
            // hidIdPrecio
            // 
            this.hidIdPrecio.AutoSize = true;
            this.hidIdPrecio.Location = new System.Drawing.Point(3, 0);
            this.hidIdPrecio.Name = "hidIdPrecio";
            this.hidIdPrecio.Size = new System.Drawing.Size(60, 13);
            this.hidIdPrecio.TabIndex = 0;
            this.hidIdPrecio.Text = "hidIdPrecio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(10, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(363, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 40);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoPrecio
            // 
            this.btnNuevoPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPrecio.FlatAppearance.BorderSize = 0;
            this.btnNuevoPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuevoPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNuevoPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPrecio.Image")));
            this.btnNuevoPrecio.Location = new System.Drawing.Point(613, 394);
            this.btnNuevoPrecio.Name = "btnNuevoPrecio";
            this.btnNuevoPrecio.Size = new System.Drawing.Size(68, 40);
            this.btnNuevoPrecio.TabIndex = 9;
            this.btnNuevoPrecio.UseVisualStyleBackColor = true;
            this.btnNuevoPrecio.Click += new System.EventHandler(this.btnNuevoPrecio_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblBanderaNuevo);
            this.panel1.Controls.Add(this.tbcPrecios);
            this.panel1.Controls.Add(btnEditar);
            this.panel1.Controls.Add(this.btnNuevoPrecio);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.hidIdPrecio);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 477);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblBanderaNuevo
            // 
            this.lblBanderaNuevo.AutoSize = true;
            this.lblBanderaNuevo.Location = new System.Drawing.Point(127, 0);
            this.lblBanderaNuevo.Name = "lblBanderaNuevo";
            this.lblBanderaNuevo.Size = new System.Drawing.Size(89, 13);
            this.lblBanderaNuevo.TabIndex = 12;
            this.lblBanderaNuevo.Text = "lblBanderaNuevo";
            // 
            // tbcPrecios
            // 
            this.tbcPrecios.Controls.Add(this.tabPage1);
            this.tbcPrecios.Controls.Add(this.tabPage2);
            this.tbcPrecios.Location = new System.Drawing.Point(6, 16);
            this.tbcPrecios.Name = "tbcPrecios";
            this.tbcPrecios.SelectedIndex = 0;
            this.tbcPrecios.Size = new System.Drawing.Size(679, 365);
            this.tbcPrecios.TabIndex = 11;
            this.tbcPrecios.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcPrecios_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Precios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtFechaFin);
            this.groupBox2.Controls.Add(this.dtFechaInicio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vigencia del Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Fin:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dtFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtFechaFin.Location = new System.Drawing.Point(158, 71);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(163, 21);
            this.dtFechaFin.TabIndex = 10;
            this.dtFechaFin.Value = new System.DateTime(2017, 7, 29, 0, 0, 0, 0);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dtFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(158, 24);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(163, 21);
            this.dtFechaInicio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRequeridoPrecioVenta);
            this.groupBox1.Controls.Add(this.lblRequeridoPrecioCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 145);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio";
            // 
            // lblRequeridoPrecioVenta
            // 
            this.lblRequeridoPrecioVenta.AutoSize = true;
            this.lblRequeridoPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequeridoPrecioVenta.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoPrecioVenta.Location = new System.Drawing.Point(154, 117);
            this.lblRequeridoPrecioVenta.Name = "lblRequeridoPrecioVenta";
            this.lblRequeridoPrecioVenta.Size = new System.Drawing.Size(12, 15);
            this.lblRequeridoPrecioVenta.TabIndex = 44;
            this.lblRequeridoPrecioVenta.Text = "*";
            this.lblRequeridoPrecioVenta.Visible = false;
            // 
            // lblRequeridoPrecioCompra
            // 
            this.lblRequeridoPrecioCompra.AutoSize = true;
            this.lblRequeridoPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequeridoPrecioCompra.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoPrecioCompra.Location = new System.Drawing.Point(155, 56);
            this.lblRequeridoPrecioCompra.Name = "lblRequeridoPrecioCompra";
            this.lblRequeridoPrecioCompra.Size = new System.Drawing.Size(12, 15);
            this.lblRequeridoPrecioCompra.TabIndex = 43;
            this.lblRequeridoPrecioCompra.Text = "*";
            this.lblRequeridoPrecioCompra.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio de Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPrecioCompra.Location = new System.Drawing.Point(158, 31);
            this.txtPrecioCompra.MaxLength = 20;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(163, 22);
            this.txtPrecioCompra.TabIndex = 10;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Precio de Compra:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPrecioVenta.Location = new System.Drawing.Point(158, 91);
            this.txtPrecioVenta.MaxLength = 20;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(163, 22);
            this.txtPrecioVenta.TabIndex = 11;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvHistoricoPrecio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHistoricoPrecio
            // 
            this.dgvHistoricoPrecio.AllowUserToAddRows = false;
            this.dgvHistoricoPrecio.AllowUserToDeleteRows = false;
            this.dgvHistoricoPrecio.AllowUserToOrderColumns = true;
            this.dgvHistoricoPrecio.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistoricoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistoricoPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrecioId,
            this.colProducto,
            this.colPrecioCosto,
            this.colPrecioVenta,
            this.colFechaInicio,
            this.colFechaFin});
            this.dgvHistoricoPrecio.Location = new System.Drawing.Point(28, 18);
            this.dgvHistoricoPrecio.Name = "dgvHistoricoPrecio";
            this.dgvHistoricoPrecio.ReadOnly = true;
            this.dgvHistoricoPrecio.Size = new System.Drawing.Size(622, 315);
            this.dgvHistoricoPrecio.TabIndex = 0;
            // 
            // colPrecioId
            // 
            this.colPrecioId.DataPropertyName = "PREC_ID";
            this.colPrecioId.HeaderText = "ID";
            this.colPrecioId.Name = "colPrecioId";
            this.colPrecioId.ReadOnly = true;
            this.colPrecioId.Visible = false;
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "PREC_PROD_ID";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.DataPropertyName = "PREC_COSTO";
            this.colPrecioCosto.HeaderText = "Precio de Compra";
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.ReadOnly = true;
            this.colPrecioCosto.Width = 120;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.DataPropertyName = "PREC_VENTA";
            this.colPrecioVenta.HeaderText = "Precio de Venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            this.colPrecioVenta.Width = 120;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.DataPropertyName = "PREC_FECH_INIC";
            this.colFechaInicio.HeaderText = "Fecha de Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            this.colFechaInicio.Width = 120;
            // 
            // colFechaFin
            // 
            this.colFechaFin.DataPropertyName = "PREC_FECH_FIN";
            this.colFechaFin.HeaderText = "Fecha de Fin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.ReadOnly = true;
            this.colFechaFin.Width = 120;
            // 
            // AgregarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(730, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Precio";
            this.Load += new System.EventHandler(this.AgregarPrecio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcPrecios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblClaveProducto;
        public System.Windows.Forms.Label hidIdPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoPrecio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBanderaNuevo;
        private System.Windows.Forms.TabControl tbcPrecios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtFechaFin;
        public System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblRequeridoPrecioVenta;
        private System.Windows.Forms.Label lblRequeridoPrecioCompra;
        private System.Windows.Forms.DataGridView dgvHistoricoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFin;
    }
}