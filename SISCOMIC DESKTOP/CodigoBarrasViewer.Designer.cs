namespace SISCOMIC_DESKTOP
{
    partial class CodigoBarrasViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoBarrasViewer));
            this.crvReporteCB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtCopias = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProdDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblClaveProducto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiasCarta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProdcutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvReporteCB
            // 
            this.crvReporteCB.ActiveViewIndex = -1;
            this.crvReporteCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteCB.Location = new System.Drawing.Point(3, 3);
            this.crvReporteCB.Name = "crvReporteCB";
            this.crvReporteCB.Size = new System.Drawing.Size(1307, 563);
            this.crvReporteCB.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.crvReporteCB);
            this.panel1.Location = new System.Drawing.Point(21, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 543);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtProductoId
            // 
            this.txtProductoId.Enabled = false;
            this.txtProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoId.ForeColor = System.Drawing.Color.DarkRed;
            this.txtProductoId.Location = new System.Drawing.Point(109, 19);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(276, 22);
            this.txtProductoId.TabIndex = 2;
            // 
            // txtCopias
            // 
            this.txtCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopias.Location = new System.Drawing.Point(199, 19);
            this.txtCopias.MaxLength = 3;
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(152, 22);
            this.txtCopias.TabIndex = 3;
            this.txtCopias.TextChanged += new System.EventHandler(this.txtCopias_TextChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.Location = new System.Drawing.Point(542, 19);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(81, 70);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(21, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 119);
            this.panel2.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(32, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 78);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProdDescripcion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LblClaveProducto);
            this.groupBox2.Controls.Add(this.txtProductoId);
            this.groupBox2.Location = new System.Drawing.Point(166, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 109);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // txtProdDescripcion
            // 
            this.txtProdDescripcion.Enabled = false;
            this.txtProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDescripcion.ForeColor = System.Drawing.Color.DarkRed;
            this.txtProdDescripcion.Location = new System.Drawing.Point(109, 57);
            this.txtProdDescripcion.Multiline = true;
            this.txtProdDescripcion.Name = "txtProdDescripcion";
            this.txtProdDescripcion.Size = new System.Drawing.Size(276, 46);
            this.txtProdDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción:";
            // 
            // LblClaveProducto
            // 
            this.LblClaveProducto.AutoSize = true;
            this.LblClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClaveProducto.Location = new System.Drawing.Point(57, 19);
            this.LblClaveProducto.Name = "LblClaveProducto";
            this.LblClaveProducto.Size = new System.Drawing.Size(46, 16);
            this.LblClaveProducto.TabIndex = 6;
            this.LblClaveProducto.Text = "Clave:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTamaño);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCopias);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnCopiasCarta);
            this.groupBox1.Location = new System.Drawing.Point(619, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Enabled = false;
            this.txtTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.Location = new System.Drawing.Point(199, 63);
            this.txtTamaño.MaxLength = 3;
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(152, 22);
            this.txtTamaño.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vista Tamaño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "No. de Copias:";
            // 
            // btnCopiasCarta
            // 
            this.btnCopiasCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiasCarta.FlatAppearance.BorderSize = 0;
            this.btnCopiasCarta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCopiasCarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCopiasCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiasCarta.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiasCarta.Image")));
            this.btnCopiasCarta.Location = new System.Drawing.Point(415, 19);
            this.btnCopiasCarta.Name = "btnCopiasCarta";
            this.btnCopiasCarta.Size = new System.Drawing.Size(88, 70);
            this.btnCopiasCarta.TabIndex = 8;
            this.btnCopiasCarta.UseVisualStyleBackColor = true;
            this.btnCopiasCarta.Click += new System.EventHandler(this.btnCopiasCarta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProdcutoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarProdcutoToolStripMenuItem
            // 
            this.buscarProdcutoToolStripMenuItem.Name = "buscarProdcutoToolStripMenuItem";
            this.buscarProdcutoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarProdcutoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.buscarProdcutoToolStripMenuItem.Text = "Buscar Producto";
            this.buscarProdcutoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // CodigoBarrasViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodigoBarrasViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Barras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CodigoBarrasViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCopias;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panel2;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteCB;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.Label LblClaveProducto;
        private System.Windows.Forms.Button btnCopiasCarta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox txtProdDescripcion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProdcutoToolStripMenuItem;
    }
}