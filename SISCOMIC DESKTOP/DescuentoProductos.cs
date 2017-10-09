using Stmx.Siscomic.Business;
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
    public partial class DescuentoProductos : Form
    {
        ValidacionCampos vc = new ValidacionCampos();
        DateTime fechaHoy = DateTime.Today;
        DateTime fechaAño = DateTime.Today.AddMonths(1);
        public DescuentoProductos()
        {
            InitializeComponent();
            dtFechaInicio.Text = fechaHoy.ToShortDateString();
            dtFechaFin.Text = fechaAño.ToShortDateString();
        }

        private void DescuentoProductos_Load(object sender, EventArgs e)
        {
            ObtenerDescuentoProducto(txtClave.Text);
        }
        private void ObtenerDescuentoProducto(string idProducto)
        {
            try
            {
                Boolean bolDescuento;
                Boolean bolPrecio;
                DateTime fechaInicio;
                DateTime fechaFin;
                double porcDescuento;
                double precNormal;
                bolDescuento = new BusProductos().ValidarDescuento(txtClave.Text.Trim());
                bolPrecio = new BusProductos().ValidarPrecio(txtClave.Text.Trim());
                if (bolDescuento == true && bolPrecio == true)
                {
                    List<string> lst = new BusProductos().ObtenerDescuento(txtClave.Text.Trim());
                    // hidIdPrecio.Text = lst[0];
                    precNormal = Convert.ToDouble(lst[1]);
                    lblPrecioNormal.Text = precNormal.ToString();
                    hidPorcId.Text = lst[2];
                    porcDescuento = Convert.ToDouble(lst[3]);
                    lblPorcentajeActual.Text = porcDescuento.ToString();
                    fechaInicio = Convert.ToDateTime(lst[4]);
                    dtFechaInicio.Text = fechaInicio.ToString("dd/MM/yyyy");
                    fechaFin = Convert.ToDateTime(lst[5]);
                    dtFechaFin.Text = fechaFin.ToString("dd/MM/yyyy");
                    precNormal = precNormal - ((precNormal * porcDescuento) / 100);
                    lblPrecioDesc.Text = precNormal.ToString();
                    // txtPrecioCompra.Enabled = false;
                    //  txtPrecioVenta.Enabled = false;
                    //    dtFechaInicio.Enabled = false;
                    //    dtFechaFin.Enabled = false;

                }
                else if (bolDescuento == false && bolPrecio == true)
                {
                    List<string> lst = new BusProductos().ObtenerPrecio(txtClave.Text.Trim());
                    precNormal = Convert.ToDouble(lst[2]);
                    lblPrecioNormal.Text = precNormal.ToString();
                    lblPorcentajeActual.Text = "0.0";
                    lblPrecioDesc.Text = "S/D";
                    hidPorcId.Text = "";
                }
                else if (bolDescuento == false && bolPrecio == false)
                {
                    hidPorcId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al tratar de crear un porcentaje de descuento para el Producto: " + txtClave.Text + ", " + ex, "¡ Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
