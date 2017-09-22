namespace SISCOMIC_DESKTOP
{
    partial class StockProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRequerido = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNuevaCantidad = new System.Windows.Forms.TextBox();
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.tbcStock = new System.Windows.Forms.TabControl();
            this.tbpStock = new System.Windows.Forms.TabPage();
            this.tbpHistorico = new System.Windows.Forms.TabPage();
            this.dgvStockHistorico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colClaveProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadInsertada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantAgregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefinicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tbcStock.SuspendLayout();
            this.tbpStock.SuspendLayout();
            this.tbpHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistorico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRequerido);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNuevaCantidad);
            this.groupBox1.Controls.Add(this.txtCantidadActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de productos";
            // 
            // lblRequerido
            // 
            this.lblRequerido.AutoSize = true;
            this.lblRequerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido.ForeColor = System.Drawing.Color.Red;
            this.lblRequerido.Location = new System.Drawing.Point(252, 78);
            this.lblRequerido.Name = "lblRequerido";
            this.lblRequerido.Size = new System.Drawing.Size(12, 15);
            this.lblRequerido.TabIndex = 44;
            this.lblRequerido.Text = "*";
            this.lblRequerido.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(491, 39);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 40);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(255, 153);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 53);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(410, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 53);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNuevaCantidad
            // 
            this.txtNuevaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtNuevaCantidad.Location = new System.Drawing.Point(255, 101);
            this.txtNuevaCantidad.MaxLength = 2;
            this.txtNuevaCantidad.Name = "txtNuevaCantidad";
            this.txtNuevaCantidad.Size = new System.Drawing.Size(230, 22);
            this.txtNuevaCantidad.TabIndex = 5;
            this.txtNuevaCantidad.TextChanged += new System.EventHandler(this.txtNuevaCantidad_TextChanged);
            // 
            // txtCantidadActual
            // 
            this.txtCantidadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadActual.ForeColor = System.Drawing.Color.Maroon;
            this.txtCantidadActual.Location = new System.Drawing.Point(255, 51);
            this.txtCantidadActual.MaxLength = 2;
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.Size = new System.Drawing.Size(230, 22);
            this.txtCantidadActual.TabIndex = 4;
            this.txtCantidadActual.TextChanged += new System.EventHandler(this.txtCantidadActual_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sumar Nueva Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave de Producto:";
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProducto.ForeColor = System.Drawing.Color.Maroon;
            this.lblClaveProducto.Location = new System.Drawing.Point(119, 17);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(70, 16);
            this.lblClaveProducto.TabIndex = 1;
            this.lblClaveProducto.Text = "Producto";
            // 
            // tbcStock
            // 
            this.tbcStock.Controls.Add(this.tbpStock);
            this.tbcStock.Controls.Add(this.tbpHistorico);
            this.tbcStock.Location = new System.Drawing.Point(12, 66);
            this.tbcStock.Name = "tbcStock";
            this.tbcStock.SelectedIndex = 0;
            this.tbcStock.Size = new System.Drawing.Size(753, 280);
            this.tbcStock.TabIndex = 2;
            this.tbcStock.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcStock_Selecting);
            // 
            // tbpStock
            // 
            this.tbpStock.Controls.Add(this.groupBox1);
            this.tbpStock.Location = new System.Drawing.Point(4, 22);
            this.tbpStock.Name = "tbpStock";
            this.tbpStock.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStock.Size = new System.Drawing.Size(745, 254);
            this.tbpStock.TabIndex = 0;
            this.tbpStock.Text = "Stock";
            this.tbpStock.UseVisualStyleBackColor = true;
            // 
            // tbpHistorico
            // 
            this.tbpHistorico.Controls.Add(this.dgvStockHistorico);
            this.tbpHistorico.Location = new System.Drawing.Point(4, 22);
            this.tbpHistorico.Name = "tbpHistorico";
            this.tbpHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistorico.Size = new System.Drawing.Size(745, 254);
            this.tbpHistorico.TabIndex = 1;
            this.tbpHistorico.Text = "Historico";
            this.tbpHistorico.UseVisualStyleBackColor = true;
            // 
            // dgvStockHistorico
            // 
            this.dgvStockHistorico.AllowUserToAddRows = false;
            this.dgvStockHistorico.AllowUserToDeleteRows = false;
            this.dgvStockHistorico.AllowUserToOrderColumns = true;
            this.dgvStockHistorico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClaveProducto,
            this.colCantAnterior,
            this.colCantidadInsertada,
            this.colCantAgregada,
            this.colFecha,
            this.colDefinicion,
            this.colAccion,
            this.colUser});
            this.dgvStockHistorico.Location = new System.Drawing.Point(0, 3);
            this.dgvStockHistorico.Name = "dgvStockHistorico";
            this.dgvStockHistorico.ReadOnly = true;
            this.dgvStockHistorico.Size = new System.Drawing.Size(747, 255);
            this.dgvStockHistorico.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblClaveProducto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 48);
            this.panel1.TabIndex = 3;
            // 
            // colClaveProducto
            // 
            this.colClaveProducto.DataPropertyName = "SPH_PROD_ID";
            this.colClaveProducto.HeaderText = "C. Producto";
            this.colClaveProducto.Name = "colClaveProducto";
            this.colClaveProducto.ReadOnly = true;
            // 
            // colCantAnterior
            // 
            this.colCantAnterior.DataPropertyName = "SPH_CANT_ANTE";
            this.colCantAnterior.HeaderText = "Cantidad Anterior";
            this.colCantAnterior.Name = "colCantAnterior";
            this.colCantAnterior.ReadOnly = true;
            // 
            // colCantidadInsertada
            // 
            this.colCantidadInsertada.DataPropertyName = "CANT_INSERTADA";
            this.colCantidadInsertada.HeaderText = "Cantidad Ingresada";
            this.colCantidadInsertada.Name = "colCantidadInsertada";
            this.colCantidadInsertada.ReadOnly = true;
            // 
            // colCantAgregada
            // 
            this.colCantAgregada.DataPropertyName = "SPH_CANT_AGRE";
            this.colCantAgregada.HeaderText = "Cantidad Actual";
            this.colCantAgregada.Name = "colCantAgregada";
            this.colCantAgregada.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "SPH_FECH";
            this.colFecha.HeaderText = "Fecha de Modificación";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 130;
            // 
            // colDefinicion
            // 
            this.colDefinicion.DataPropertyName = "DEFINICION";
            this.colDefinicion.HeaderText = "Ventana de Cambio";
            this.colDefinicion.Name = "colDefinicion";
            this.colDefinicion.ReadOnly = true;
            // 
            // colAccion
            // 
            this.colAccion.DataPropertyName = "SPH_ACCI";
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "USUA_NOMB";
            this.colUser.HeaderText = "Usuario";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // StockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcStock);
            this.Name = "StockProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Productos";
            this.Load += new System.EventHandler(this.StockProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcStock.ResumeLayout(false);
            this.tbpStock.ResumeLayout(false);
            this.tbpHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistorico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNuevaCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCantidadActual;
        public System.Windows.Forms.Label lblClaveProducto;
        private System.Windows.Forms.Label lblRequerido;
        private System.Windows.Forms.TabControl tbcStock;
        private System.Windows.Forms.TabPage tbpStock;
        private System.Windows.Forms.TabPage tbpHistorico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStockHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadInsertada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantAgregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefinicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
    }
}