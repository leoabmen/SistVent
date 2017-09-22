using Stmx.Siscomic.Business;
using Stmx.Siscomic.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    public partial class Productos : Form
    {
        private string cellClave = String.Empty;
        private string colorCeldaAnterior = String.Empty;
        public Productos()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Menu m = new Menu();
                m.Show();
                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Productos/HomeP.png");
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Productos/HomeG.png");
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Productos/HomeM.png");
        }

        private void btnMenu_MouseUp(object sender, MouseEventArgs e)
        {
            btnMenu.Image = System.Drawing.Bitmap.FromFile(@"Images/Productos/HomeG.png");
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ActivarPermisos();
            CargarTablaProductos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaProductos_Click(object sender, EventArgs e)
        {
            try
            {

                AltaProductos ap = new AltaProductos();

                DialogResult res = ap.ShowDialog(); //abrimos el la ventana de stock como cuadro de dialogo modal


                if (res == DialogResult.Cancel)
                {
                    CargarTablaProductos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al intentar Actualizar la tabla de productos desde la ventana Alta de Productos. " + ex + "", "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        protected void AlternarColorFilasGrid()
        {
            dgvProductos.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }
        protected void CeldaColorWarning()
        {
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                int val = Convert.ToInt16(dgvProductos.Rows[i].Cells[6].Value.ToString());
                if (val == 1)
                {
                    //dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(253, 235, 208);
                    dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.Cornsilk;
                    //LEMONCHIFFON
                }
                else if (val < 4 && val > 1)
                //MOCCASIN
                {
                    //dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231);
                    dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (val == 0)
                {
                    // BISQUE
                    // dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.SandyBrown;
                    // dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(250, 219, 216);
                    dgvProductos.Rows[i].DefaultCellStyle.BackColor = Color.Bisque;
                }
            }
        }






        private void cmsClickCeldaGrid_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            //Preguntamos por el nombre del item pulsado
            switch (e.ClickedItem.Name)
            {
                case "cmsDetallesProducto":
                    //
                    //Copiamos el valor de la variable _cellValue al ClipBoard
                    //
                    // Clipboard.SetText(cellValue);
                    if (cellClave != null)
                    {
                        AbrirDetallesProducto();

                        break;
                    }
                    else
                    {
                        break;
                    }


                case "cmsDetallesPrecio":
                    //
                    //Copiamos el valor de toda la Fila selccionada al ClipBoard
                    //
                    DataObject dataObj = dgvProductos.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    break;

                case "cmsDetallesDescuento":
                    //
                    //Identificamos la Fila actualmente seleccionada
                    //
                    DataGridViewRow row = dgvProductos.CurrentRow;
                    //
                    //Preguntamos si el valor de Row es diferente de null, esto para evitar posibles
                    //excepciones de referencias Nulas
                    //
                    if (row != null) dgvProductos.Rows.Remove(row);

                    break;
            }

        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Preguntamos si el boton pulsado del Mouse es el Derecho
            //si no lo es no salimos sin hacer nada mas
            if (e.Button != MouseButtons.Right)
            {
                return;
            }


            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            //enviamos el valor de la celda a la variable _cellValue
            // cellValue = dgvProductos[e.ColumnIndex, e.RowIndex].Value.ToString();

            //if (dgvProductos[0, e.RowIndex].Value.ToString() == "")
            //{
            //    return;
            //}

            //else
            //{
            cellClave = dgvProductos[0, e.RowIndex].Value.ToString();
            //}


            //Definimos el lugar donde aparecera el scontextMenuStrip
            cmsClickCeldaGrid.Show(MousePosition);

        }

        private void cmsClickCeldaGrid_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Coloca de nuevo el color de precaucion al ordenar las columnas
            CeldaColorWarning();
            dgvProductos.ClearSelection();
        }
        private void ActivarPermisos()
        {
            new ControladorPermisos().RevisarPermisosToolStripMenuItem(cmsDetallesPrecio, EntGlobalUsuarios.IdPerfil, EntDefinicionVentanas.IdFrmProductos, EntDefinicionFunciones.IdClickDerechoGridPrecioProducto);
            new ControladorPermisos().RevisarPermisosToolStripMenuItem(cmsDetallesDescuento, EntGlobalUsuarios.IdPerfil, EntDefinicionVentanas.IdFrmProductos, EntDefinicionFunciones.IdClickDerechoGridDescuentoProductos);
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // e.CellStyle.SelectionBackColor = Color.DarkOliveGreen;
            //  e.CellStyle.SelectionForeColor = Color.Yellow;

            e.CellStyle.SelectionBackColor = Color.LightSkyBlue;
            e.CellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvProductos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                colorCeldaAnterior = dgvProductos.Rows[e.RowIndex].InheritedStyle.BackColor.Name;
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
                // whitesmoke

            }

        }

        private void dgvProductos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromName(colorCeldaAnterior);
            }
        }

        private void dgvProductos_MouseDown(object sender, MouseEventArgs e)
        {
            //  if (e.Button == MouseButtons.Right)
            //  {
            //  DataGrid.HitTestInfo hti = dgvProductos.HitTest(e.X, e.Y);
            // int filaSeleccionada = dgvProductos.Rows[hti.RowIndex].Index;
            //    if (filaSeleccionada > )
            //    {
            //        dgvProductos.ClearSelection();
            //        dgvProductos.Rows[hti.RowIndex].Selected = true;
            //        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    }

            // Point p = new Point(e.X, e.Y);
            //  DataGrid.HitTestInfo hti = dgvProductos.HitTest(e.X, e.Y);
            //int SelectedRowIndex = hti.Row; //variable global para guardar el indice
            //  }
        }

        private void dgvProductos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dgvProductos.ClearSelection();
                dgvProductos.Rows[e.RowIndex].Selected = true;
                dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        private void AbrirDetallesProducto()
        {
            AltaProductos ap = new AltaProductos();
            ap.txtClave.Text = cellClave;
            ap.btnActualizarStock.Visible = true;
            ap.FormClosed += new FormClosedEventHandler(AltaProductos_FormClosed);
            ap.ShowDialog();

        }
        public void CargarTablaProductos()
        {
            AlternarColorFilasGrid();
            dgvProductos.DataSource = new BusProductos().GetFullProductos();
            CeldaColorWarning();
            dgvProductos.ClearSelection();
        }
        private void AltaProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed   
            // Bind the Grid view       
            CargarTablaProductos();
        }
    }

}
