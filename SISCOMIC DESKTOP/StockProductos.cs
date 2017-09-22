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
    public partial class StockProductos : Form
    {
        ValidacionCampos vc = new ValidacionCampos();
        public int stockNuevo;
        public StockProductos()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCantidadActual.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (vc.ValidarRequeridoTexto(txtCantidadActual, 1, lblRequerido) == false)
            {
                return;
            }
            int cantidad = Convert.ToInt32(txtCantidadActual.Text.Trim()) + (txtNuevaCantidad.Text == "" ? 0 : Convert.ToInt32(txtNuevaCantidad.Text.Trim()));
            int filas = new BusProductos().ActualizarStockProductos(lblClaveProducto.Text, cantidad, Convert.ToInt32(EntGlobalUsuarios.IdUsuario)); 
            if (filas > 0)
            {
                MessageBox.Show("Stock Actualizado Correctamente", "¡ Mensaje de Confirmación !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AltaProductos ap = new AltaProductos();
                stockNuevo = cantidad;
                txtCantidadActual.Text = cantidad.ToString();
                txtCantidadActual.Enabled = false;
                txtNuevaCantidad.Text = "";
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidadActual_TextChanged(object sender, EventArgs e)
        {
            vc.ValidarCamposTexto(txtCantidadActual, "^[0-9]+$", "min");
            lblRequerido.Visible = false;
        }

        private void txtNuevaCantidad_TextChanged(object sender, EventArgs e)
        {
            vc.ValidarCamposTexto(txtNuevaCantidad, "^[0-9]+$", "min");
        }

        private void StockProductos_Load(object sender, EventArgs e)
        {
            stockNuevo = Convert.ToInt32(txtCantidadActual.Text);
        }

        private void tbcStock_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tbcStock.SelectedIndex == 1)
            {
                dgvStockHistorico.DataSource = new BusProductos().ObtenerStockHistorico(lblClaveProducto.Text);
            }
        }

    }
}
