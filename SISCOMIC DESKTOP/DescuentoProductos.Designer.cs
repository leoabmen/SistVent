namespace SISCOMIC_DESKTOP
{
    partial class DescuentoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescuentoProductos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDescuentos = new System.Windows.Forms.TabPage();
            this.hidPorcId = new System.Windows.Forms.Label();
            this.btnNuevoDesc = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRequeridoDesc = new System.Windows.Forms.Label();
            this.txtAgregarDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHistDesc = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPorcentajeActual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrecioDesc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrecioNormal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnEditar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbDescuentos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            btnEditar.Location = new System.Drawing.Point(409, 176);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(72, 58);
            btnEditar.TabIndex = 16;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDescuentos);
            this.tabControl1.Controls.Add(this.tbHistDesc);
            this.tabControl1.Location = new System.Drawing.Point(12, 215);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tbDescuentos
            // 
            this.tbDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbDescuentos.Controls.Add(this.hidPorcId);
            this.tbDescuentos.Controls.Add(btnEditar);
            this.tbDescuentos.Controls.Add(this.btnNuevoDesc);
            this.tbDescuentos.Controls.Add(this.btnGuardar);
            this.tbDescuentos.Controls.Add(this.btnCancelar);
            this.tbDescuentos.Controls.Add(this.groupBox4);
            this.tbDescuentos.Controls.Add(this.groupBox5);
            this.tbDescuentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDescuentos.Location = new System.Drawing.Point(4, 22);
            this.tbDescuentos.Name = "tbDescuentos";
            this.tbDescuentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbDescuentos.Size = new System.Drawing.Size(1018, 270);
            this.tbDescuentos.TabIndex = 0;
            this.tbDescuentos.Text = "Descuentos";
            this.tbDescuentos.ToolTipText = "Agregar Descuento al Producto Seleccionado";
            this.tbDescuentos.UseVisualStyleBackColor = true;
            // 
            // hidPorcId
            // 
            this.hidPorcId.AutoSize = true;
            this.hidPorcId.Location = new System.Drawing.Point(8, 3);
            this.hidPorcId.Name = "hidPorcId";
            this.hidPorcId.Size = new System.Drawing.Size(52, 13);
            this.hidPorcId.TabIndex = 17;
            this.hidPorcId.Text = "hidPorcId";
            // 
            // btnNuevoDesc
            // 
            this.btnNuevoDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDesc.FlatAppearance.BorderSize = 0;
            this.btnNuevoDesc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuevoDesc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNuevoDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDesc.Image")));
            this.btnNuevoDesc.Location = new System.Drawing.Point(746, 176);
            this.btnNuevoDesc.Name = "btnNuevoDesc";
            this.btnNuevoDesc.Size = new System.Drawing.Size(68, 58);
            this.btnNuevoDesc.TabIndex = 15;
            this.btnNuevoDesc.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(502, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 58);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(152, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 58);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dtFechaFin);
            this.groupBox4.Controls.Add(this.dtFechaInicio);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(430, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 127);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vigencia del Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha de Fin:";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Fecha de Inicio:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lblRequeridoDesc);
            this.groupBox5.Controls.Add(this.txtAgregarDesc);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(49, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 127);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Descuento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(247, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 18);
            this.label12.TabIndex = 44;
            this.label12.Text = "%";
            // 
            // lblRequeridoDesc
            // 
            this.lblRequeridoDesc.AutoSize = true;
            this.lblRequeridoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequeridoDesc.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoDesc.Location = new System.Drawing.Point(172, 54);
            this.lblRequeridoDesc.Name = "lblRequeridoDesc";
            this.lblRequeridoDesc.Size = new System.Drawing.Size(12, 15);
            this.lblRequeridoDesc.TabIndex = 43;
            this.lblRequeridoDesc.Text = "*";
            this.lblRequeridoDesc.Visible = false;
            // 
            // txtAgregarDesc
            // 
            this.txtAgregarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarDesc.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAgregarDesc.Location = new System.Drawing.Point(175, 29);
            this.txtAgregarDesc.MaxLength = 20;
            this.txtAgregarDesc.Name = "txtAgregarDesc";
            this.txtAgregarDesc.Size = new System.Drawing.Size(66, 22);
            this.txtAgregarDesc.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Porcentaje de Descuento:";
            // 
            // tbHistDesc
            // 
            this.tbHistDesc.Location = new System.Drawing.Point(4, 22);
            this.tbHistDesc.Name = "tbHistDesc";
            this.tbHistDesc.Padding = new System.Windows.Forms.Padding(3);
            this.tbHistDesc.Size = new System.Drawing.Size(1018, 270);
            this.tbHistDesc.TabIndex = 1;
            this.tbHistDesc.Text = "Histórico";
            this.tbHistDesc.ToolTipText = "Revisar Histórico de Descuentos ";
            this.tbHistDesc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 172);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Location = new System.Drawing.Point(808, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 147);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Porcentaje de Descuento";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblPorcentajeActual);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(20, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 97);
            this.panel4.TabIndex = 14;
            // 
            // lblPorcentajeActual
            // 
            this.lblPorcentajeActual.AutoSize = true;
            this.lblPorcentajeActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeActual.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblPorcentajeActual.Location = new System.Drawing.Point(-1, 17);
            this.lblPorcentajeActual.Name = "lblPorcentajeActual";
            this.lblPorcentajeActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPorcentajeActual.Size = new System.Drawing.Size(80, 55);
            this.lblPorcentajeActual.TabIndex = 11;
            this.lblPorcentajeActual.Text = "50";
            this.lblPorcentajeActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label9.Location = new System.Drawing.Point(98, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 55);
            this.label9.TabIndex = 12;
            this.label9.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(5, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(87, 22);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(231, 22);
            this.txtClave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(87, 67);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 64);
            this.txtDescripcion.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(358, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 147);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "P. con Descuento:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPrecioDesc);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(133, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 45);
            this.panel3.TabIndex = 14;
            // 
            // lblPrecioDesc
            // 
            this.lblPrecioDesc.AutoSize = true;
            this.lblPrecioDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDesc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPrecioDesc.Location = new System.Drawing.Point(49, 2);
            this.lblPrecioDesc.Name = "lblPrecioDesc";
            this.lblPrecioDesc.Size = new System.Drawing.Size(62, 42);
            this.lblPrecioDesc.TabIndex = 11;
            this.lblPrecioDesc.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "$";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPrecioNormal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(133, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 45);
            this.panel2.TabIndex = 13;
            // 
            // lblPrecioNormal
            // 
            this.lblPrecioNormal.AutoSize = true;
            this.lblPrecioNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrecioNormal.Location = new System.Drawing.Point(49, 2);
            this.lblPrecioNormal.Name = "lblPrecioNormal";
            this.lblPrecioNormal.Size = new System.Drawing.Size(62, 42);
            this.lblPrecioNormal.TabIndex = 11;
            this.lblPrecioNormal.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "P. Normal:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // DescuentoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1051, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DescuentoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento General a Productos (Ofertas)";
            this.Load += new System.EventHandler(this.DescuentoProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbDescuentos.ResumeLayout(false);
            this.tbDescuentos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDescuentos;
        private System.Windows.Forms.TabPage tbHistDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblPorcentajeActual;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblPrecioDesc;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblPrecioNormal;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dtFechaFin;
        public System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRequeridoDesc;
        public System.Windows.Forms.TextBox txtAgregarDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNuevoDesc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label hidPorcId;


    }
}